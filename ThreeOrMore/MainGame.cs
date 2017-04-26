using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ThreeOrMore {

    public partial class MainGame : Form {

        //game properties from GameSetup
        public List<Player> players;

        public int dieFaces;
        public int scoreToWin;

        //delegates for thread-safe UI access
        private delegate void SetTextCallback(string text);

        private delegate void SetHistoryCallback(List<HistoryEntry> history);

        private UIGame game;

        public MainGame() {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the form has finished loading
        /// </summary>
        private void MainGame_Load(object sender, EventArgs e) {

            alignAndSizeControls();
            //create an array of 5 dice
            UIDie[] dice = new UIDie[5];
            //assign UIDie objects with their picture boxes to the array
            dice[0] = new UIDie(dieFaces, die1);
            dice[1] = new UIDie(dieFaces, die2);
            dice[2] = new UIDie(dieFaces, die3);
            dice[3] = new UIDie(dieFaces, die4);
            dice[4] = new UIDie(dieFaces, die5);
            //instantiate a new UIGame with the required parameters
            game = new UIGame(scoreToWin, players.ToArray(), dice, updateHintLbl, updateTurnLbl, addToHistory);
            //start the game
            game.startGame();
        }

        /// <summary>
        /// Update the text of the hintLbl control
        /// </summary>
        /// <param name="text">Text to be set</param>
        private void updateHintLbl(string text) {
            //check if an invoke is required to make this call thread-safe
            if (this.hintLbl.InvokeRequired) {
                //use the delegate to make this method thread-safe
                SetTextCallback d = new SetTextCallback(updateHintLbl);
                this.Invoke(d, new object[] { text });
            } else {
                //set the label's text
                this.hintLbl.Text = text;
            }
        }

        /// <summary>
        /// Update the text of the turnLbl control
        /// </summary>
        /// <param name="text">Text to be set</param>
        private void updateTurnLbl(string text) {
            //check if an invoke is required to make this call thread-safe
            if (this.turnLbl.InvokeRequired) {
                //use the delegate to make this method thread-safe
                SetTextCallback d = new SetTextCallback(updateTurnLbl);
                this.Invoke(d, new object[] { text });
            } else {
                //set the label's text
                this.turnLbl.Text = text;
                //re-enable the roll all button
                rollAllBtn.Enabled = true;
            }
        }

        /// <summary>
        /// Update the game statistics
        /// </summary>
        /// <param name="history">The current game history list</param>
        private void updateStats(List<HistoryEntry> history) {
            //find the last turn in the history that had some dice rolled
            HistoryEntry lastTurn = new HistoryEntry("");
            for (int i = history.Count - 1; i > 0; i--) {
                if (history[i].Dice != null) {
                    lastTurn = history[i];
                    //set the text of the average and total of last turn labels
                    avgLastTurnLbl.Text = string.Format("Average of dice last turn: {0}", lastTurn.getAverageofDice(), 2);
                    totalLastTurnLbl.Text = string.Format("Total of dice last turn: {0}", lastTurn.getTotalofDice());
                    break;
                }
            }

            //calculate avg total
            double total = 0;
            double count = 0;
            //iterate through the history
            foreach (HistoryEntry h in history) {
                //any entry that contains some dice
                if (h.Dice != null) {
                    //add to the overall total
                    total += h.getTotalofDice();
                    //increment count of values
                    count++;
                }
            }
            //calculate the average
            double avg = total / count;
            //set the text of the label if
            if (avg > 0 && avg != double.NaN) {
                avgTotalLbl.Text = string.Format("Average Total: {0}", Math.Round(avg, 2));
            }
        }

        /// <summary>
        /// Adds the last history entry to the visible history list
        /// </summary>
        /// <param name="history">Current game's history</param>
        private void addToHistory(List<HistoryEntry> history) {
            //check if an invoke is required to make this call thread-safe
            if (this.historyContainer.InvokeRequired) {
                //use the delegate to make this method thread-safe
                SetHistoryCallback d = new SetHistoryCallback(addToHistory);
                this.Invoke(d, new object[] { history });
            } else {
                //create a new label
                MonoFlat.MonoFlat_Label lbl = new MonoFlat.MonoFlat_Label();
                lbl.AutoSize = true;
                //make it fit inside the historyContainer
                lbl.MaximumSize = new Size(historyContainer.Width - 10, 500);
                lbl.Margin = new Padding(5);
                //set it's text to the readable format of the last history entry
                lbl.Text = history.Last().getReadableFormat();
                lbl.Parent = historyContainer;
                //create a separator
                MonoFlat.MonoFlat_Separator sep = new MonoFlat.MonoFlat_Separator();
                //make it fit inside the historyContainer
                sep.Margin = new Padding(0, 10, 0, 10);
                sep.Width = historyContainer.Width;
                //add the label to the historyContainer
                historyContainer.Controls.Add(lbl);
                //add the separator to the historyContainer
                historyContainer.Controls.Add(sep);
                //pass the game history to updateStats
                updateStats(history);
            }
        }

        /// <summary>
        /// Called when the rollAllBtn control is clicked
        /// </summary>
        private void rollAllBtn_Click(object sender, EventArgs e) {
            //check it's not the AI's turn
            if (!game.AITurn) {
                //it's not, roll all the dice
                game.rollAllDice();
                //disabled the button
                rollAllBtn.Enabled = false;
            }
        }

        private void alignAndSizeControls() {
            setLocationByPercentage(turnLbl, 9.6, 12);

            setLocationByPercentage(statsContainer, 13.7, 53);

            setSizeByPercentage(hintLbl, 100, 4.63);
            setLocationByPercentage(hintLbl, 50, 25);
            
            setLocationByPercentage(die1, 34.375, 32.407);
            setLocationByPercentage(die2, 42.1875, 32.407);
            setLocationByPercentage(die3, 50, 32.407);
            setLocationByPercentage(die4, 57.8125, 32.407);
            setLocationByPercentage(die5, 65.625, 32.407);

            setSizeByPercentage(rollAllBtn, 9.375, 5.83);
            setLocationByPercentage(rollAllBtn, 50, 44);

            setLocationByPercentage(historylbl, 91.1, 26.6);

            setSizeByPercentage(historyContainer, 8.38, 67.5);
            setLocationByPercentage(historyContainer, 94.2, 61.5);

            setLocationByPercentage(statsLbl, 4.2, 25);

        }

        private void setLocationByPercentage(Control control, double xPercent, double yPercent) {
            control.Location = new Point((int)Math.Round(this.Width * (xPercent / 100)) - (control.Width / 2), (int)Math.Round(this.Height * (yPercent / 100)) - (control.Height / 2));
            control.BringToFront();
        }

        private void setSizeByPercentage(Control control, double widthPercent, double heightPercent) {
            control.Size = new Size((int)Math.Round(this.Width * (widthPercent / 100)), (int)Math.Round(this.Height * (heightPercent / 100)));
        }
    }
}