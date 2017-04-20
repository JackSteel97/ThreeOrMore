using System;
using System.Windows.Forms;

namespace ThreeOrMore {

    public partial class ParentForm : Form {

        public ParentForm() {
            InitializeComponent();
        }

        private void newGameBtn_Click(object sender, EventArgs e) {
            GameSetup setup = new GameSetup();
            setup.Show();
            this.Hide();
        }
    }
}