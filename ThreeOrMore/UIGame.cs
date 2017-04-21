using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ThreeOrMore {

    /// <summary>
    /// Class for a game with UI components
    /// </summary>
    internal class UIGame {

        //array of UIDie objects
        private UIDie[] dice;

        //(circular) queue of players
        private Queue<Player> players = new Queue<Player>();

        //flag for game over state
        private bool gameOver;

        //turn number counter
        private int turnNumber;

        //score needed to win the game
        private int WINNING_SCORE;

        //Player whose turn it currently is
        private Player activePlayer;

        //flag to indicate if the player has used their reroll this turn
        private bool rerollUsed = false;

        //method to update the hint label in a thread-safe way
        private Action<string> updateHint;

        //method to update the turn label in a thread-safe way
        private Action<string> updateTurn;

        //method to add to the history list in a thread-safe way
        private Action<List<HistoryEntry>> addToHistory;

        //history list for this game
        private List<HistoryEntry> history = new List<HistoryEntry>();

        //flag to indicate if double points are used this turn
        private bool doublePoints = false;

        //flag to indicate if the end of turn is being processed. Prevents multiple dice finishing at the same time and firing multiple turn ends.
        private bool turnProcessing = false;

        //flag to indicate if the current turn is being handled by an AI player
        private bool aiTurn = false;

        /// <summary>
        /// Flag to indicate if the current turn is being handled by an AI player
        /// </summary>
        public bool AITurn {
            get {
                return this.aiTurn;
            }
        }

        /// <summary>
        /// Construct a new UIGame object
        /// </summary>
        /// <param name="scoreToWin">Score needed to win the game</param>
        /// <param name="players">Players involved in this game</param>
        /// <param name="dice">Dice used in this game</param>
        /// <param name="hintUpdater">Method to update the hint label</param>
        /// <param name="turnUpdater">Method to update the turn label</param>
        /// <param name="historyAdder">Method to add to the UI history list</param>
        public UIGame(int scoreToWin, Player[] players, UIDie[] dice, Action<string> hintUpdater, Action<string> turnUpdater, Action<List<HistoryEntry>> historyAdder) {
            //ensure the score is greater than zero
            if (scoreToWin <= 0) {
                throw new Exception("Score needed to win must be a positive integer greater than zero.");
            }
            //assign properties
            this.WINNING_SCORE = scoreToWin;
            this.turnNumber = 1;
            this.gameOver = false;
            this.updateHint = hintUpdater;
            this.updateTurn = turnUpdater;
            this.addToHistory = historyAdder;
            this.dice = dice;
            //add each player to the queue
            foreach (Player player in players) {
                this.players.Enqueue(player);
            }

            //set event handlers for each die's UI control
            foreach (UIDie die in dice) {
                die.DieImage.MouseUp += new MouseEventHandler(die_MouseUp);
            }
        }

        /// <summary>
        /// Start the game
        /// </summary>
        public void startGame() {
            //add initial history entry
            HistoryEntry h = new HistoryEntry("Game Started");
            history.Add(h);
            addToHistory(history);
            //start the first turn
            nextTurn();
        }

        /// <summary>
        /// Start the next turn
        /// </summary>
        private void nextTurn() {
            //get the player whose turn it is from the front of the queue
            activePlayer = players.Dequeue();
            //update the turn label
            updateTurnLbl();
            //reset variables and dice
            rerollUsed = false;
            resetDice();
            doublePoints = false;
            aiTurn = false;
            //is this player an AI?
            if (activePlayer.AIPlayer) {
                //yes, take it's turn
                takeAITurn();
            }
        }

        /// <summary>
        /// Have any dice been rolled?
        /// </summary>
        /// <returns>True if any of the dice have been rolled OR are currently rolling</returns>
        private bool anyDiceHaveBeenRolled() {
            //iterate through each die to check its state
            foreach (UIDie die in dice) {
                if (die.Rolled || die.Rolling) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Roll all dice once
        /// </summary>
        public void rollAllDice() {
            //ensure this is the first dice roll of the turn
            if (!rerollUsed && !anyDiceHaveBeenRolled()) {
                //enable double points
                doublePoints = true;
                //iterate through the dice and roll each one
                foreach (UIDie die in dice) {
                    die.roll(aDieFinished);
                    //make the random generator different for each die by waiting
                    Thread.Sleep(50);
                }
            }
        }

        /// <summary>
        /// Update the turn label
        /// </summary>
        private void updateTurnLbl() {
            //format the name correctly depending on if it ends with an 's' or not
            if (activePlayer.Name[activePlayer.Name.Length - 1].ToString().ToLower() == "s") {
                updateTurn(activePlayer.Name + "' Turn");
            } else {
                updateTurn(activePlayer.Name + "'s Turn");
            }
        }

        /// <summary>
        /// Reset all dice
        /// </summary>
        private void resetDice() {
            foreach (UIDie die in dice) {
                die.Rolled = false;
                die.DieImage.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Have all dice been rolled?
        /// </summary>
        /// <returns>True if every die has been rolled</returns>
        private bool allDiceRolled() {
            foreach (UIDie die in dice) {
                if (!die.Rolled) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Callback for when a die finishes rolling
        /// </summary>
        private void aDieFinished() {
            //have all dice finished?
            if (allDiceRolled() && !turnProcessing) {
                //yes, count the dice value occurrences
                bool reroll;
                //set processing flag
                turnProcessing = true;
                Dictionary<int, int> numberOccurrences = countDiceValues();
                //are double points enabled?
                if (!doublePoints) {
                    //no, check if any points or a reroll has been earned
                    activePlayer.Points += analyseDiceForScore(numberOccurrences, out reroll);
                } else {
                    //yes, check if any points have been earned and double them
                    activePlayer.Points += analyseDiceForScore(numberOccurrences, out reroll) * 2;
                }
                //is a reroll permitted?
                if (reroll && !rerollUsed && !doublePoints) {
                    //yes, flag the reroll as used
                    rerollUsed = true;
                    //notify the player
                    alertToTwoMatches();
                    //find the numbers that match
                    int doubleNumber = 0;
                    foreach (KeyValuePair<int, int> entry in numberOccurrences) {
                        if (entry.Value == 2) {
                            doubleNumber = entry.Key;
                            break;
                        }
                    }
                    //reset other dice
                    foreach (UIDie die in dice) {
                        if (die.Value != doubleNumber) {
                            die.Rolled = false;
                            die.DieImage.BackColor = System.Drawing.Color.White;
                        }
                    }
                    //is it the AI's turn?
                    if (aiTurn) {
                        //yes, roll the remaining dice automatically
                        foreach (UIDie die in dice) {
                            if (!die.Rolled) {
                                die.roll(aDieFinished);
                                Thread.Sleep(50);
                            }
                        }
                    }
                    //reset processing flag
                    turnProcessing = false;
                } else {
                    //no, a reroll is not permitted, its the end of the turn. Notify the player
                    outputNextTurn();
                    //reset processing flag
                    turnProcessing = false;
                    //has the player won?
                    if (activePlayer.Points >= WINNING_SCORE) {
                        //yes, end the game
                        endGame();
                    } else {
                        //no, clone the dice and add to a new history entry
                        HistoryEntry h;
                        List<UIDie> clone = new List<UIDie>();
                        foreach (UIDie die in dice) {
                            clone.Add((UIDie)die.Clone());
                        }
                        //was a reroll used?
                        if (rerollUsed) {
                            //yes, add the history with notes for re-rolling
                            h = new HistoryEntry(turnNumber, activePlayer, clone.ToArray(), "after re-rolling");
                        } else {
                            //no, just add the base history
                            h = new HistoryEntry(turnNumber, activePlayer, clone.ToArray());
                        }
                        history.Add(h);
                        addToHistory(history);
                        //add player back to end of queue
                        players.Enqueue(activePlayer);
                        //increment turn counter
                        turnNumber++;
                        //start next turn
                        nextTurn();
                    }
                }
            }
        }

        /// <summary>
        /// Notify the user to two-of-a-kind match
        /// </summary>
        private void alertToTwoMatches() {
            updateHint("You have two-of-a-kind and may re-throw the remaining dice.");
        }

        /// <summary>
        /// Update the turn label
        /// </summary>
        private void outputNextTurn() {
            //format the name depending on if it ends with an 's' or not
            if (activePlayer.Name[activePlayer.Name.Length - 1].ToString().ToLower() == "s") {
                updateHint(string.Format("{0}' turn over, their current score is: {1}", activePlayer.Name, activePlayer.Points));
            } else {
                updateHint(string.Format("{0}'s turn over, their current score is: {1}", activePlayer.Name, activePlayer.Points));
            }
        }

        /// <summary>
        /// End the game
        /// </summary>
        private void endGame() {
            //set game over flag
            gameOver = true;
            //output to user
            updateHint(string.Format("Game Over! {0} won with a score of {1} in {2} turns.", activePlayer.Name, activePlayer.Points, turnNumber));
        }

        /// <summary>
        /// Counts any matching die values
        /// </summary>
        /// <returns>Key:= die value, Value:= number of occurrences</returns>
        private Dictionary<int, int> countDiceValues() {
            Dictionary<int, int> numberOccurrences = new Dictionary<int, int>();
            foreach (UIDie die in dice) {
                int value = die.Value;
                if (numberOccurrences.ContainsKey(value)) {
                    numberOccurrences[value]++;
                } else {
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
        /// <returns>The score earned</returns>
        private int analyseDiceForScore(Dictionary<int, int> numberOccurrences, out bool reroll) {
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
                reroll = true;
            }
            return 0;
        }

        /// <summary>
        /// Event handler for player clicking on the die's UI component
        /// </summary>
        /// <param name="sender">PictureBox that was clicked</param>
        /// <param name="e">event args</param>
        private void die_MouseUp(object sender, MouseEventArgs e) {
            //ensure it's not an AI turn
            if (!aiTurn) {
                //cast the PictureBox to a variable
                PictureBox img = (PictureBox)sender;
                //get the index of the die that was clicked
                int dieNum = Convert.ToInt32(img.Name[img.Name.Length - 1].ToString()) - 1;
                //can the die can be rolled?
                if (!dice[dieNum].Rolled && !gameOver && !dice[dieNum].Rolling) {
                    //yes, roll the die
                    dice[dieNum].roll(aDieFinished);
                }
            }
        }

        /// <summary>
        /// Handles the AI's turn
        /// </summary>
        private void takeAITurn() {
            //set AI turn flag
            aiTurn = true;
            //generate a random number from 0 to 2
            Random rnd = new Random();
            int selector = rnd.Next(3);
            //is the random number less than or equal to one?
            //(AI has 66% chance to choose to roll all dice once and 33% chance to choose to roll normally)
            if (selector <= 1) {
                //yes, roll all dice once
                rollAllDice();
            } else {
                //no, roll each die individually and allow a reroll
                foreach (UIDie die in dice) {
                    die.roll(aDieFinished);
                    Thread.Sleep(50);
                }
            }
        }
    }
}