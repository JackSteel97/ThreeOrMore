using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ThreeOrMore {

    public partial class GameSetup : Form {
        private List<Player> players = new List<Player>();
        private int dieFaces = 6;
        private int scoreToWin = 50;

        public GameSetup() {
            InitializeComponent();
        }

        private void addNewPlayerBtn_Click(object sender, EventArgs e) {
            if (newPlayerNameTxt.Text.Length > 0) {
                MonoFlat.MonoFlat_Label playerLbl = new MonoFlat.MonoFlat_Label();
                playerLbl.AutoSize = true;
                playerLbl.Text = string.Format("Player {0}:\n \t{1}", players.Count + 1, newPlayerNameTxt.Text.Trim());
                playerLbl.Margin = new Padding(15);
                playerLbl.Font = new Font("Segoe UI", 14, FontStyle.Italic, GraphicsUnit.Point);
                playerLbl.Name = string.Format("player{0}", players.Count);
                playersContainer.Controls.Add(playerLbl);
                playerLbl.Show();

                players.Add(new Player(newPlayerNameTxt.Text.Trim(), aiCheck.Checked));
                newPlayerNameTxt.Text = "";
                aiCheck.Checked = false;
            }
        }

        private void dieFacesSlider_ValueChanged() {
            if (dieFacesSlider.Value < 2) {
                dieFacesSlider.Value = 2;
            }
            dieFaces = dieFacesSlider.Value;
            dieFacesLbl.Text = string.Format("Each die has {0} faces", dieFaces);
        }

        private void scoreSlider_ValueChanged() {
            if (scoreSlider.Value < 10) {
                scoreSlider.Value = 10;
            }
            scoreToWin = scoreSlider.Value;
            scoreToWinLbl.Text = string.Format("A player needs {0} points to win", scoreToWin);
        }

        private void startGameBtn_Click(object sender, EventArgs e) {
            MainGame game = new MainGame();
            game.players = players;
            game.scoreToWin = scoreToWin;
            game.dieFaces = dieFaces;
            game.Show();
            this.Close();
        }
    }
}