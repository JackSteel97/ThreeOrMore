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
        /// Convert a boolean value to 'Yes' or 'No'
        /// </summary>
        /// <param name="b">boolean to convert</param>
        /// <returns>A yes or no string</returns>
        private string boolToYesNoString (bool b) {
            if(b) {
                return "Yes";
            }
            return "No";
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
                playerLbl.Text = string.Format("Player {0}:\n\t{1}\n\tAI:{2}", players.Count + 1, newPlayerNameTxt.Text.Trim(),boolToYesNoString(aiCheck.Checked));
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

        private void GameSetup_Load(object sender, EventArgs e) {
            alignAndSizeControls();
        }

        /// <summary>
        /// Align and size controls with respect to the size of the form
        /// </summary>
        private void alignAndSizeControls() {
            setLocationByPercentage(scoreToWinLbl, 20, 13);

            setSizeByPercentage(scoreSlider, 18, 1.145);
            setLocationByPercentage(scoreSlider, 20, 15);

            setSizeByPercentage(newPlayerNameTxt, 10, 5);
            setLocationByPercentage(newPlayerNameTxt, 50, 13);

            setSizeByPercentage(addNewPlayerBtn, 6.25, 3.7);
            setLocationByPercentage(addNewPlayerBtn, 50, 18);

            setLocationByPercentage(aiCheck, 58.5, 18);

            setLocationByPercentage(dieFacesLbl, 80, 13);

            setSizeByPercentage(dieFacesSlider, 18, 1.145);
            setLocationByPercentage(dieFacesSlider, 80, 15);

            setSizeByPercentage(startGameBtn, 7.5, 3.8);
            setLocationByPercentage(startGameBtn, 95, 23);

        }

        /// <summary>
        /// set a controls midpoint location as a percentage of the form size
        /// </summary>
        /// <param name="control">Control to change location</param>
        /// <param name="xPercent">Percentage from left of form to center of control</param>
        /// <param name="yPercent">Percentage from top of form to center of control</param>
        private void setLocationByPercentage(Control control, double xPercent, double yPercent) {
            control.Location = new Point((int)Math.Round(this.Width * (xPercent / 100)) - (control.Width / 2), (int)Math.Round(this.Height * (yPercent / 100)) - (control.Height / 2));
            control.BringToFront();
        }

        /// <summary>
        /// set a controls size as a percentage of the form size
        /// </summary>
        /// <param name="control">Control to change size</param>
        /// <param name="widthPercent">Percentage of form width control should fill</param>
        /// <param name="heightPercent">Percentage of form heigh control should fill</param>
        private void setSizeByPercentage(Control control, double widthPercent, double heightPercent) {
            control.Size = new Size((int)Math.Round(this.Width * (widthPercent / 100)), (int)Math.Round(this.Height * (heightPercent / 100)));
        }
    }
}