namespace ThreeOrMore {
    partial class MainGame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gameContainer = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.gameContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameContainer
            // 
            this.gameContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.gameContainer.Controls.Add(this.monoFlat_ControlBox1);
            this.gameContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gameContainer.Location = new System.Drawing.Point(0, 0);
            this.gameContainer.Name = "gameContainer";
            this.gameContainer.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.gameContainer.RoundCorners = true;
            this.gameContainer.Sizable = true;
            this.gameContainer.Size = new System.Drawing.Size(1904, 1041);
            this.gameContainer.SmartBounds = true;
            this.gameContainer.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gameContainer.TabIndex = 0;
            this.gameContainer.Text = "Three or More";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(1804, 0);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 0;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.gameContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Three or More";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gameContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer gameContainer;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
    }
}