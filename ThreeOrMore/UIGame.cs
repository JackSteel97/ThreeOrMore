using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeOrMore {
    class UIGame {
        private UIDie[] dice;
        private Queue<Player> players = new Queue<Player>();
        private bool gameOver;
        private int turnNumber;
        private int WINNING_SCORE;
        private MonoFlat.MonoFlat_HeaderLabel turnLbl;

        public UIGame(int scoreToWin, Player[] players, UIDie[] dice, MonoFlat.MonoFlat_HeaderLabel turnLbl) {
            if (scoreToWin <= 0) {
                throw new Exception("Score needed to win must be a positive integer greater than zero.");
            }
            this.WINNING_SCORE = scoreToWin;
            this.turnNumber = 1;
            this.gameOver = false;
           

            foreach (Player player in players) {
                this.players.Enqueue(player);
            }

            this.dice = dice;

            foreach(UIDie die in dice) {
                die.DieImage.MouseUp += new MouseEventHandler(die_MouseUp);
            }
        }

        public void startGame() {
                nextTurn();           
        }

        private void nextTurn() {
            Player activePlayer = players.Dequeue();
            updateTurnLbl(activePlayer);
            resetDice();
        }

        private void updateTurnLbl(Player activePlayer) {
            if (activePlayer.Name[activePlayer.Name.Length - 1].ToString().ToLower() == "s") {
                turnLbl.Text = activePlayer.Name + "' Turn";
            } else {
                turnLbl.Text = activePlayer.Name + "'s Turn";
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

        private void die_MouseUp(object sender, MouseEventArgs e) {

        }
    }
}
