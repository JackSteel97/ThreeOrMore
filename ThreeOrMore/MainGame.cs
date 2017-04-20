using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeOrMore {
    public partial class MainGame : Form {

        public List<Player> players;
        public int dieFaces;
        public int scoreToWin;
        delegate void SetTextCallback(string text);
        delegate void SetHistoryCallback(List<HistoryEntry> history);
        private UIGame game;

        public MainGame() {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e) {
            UIDie[] dice = new UIDie[5];
            dice[0] = new UIDie(dieFaces, die1);
            dice[1] = new UIDie(dieFaces, die2);
            dice[2] = new UIDie(dieFaces, die3);
            dice[3] = new UIDie(dieFaces, die4);
            dice[4] = new UIDie(dieFaces, die5);


            game = new UIGame(scoreToWin, players.ToArray(), dice,updateHintLbl, updateTurnLbl, addToHistory);
            game.startGame();

        }

        private void updateHintLbl(string text) {
            if (this.hintLbl.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(updateHintLbl);
                this.Invoke(d, new object[] { text });
            } else {
                this.hintLbl.Text = text;
            }
        }

        private void updateTurnLbl(string text) {
            if (this.turnLbl.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(updateTurnLbl);
                this.Invoke(d, new object[] { text });
            } else {
                this.turnLbl.Text = text;
            }
            rollAllBtn.Enabled = true;
        }
        private void updateStats(List<HistoryEntry> history) {

            HistoryEntry lastTurn = new HistoryEntry("");
            for (int i = history.Count - 1; i > 0; i--) {
                if (history[i].Dice != null) {
                    lastTurn = history[i];
                    avgLastTurnLbl.Text = string.Format("Average of dice last turn: {0}", Math.Round(lastTurn.getAverageofDice(), 2));
                    totalLastTurnLbl.Text = string.Format("Total of dice last turn: {0}", lastTurn.getTotalofDice());
                    break;
                }
            }

            //calculate avg total
            double total = 0;
            double count = 0;
            foreach (HistoryEntry h in history) {
                if (h.Dice != null) {
                    total += h.getTotalofDice();
                    count++;
                }

            }
            double avg = total / count;
            if (avg > 0) {
                avgTotalLbl.Text = string.Format("Average Total: {0}", Math.Round(avg, 2));
            }
                

            
        }

        private void addToHistory(List<HistoryEntry> history) {
            //history
            if (this.historyContainer.InvokeRequired) {
                SetHistoryCallback d = new SetHistoryCallback(addToHistory);
                this.Invoke(d, new object[] { history });
            } else {
               
                    MonoFlat.MonoFlat_Label lbl = new MonoFlat.MonoFlat_Label();
                    lbl.AutoSize = true;
                    lbl.MaximumSize = new Size(historyContainer.Width - 10, 500);
                    lbl.Margin = new Padding(5);
                    lbl.Text = history.Last().getReadableFormat();
                    lbl.Parent = historyContainer;
                    MonoFlat.MonoFlat_Separator sep = new MonoFlat.MonoFlat_Separator();
                    sep.Margin = new Padding(0, 10, 0, 10);
                    sep.Width = historyContainer.Width;
                    historyContainer.Controls.Add(lbl);
                    historyContainer.Controls.Add(sep);
                updateStats(history);
            }

        
        }

        private void rollAllBtn_Click(object sender, EventArgs e) {
            game.rollAllDice();
            rollAllBtn.Enabled = false;
        }
    }
}
