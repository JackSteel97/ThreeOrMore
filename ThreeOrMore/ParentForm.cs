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
    }
}