using System;
using System.Collections.Generic;

namespace ThreeOrMore {

    internal class Game {

        //an array of Die objects used in this game
        private Die[] dice;

        //A (circular) queue to keep the turn order
        private Queue<Player> players = new Queue<Player>();

        //A list of HistoryEntry objects forming a history of the game
        private List<HistoryEntry> history = new List<HistoryEntry>();

        //indicates game over state
        private bool gameOver;

        //current turn number, starting from turn 1
        private int turnNumber;

        //score required to match or exceed in order to win the game
        private int WINNING_SCORE;

        /// <summary>
        /// Constructs a new Game object
        /// </summary>
        /// <param name="scoreToWin">Score required to win the game</param>
        /// <param name="players">Players involved in this game</param>
        /// <param name="dice">Dice involved in this game</param>
        public Game(int scoreToWin, Player[] players, Die[] dice) {
            //ensure score is greater than 0
            if (scoreToWin <= 0) {
                throw new Exception("Score needed to win must be a positive integer greater than zero.");
            }
            //assign properties
            this.WINNING_SCORE = scoreToWin;
            this.turnNumber = 1;
            this.gameOver = false;
            this.dice = dice;
            //add initial history entry
            history.Add(new HistoryEntry("Game Start"));

            //add each player to the queue
            foreach (Player player in players) {
                this.players.Enqueue(player);
            }
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        public void startGame() {
            //call nextTurn until the game is finished
            do {
                nextTurn();
            } while (!gameOver);
        }

        /// <summary>
        /// Starts the next turn of the game
        /// </summary>
        private void nextTurn() {
            //store the current player in a local variable
            Player activePlayer = players.Dequeue();
            resetDice();
            //wait for the player to roll all the dice
            do {
                int die = getDiceToRollNext();
                dice[die].roll();
                outputRolledDice();
            } while (!allDiceRolled());

            bool reroll;
            //find any matching dice
            Dictionary<int, int> numberOccurrences = countDiceValues();
            //see if the player has scored or earned a reroll
            activePlayer.Points += analyseDiceForScore(numberOccurrences, out reroll);
            //check if the player can reroll
            if (reroll) {
                //notify the player
                alertToTwoMatches();
                //find the numbers that match
                int doubleNumber = 0;
                foreach (KeyValuePair<int, int> entry in numberOccurrences) {
                    if (entry.Value == 2) {
                        doubleNumber = entry.Key;
                    }
                }
                //reset other dice
                foreach (Die die in dice) {
                    if (die.Value != doubleNumber) {
                        die.Rolled = false;
                    }
                }
                //reroll
                do {
                    int die = getDiceToRollNext();
                    dice[die].roll();
                    outputRolledDice();
                } while (!allDiceRolled());

                //find any matching dice
                numberOccurrences = countDiceValues();
                //determine if any points have been scored
                activePlayer.Points += analyseDiceForScore(numberOccurrences, out reroll, true);
                //clone the dice and add the turn to the history
                HistoryEntry h;
                List<Die> clone = new List<Die>();
                foreach (Die die in dice) {
                    clone.Add((Die)die.Clone());
                }

                history.Add(new HistoryEntry(turnNumber, activePlayer, clone.ToArray(), "after re-rolling"));
            }
            //notify of turn end
            outputNextTurn(activePlayer);
            //does the player have enough points to win?
            if (activePlayer.Points >= WINNING_SCORE) {
                //they do, end the game
                endGame(activePlayer);
            }
            //add player to the end of the queue and increment the turn counter
            players.Enqueue(activePlayer);
            turnNumber++;
        }

        /// <summary>
        /// Notifies the user to the end of a turn
        /// </summary>
        /// <param name="activePlayer">The player whose turn has ended</param>
        private void outputNextTurn(Player activePlayer) {
            Console.Clear();
            Console.WriteLine("{0} turn over, their current score is: {1}", activePlayer.Name, activePlayer.Points);
        }

        /// <summary>
        /// Ends the game
        /// </summary>
        /// <param name="winner">The Player who has won</param>
        private void endGame(Player winner) {
            //change gameOver flag
            gameOver = true;
            Console.WriteLine("Game Over! {0} won with a score of {1} in {2} turns.", winner.Name, winner.Points, turnNumber);
        }

        /// <summary>
        /// Counts any matching die values
        /// </summary>
        /// <returns>Key:= die value, Value:= number of occurrences</returns>
        private Dictionary<int, int> countDiceValues() {
            //create a dictionary of key-value pairs
            Dictionary<int, int> numberOccurrences = new Dictionary<int, int>();
            //iterate through the dice
            foreach (Die die in dice) {
                int value = die.Value;
                //does the dictionary already contain this value?
                if (numberOccurrences.ContainsKey(value)) {
                    //it does, increment the counter for it
                    numberOccurrences[value]++;
                } else {
                    //it does not, add it and initialise counter to one
                    numberOccurrences.Add(value, 1);
                }
            }
            return numberOccurrences;
        }

        /// <summary>
        /// Determine if the player has scored any points, OR, earned a reroll chance
        /// </summary>
        /// <param name="numberOccurrences">Occurrences of die values</param>
        /// <param name="reroll">out parameter specifying if a reroll has been earned</param>
        /// <param name="secondRoll">specifies if a reroll has already occurred this turn</param>
        /// <returns>The score earned</returns>
        private int analyseDiceForScore(Dictionary<int, int> numberOccurrences, out bool reroll, bool secondRoll = false) {
            //initialise reroll flag to false
            reroll = false;
            if (numberOccurrences.ContainsValue(5)) {
                //5 of a kind
                return 12;
            } else if (numberOccurrences.ContainsValue(4)) {
                //4 of a kind
                return 6;
            } else if (numberOccurrences.ContainsValue(3)) {
                //3 of a kind
                return 3;
            } else if (numberOccurrences.ContainsValue(2)) {
                //2 of a kind
                if (!secondRoll) {
                    //a reroll is permitted
                    reroll = true;
                }
            }
            return 0;
        }

        /// <summary>
        /// Reset all dice states to unrolled
        /// </summary>
        private void resetDice() {
            foreach (Die die in dice) {
                die.Rolled = false;
            }
        }

        /// <summary>
        /// Notify the player they may reroll
        /// </summary>
        private void alertToTwoMatches() {
            Console.WriteLine("You have two of a kind and may re-throw remaining dice.");
        }

        /// <summary>
        /// Check if all dice have been rolled
        /// </summary>
        /// <returns>True if all dice have been rolled</returns>
        private bool allDiceRolled() {
            foreach (Die die in dice) {
                if (!die.Rolled) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Output the values of any dice that have been rolled
        /// </summary>
        private void outputRolledDice() {
            for (int i = 0; i < dice.Length; i++) {
                //has this die been rolled?
                if (dice[i].Rolled) {
                    //it has, output its number and value
                    Console.WriteLine("Die {0}: {1}", i + 1, dice[i].Value);
                }
            }
        }

        /// <summary>
        /// Get the index of the die the player wishes to roll next
        /// </summary>
        /// <returns>An index of the dice array</returns>
        private int getDiceToRollNext() {
            Console.WriteLine("Select which dice to roll next: ");
            List<int> validDice = new List<int>();
            //find the indexes of all dice that have not been rolled yet
            for (int i = 0; i < dice.Length; i++) {
                if (!dice[i].Rolled) {
                    Console.WriteLine("Die ({0})", i + 1);
                    validDice.Add(i + 1);
                }
            }

            //get and validate user input
            bool valid = false;
            int dieNum = 0;
            //repeat until a valid input is given
            do {
                Console.Write("\nEnter a number: ");
                string input = Console.ReadLine();
                //ensure the input is an integer
                valid = int.TryParse(input, out dieNum);
                if (valid) {
                    //ensure the input is one of the unrolled dice
                    valid = validDice.Contains(dieNum);
                }

                if (!valid) {
                    Console.WriteLine("Invalid choice...");
                }
            } while (!valid);
            return dieNum - 1;
        }
    }
}