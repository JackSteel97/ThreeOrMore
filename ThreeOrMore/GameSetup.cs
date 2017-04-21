using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ThreeOrMore {

    /// <summary>
    /// Code-behind for GameSetup form
    /// </summary>
    public partial class GameSetup : Form {

        //declare variables and assign default values
        private List<Player> players = new List<Player>();

        private int dieFaces = 6;
        private int scoreToWin = 50;

        public GameSetup() {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the addNewPlayerBtn control is clicked
        /// </summary>
        private void addNewPlayerBtn_Click(object sender, EventArgs e) {
            //ensure the player name is not empty
            if (newPlayerNameTxt.Text.Length > 0) {
                //create a new label
                MonoFlat.MonoFlat_Label playerLbl = new MonoFlat.MonoFlat_Label();
                playerLbl.AutoSize = true;
                //set the label text to the player number and entered name
                playerLbl.Text = string.Format("Player {0}:\n \t{1}", players.Count + 1, newPlayerNameTxt.Text.Trim());
                playerLbl.Margin = new Padding(15);
                playerLbl.Font = new Font("Segoe UI", 14, FontStyle.Italic, GraphicsUnit.Point);
                playerLbl.Name = string.Format("player{0}", players.Count);
                //add the label to the FlowLayoutPanel container
                playersContainer.Controls.Add(playerLbl);
                playerLbl.Show();
                //add a new player object to the list of players
                players.Add(new Player(newPlayerNameTxt.Text.Trim(), aiCheck.Checked));
                //reset the text box and check box
                newPlayerNameTxt.Text = "";
                aiCheck.Checked = false;
            }
        }

        /// <summary>
        /// Called when the dieFacesSlider control's value is changed
        /// </summary>
        private void dieFacesSlider_ValueChanged() {
            //cap the minimum value at two
            if (dieFacesSlider.Value < 2) {
                dieFacesSlider.Value = 2;
            }
            //assign the value to dieFaces
            dieFaces = dieFacesSlider.Value;
            //update text label
            dieFacesLbl.Text = string.Format("Each die has {0} faces", dieFaces);
        }

        /// <summary>
        /// Called when the scoreSlider control's value is changed
        /// </summary>
        private void scoreSlider_ValueChanged() {
            //cap the minimum value at 10
            if (scoreSlider.Value < 10) {
                scoreSlider.Value = 10;
            }
            //assign the value to scoreToWin
            scoreToWin = scoreSlider.Value;
            //update text label
            scoreToWinLbl.Text = string.Format("A player needs {0} points to win", scoreToWin);
        }

        /// <summary>
        /// Called when startGameBtn control is clicked
        /// </summary>
        private void startGameBtn_Click(object sender, EventArgs e) {
            //ensure there are some players
            if (players.Count > 0) {
                //instantiate a new game form
                MainGame game = new MainGame();
                //pass the settings over to the game form
                game.players = players;
                game.scoreToWin = scoreToWin;
                game.dieFaces = dieFaces;
                //show the game
                game.Show();
                //close this setup form
                this.Close();
            }
        }
    }
}