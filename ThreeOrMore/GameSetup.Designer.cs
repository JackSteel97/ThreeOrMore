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
    }
}