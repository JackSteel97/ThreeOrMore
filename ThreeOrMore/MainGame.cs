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


            UIGame game = new UIGame(scoreToWin, players.ToArray(), dice,updateHintLbl, updateTurnLbl);
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
        }
    }
}
