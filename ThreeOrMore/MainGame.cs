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


        }
    }
}
