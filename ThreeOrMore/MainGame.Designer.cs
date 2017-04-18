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
            this.SuspendLayout();
            // 
            // gameContainer
            // 
            this.gameContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
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
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer gameContainer;
    }
}