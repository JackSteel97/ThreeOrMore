namespace ThreeOrMore {
    partial class GameSetup {
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
            this.gameSetupContainer = new MonoFlat.MonoFlat_ThemeContainer();
            this.startGameBtn = new MonoFlat.MonoFlat_Button();
            this.scoreToWinLbl = new MonoFlat.MonoFlat_Label();
            this.scoreSlider = new MonoFlat.MonoFlat_TrackBar();
            this.dieFacesLbl = new MonoFlat.MonoFlat_Label();
            this.dieFacesSlider = new MonoFlat.MonoFlat_TrackBar();
            this.playersContainerLbl = new MonoFlat.MonoFlat_HeaderLabel();
            this.addNewPlayerBtn = new MonoFlat.MonoFlat_Button();
            this.playersContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.newPlayerNameTxt = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.gameSetupContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameSetupContainer
            // 
            this.gameSetupContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.gameSetupContainer.Controls.Add(this.startGameBtn);
            this.gameSetupContainer.Controls.Add(this.scoreToWinLbl);
            this.gameSetupContainer.Controls.Add(this.scoreSlider);
            this.gameSetupContainer.Controls.Add(this.dieFacesLbl);
            this.gameSetupContainer.Controls.Add(this.dieFacesSlider);
            this.gameSetupContainer.Controls.Add(this.playersContainerLbl);
            this.gameSetupContainer.Controls.Add(this.addNewPlayerBtn);
            this.gameSetupContainer.Controls.Add(this.playersContainer);
            this.gameSetupContainer.Controls.Add(this.newPlayerNameTxt);
            this.gameSetupContainer.Controls.Add(this.monoFlat_ControlBox1);
            this.gameSetupContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSetupContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gameSetupContainer.Location = new System.Drawing.Point(0, 0);
            this.gameSetupContainer.Name = "gameSetupContainer";
            this.gameSetupContainer.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.gameSetupContainer.RoundCorners = false;
            this.gameSetupContainer.Sizable = true;
            this.gameSetupContainer.Size = new System.Drawing.Size(1920, 1080);
            this.gameSetupContainer.SmartBounds = true;
            this.gameSetupContainer.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gameSetupContainer.TabIndex = 0;
            this.gameSetupContainer.Text = "Game Setup";
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.startGameBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startGameBtn.Image = null;
            this.startGameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startGameBtn.Location = new System.Drawing.Point(1751, 228);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(146, 41);
            this.startGameBtn.TabIndex = 9;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // scoreToWinLbl
            // 
            this.scoreToWinLbl.AutoSize = true;
            this.scoreToWinLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreToWinLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scoreToWinLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.scoreToWinLbl.Location = new System.Drawing.Point(358, 141);
            this.scoreToWinLbl.Name = "scoreToWinLbl";
            this.scoreToWinLbl.Size = new System.Drawing.Size(171, 15);
            this.scoreToWinLbl.TabIndex = 8;
            this.scoreToWinLbl.Text = "A player needs 50 points to win";
            // 
            // scoreSlider
            // 
            this.scoreSlider.JumpToMouse = true;
            this.scoreSlider.Location = new System.Drawing.Point(268, 159);
            this.scoreSlider.Maximum = 200;
            this.scoreSlider.Minimum = 0;
            this.scoreSlider.MinimumSize = new System.Drawing.Size(47, 22);
            this.scoreSlider.Name = "scoreSlider";
            this.scoreSlider.Size = new System.Drawing.Size(346, 22);
            this.scoreSlider.TabIndex = 7;
            this.scoreSlider.Value = 50;
            this.scoreSlider.ValueDivison = MonoFlat.MonoFlat_TrackBar.ValueDivisor.By1;
            this.scoreSlider.ValueToSet = 50F;
            this.scoreSlider.ValueChanged += new MonoFlat.MonoFlat_TrackBar.ValueChangedEventHandler(this.scoreSlider_ValueChanged);
            // 
            // dieFacesLbl
            // 
            this.dieFacesLbl.AutoSize = true;
            this.dieFacesLbl.BackColor = System.Drawing.Color.Transparent;
            this.dieFacesLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dieFacesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.dieFacesLbl.Location = new System.Drawing.Point(1340, 141);
            this.dieFacesLbl.Name = "dieFacesLbl";
            this.dieFacesLbl.Size = new System.Drawing.Size(111, 15);
            this.dieFacesLbl.TabIndex = 6;
            this.dieFacesLbl.Text = "Each die has 6 faces";
            // 
            // dieFacesSlider
            // 
            this.dieFacesSlider.JumpToMouse = true;
            this.dieFacesSlider.Location = new System.Drawing.Point(1224, 159);
            this.dieFacesSlider.Maximum = 20;
            this.dieFacesSlider.Minimum = 0;
            this.dieFacesSlider.MinimumSize = new System.Drawing.Size(47, 22);
            this.dieFacesSlider.Name = "dieFacesSlider";
            this.dieFacesSlider.Size = new System.Drawing.Size(346, 22);
            this.dieFacesSlider.TabIndex = 5;
            this.dieFacesSlider.Value = 6;
            this.dieFacesSlider.ValueDivison = MonoFlat.MonoFlat_TrackBar.ValueDivisor.By1;
            this.dieFacesSlider.ValueToSet = 6F;
            this.dieFacesSlider.ValueChanged += new MonoFlat.MonoFlat_TrackBar.ValueChangedEventHandler(this.dieFacesSlider_ValueChanged);
            // 
            // playersContainerLbl
            // 
            this.playersContainerLbl.AutoSize = true;
            this.playersContainerLbl.BackColor = System.Drawing.Color.Transparent;
            this.playersContainerLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.playersContainerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playersContainerLbl.Location = new System.Drawing.Point(13, 249);
            this.playersContainerLbl.Name = "playersContainerLbl";
            this.playersContainerLbl.Size = new System.Drawing.Size(63, 20);
            this.playersContainerLbl.TabIndex = 4;
            this.playersContainerLbl.Text = "Players:";
            // 
            // addNewPlayerBtn
            // 
            this.addNewPlayerBtn.BackColor = System.Drawing.Color.Transparent;
            this.addNewPlayerBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addNewPlayerBtn.Image = null;
            this.addNewPlayerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewPlayerBtn.Location = new System.Drawing.Point(898, 159);
            this.addNewPlayerBtn.Name = "addNewPlayerBtn";
            this.addNewPlayerBtn.Size = new System.Drawing.Size(121, 41);
            this.addNewPlayerBtn.TabIndex = 3;
            this.addNewPlayerBtn.Text = "Add Player";
            this.addNewPlayerBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.addNewPlayerBtn.Click += new System.EventHandler(this.addNewPlayerBtn_Click);
            // 
            // playersContainer
            // 
            this.playersContainer.Location = new System.Drawing.Point(13, 284);
            this.playersContainer.Name = "playersContainer";
            this.playersContainer.Size = new System.Drawing.Size(1895, 730);
            this.playersContainer.TabIndex = 2;
            // 
            // newPlayerNameTxt
            // 
            this.newPlayerNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.newPlayerNameTxt.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.newPlayerNameTxt.Image = null;
            this.newPlayerNameTxt.Location = new System.Drawing.Point(865, 100);
            this.newPlayerNameTxt.MaxLength = 32767;
            this.newPlayerNameTxt.Multiline = false;
            this.newPlayerNameTxt.Name = "newPlayerNameTxt";
            this.newPlayerNameTxt.ReadOnly = false;
            this.newPlayerNameTxt.Size = new System.Drawing.Size(190, 52);
            this.newPlayerNameTxt.TabIndex = 1;
            this.newPlayerNameTxt.Text = "Player Name";
            this.newPlayerNameTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPlayerNameTxt.UseSystemPasswordChar = false;
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(1808, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 0;
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gameSetupContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Setup";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gameSetupContainer.ResumeLayout(false);
            this.gameSetupContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer gameSetupContainer;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_HeaderLabel playersContainerLbl;
        private MonoFlat.MonoFlat_Button addNewPlayerBtn;
        private System.Windows.Forms.FlowLayoutPanel playersContainer;
        private MonoFlat.MonoFlat_TextBox newPlayerNameTxt;
        private MonoFlat.MonoFlat_TrackBar dieFacesSlider;
        private MonoFlat.MonoFlat_Label dieFacesLbl;
        private MonoFlat.MonoFlat_Label scoreToWinLbl;
        private MonoFlat.MonoFlat_TrackBar scoreSlider;
        private MonoFlat.MonoFlat_Button startGameBtn;
    }
}