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
    }
}
