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
    public partial class GameSetup : Form {

        private List<Player> players = new List<Player>();

        public GameSetup() {
            InitializeComponent();
        }

        private void addNewPlayerBtn_Click(object sender, EventArgs e) {
            if (newPlayerNameTxt.Text.Length > 0) {
                MonoFlat.MonoFlat_Label playerLbl = new MonoFlat.MonoFlat_Label();
                playerLbl.AutoSize = true;
                playerLbl.Text = string.Format("Player {0}:\n\t{1}", players.Count + 1, newPlayerNameTxt.Text.Trim());
                playerLbl.Margin = new Padding(15);
                playerLbl.Name = string.Format("player{0}", players.Count);
                playersContainer.Controls.Add(playerLbl);
                playerLbl.Show();

                players.Add(new Player(newPlayerNameTxt.Text.Trim()));
                newPlayerNameTxt.Text = "";
            }        

        }
    }
}
