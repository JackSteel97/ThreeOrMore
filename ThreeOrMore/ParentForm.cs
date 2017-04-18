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
