using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeOrMore {
    class UIGame {
        private UIDie[] dice;
        private Queue<Player> players = new Queue<Player>();
        private bool gameOver;
        private int turnNumber;
        private int WINNING_SCORE;
        private Player activePlayer;
        private bool rerollUsed = false;
        private Action<string> updateHint;
        private Action<string> updateTurn;
        private Action<List<HistoryEntry>> addToHistory;
        private List<HistoryEntry> history = new List<HistoryEntry>();
        private bool doublePoints = false;

        public UIGame(int scoreToWin, Player[] players, UIDie[] dice, Action<string> hintUpdater,Action<string> turnUpdater, Action<List<HistoryEntry>> historyAdder) {
            if (scoreToWin <= 0) {
                throw new Exception("Score needed to win must be a positive integer greater than zero.");
            }
            this.WINNING_SCORE = scoreToWin;
            this.turnNumber = 1;
            this.gameOver = false;
            this.updateHint = hintUpdater;
            this.updateTurn = turnUpdater;
            this.addToHistory = historyAdder;

            

            foreach (Player player in players) {
                this.players.Enqueue(player);
            }

            this.dice = dice;

            foreach(UIDie die in dice) {
                die.DieImage.MouseUp += new MouseEventHandler(die_MouseUp);
            }
        }

        public void startGame() {
            HistoryEntry h = new HistoryEntry("Game Started");
            history.Add(h);
            addToHistory(history);

            nextTurn();           
        }

        private void nextTurn() {
            activePlayer = players.Dequeue();
            updateTurnLbl();
            rerollUsed = false;
            resetDice();
            doublePoints = false;
           
        }

        public void rollAllDice() {
            doublePoints = true;
            foreach(UIDie die in dice) {
                die.roll(aDieFinished);
                //make the random generator different for each die by waiting
                Thread.Sleep(50);
            }
        }

        private void updateTurnLbl() {
            if (activePlayer.Name[activePlayer.Name.Length - 1].ToString().ToLower() == "s") {
                updateTurn(activePlayer.Name + "' Turn");
            } else {
                updateTurn(activePlayer.Name + "'s Turn");
            }
        }

        private void resetDice() {
            foreach (UIDie die in dice) {
                die.Rolled = false;
                die.DieImage.BackColor = System.Drawing.Color.White;
            }
        }

        private bool allDiceRolled() {
            foreach (UIDie die in dice) {
                if (!die.Rolled) {
                    return false;
                }
            }
            return true;
        }

        private void aDieFinished() {
            //have all dice finished?
            if (allDiceRolled()) {
                bool reroll;
                Dictionary<int, int> numberOccurrences = countDiceValues();
                if (!doublePoints) {
                    activePlayer.Points += analyseDiceForScore(numberOccurrences, out reroll);
                }else {
                    activePlayer.Points += analyseDiceForScore(numberOccurrences, out reroll) * 2;
                }
               
                if (reroll && !rerollUsed && !doublePoints) {
                    rerollUsed = true;
                    alertToTwoMatches();
                    //find numbers that match
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
                } else {
                    outputNextTurn();
                    if (activePlayer.Points >= WINNING_SCORE) {
                        endGame();
                    } else {
                        HistoryEntry h;
                        List<UIDie> clone = new List<UIDie>();
                        foreach (UIDie die in dice) {
                            clone.Add((UIDie)die.Clone());
                        }
                        if (rerollUsed) {
                            

                            h = new HistoryEntry(turnNumber, activePlayer, clone.ToArray(), "after re-rolling");
                        } else {
                            h = new HistoryEntry(turnNumber, activePlayer, clone.ToArray());
                        }                    
                        history.Add(h);
                        addToHistory(history);
                        players.Enqueue(activePlayer);
                        turnNumber++;
                        nextTurn();
                    }
                }

               
            }
        }

        private void alertToTwoMatches() {
            updateHint("You have two of a kind and may re-throw the remaining dice.");
        }

        private void outputNextTurn() {
            if(activePlayer.Name[activePlayer.Name.Length-1].ToString().ToLower() == "s") {
                updateHint(string.Format("{0}' turn over, their current score is: {1}", activePlayer.Name, activePlayer.Points));
            }else {
                updateHint(string.Format("{0}'s turn over, their current score is: {1}", activePlayer.Name, activePlayer.Points));
            }         
        }

        private void endGame() {
            gameOver = true;
            updateHint(string.Format("Game Over! {0} won with a score of {1} in {2} turns.", activePlayer.Name, activePlayer.Points, turnNumber));
        }

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

        private void die_MouseUp(object sender, MouseEventArgs e) {
            PictureBox img = (PictureBox)sender;
            
            int dieNum = Convert.ToInt32(img.Name[img.Name.Length - 1].ToString()) - 1;
            if (!dice[dieNum].Rolled && !gameOver) {
                dice[dieNum].roll(aDieFinished);
            }
            

        }

   
    }
}
