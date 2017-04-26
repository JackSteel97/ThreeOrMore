using System;
using System.Windows.Forms;

namespace ThreeOrMore {

    public partial class ParentForm : Form {

        public ParentForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the newGameBtn control is clicked
        /// </summary>
        private void newGameBtn_Click(object sender, EventArgs e) {
            //instantiate a new GameSetup for
            GameSetup setup = new GameSetup();
            //show the setup form
            setup.Show();
            //hide this form
            this.Hide();
        }

        private void ParentForm_Load(object sender, EventArgs e) {
            alignAndSizeControls();
        }

        private void alignAndSizeControls() {
            titleLbl.Location = new System.Drawing.Point((this.Width / 2) - (titleLbl.Width / 2), titleLbl.Location.Y);
            newGameBtn.Location = new System.Drawing.Point((this.Width / 2) - (newGameBtn.Width / 2), newGameBtn.Location.Y);
        }
    }
}