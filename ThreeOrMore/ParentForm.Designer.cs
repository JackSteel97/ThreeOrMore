namespace ThreeOrMore {
    partial class ParentForm {
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
            this.ParentFormContainer = new MonoFlat.MonoFlat_ThemeContainer();
            this.titleLbl = new MonoFlat.MonoFlat_HeaderLabel();
            this.newGameBtn = new MonoFlat.MonoFlat_Button();
            this.controlBox = new MonoFlat.MonoFlat_ControlBox();
            this.ParentFormContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentFormContainer
            // 
            this.ParentFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ParentFormContainer.Controls.Add(this.titleLbl);
            this.ParentFormContainer.Controls.Add(this.newGameBtn);
            this.ParentFormContainer.Controls.Add(this.controlBox);
            this.ParentFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentFormContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ParentFormContainer.Location = new System.Drawing.Point(0, 0);
            this.ParentFormContainer.Name = "ParentFormContainer";
            this.ParentFormContainer.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.ParentFormContainer.RoundCorners = false;
            this.ParentFormContainer.Sizable = true;
            this.ParentFormContainer.Size = new System.Drawing.Size(1920, 1080);
            this.ParentFormContainer.SmartBounds = true;
            this.ParentFormContainer.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ParentFormContainer.TabIndex = 0;
            this.ParentFormContainer.Text = "Main Menu";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titleLbl.Location = new System.Drawing.Point(551, 125);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(817, 128);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "THREE OR MORE";
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.newGameBtn.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Image = null;
            this.newGameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newGameBtn.Location = new System.Drawing.Point(812, 312);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(296, 83);
            this.newGameBtn.TabIndex = 2;
            this.newGameBtn.Text = "NEW GAME";
            this.newGameBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.EnableHoverHighlight = true;
            this.controlBox.EnableMaximizeButton = false;
            this.controlBox.EnableMinimizeButton = true;
            this.controlBox.Location = new System.Drawing.Point(1808, 15);
            this.controlBox.Margin = new System.Windows.Forms.Padding(0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(100, 25);
            this.controlBox.TabIndex = 0;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.ParentFormContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ParentFormContainer.ResumeLayout(false);
            this.ParentFormContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer ParentFormContainer;
        private MonoFlat.MonoFlat_ControlBox controlBox;
        private MonoFlat.MonoFlat_Button newGameBtn;
        private MonoFlat.MonoFlat_HeaderLabel titleLbl;
    }
}

