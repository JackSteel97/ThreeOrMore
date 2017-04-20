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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.statsContainer = new MonoFlat.MonoFlat_ThemeContainer();
            this.statsLbl = new MonoFlat.MonoFlat_Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.avgLastTurnLbl = new MonoFlat.MonoFlat_Label();
            this.totalLastTurnLbl = new MonoFlat.MonoFlat_Label();
            this.avgTotalLbl = new MonoFlat.MonoFlat_Label();
            this.historylbl = new MonoFlat.MonoFlat_Label();
            this.historyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.hintLbl = new MonoFlat.MonoFlat_Label();
            this.monoFlat_ControlBox2 = new MonoFlat.MonoFlat_ControlBox();
            this.die1 = new System.Windows.Forms.PictureBox();
            this.die2 = new System.Windows.Forms.PictureBox();
            this.die5 = new System.Windows.Forms.PictureBox();
            this.die4 = new System.Windows.Forms.PictureBox();
            this.die3 = new System.Windows.Forms.PictureBox();
            this.turnLbl = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.rollAllBtn = new MonoFlat.MonoFlat_Button();
            this.statsContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die3)).BeginInit();
            this.SuspendLayout();
            // 
            // statsContainer
            // 
            this.statsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.statsContainer.Controls.Add(this.rollAllBtn);
            this.statsContainer.Controls.Add(this.statsLbl);
            this.statsContainer.Controls.Add(this.flowLayoutPanel1);
            this.statsContainer.Controls.Add(this.historylbl);
            this.statsContainer.Controls.Add(this.historyContainer);
            this.statsContainer.Controls.Add(this.hintLbl);
            this.statsContainer.Controls.Add(this.monoFlat_ControlBox2);
            this.statsContainer.Controls.Add(this.die1);
            this.statsContainer.Controls.Add(this.die2);
            this.statsContainer.Controls.Add(this.die5);
            this.statsContainer.Controls.Add(this.die4);
            this.statsContainer.Controls.Add(this.die3);
            this.statsContainer.Controls.Add(this.turnLbl);
            this.statsContainer.Controls.Add(this.monoFlat_ControlBox1);
            this.statsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statsContainer.Location = new System.Drawing.Point(0, 0);
            this.statsContainer.Name = "statsContainer";
            this.statsContainer.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.statsContainer.RoundCorners = true;
            this.statsContainer.Sizable = true;
            this.statsContainer.Size = new System.Drawing.Size(1904, 1041);
            this.statsContainer.SmartBounds = true;
            this.statsContainer.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.statsContainer.TabIndex = 0;
            this.statsContainer.Text = "Three or More";
            // 
            // statsLbl
            // 
            this.statsLbl.AutoSize = true;
            this.statsLbl.BackColor = System.Drawing.Color.Transparent;
            this.statsLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.statsLbl.Location = new System.Drawing.Point(17, 255);
            this.statsLbl.Name = "statsLbl";
            this.statsLbl.Size = new System.Drawing.Size(127, 40);
            this.statsLbl.TabIndex = 12;
            this.statsLbl.Text = "Statistics";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.avgLastTurnLbl);
            this.flowLayoutPanel1.Controls.Add(this.totalLastTurnLbl);
            this.flowLayoutPanel1.Controls.Add(this.avgTotalLbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 538);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // avgLastTurnLbl
            // 
            this.avgLastTurnLbl.AutoSize = true;
            this.avgLastTurnLbl.BackColor = System.Drawing.Color.Transparent;
            this.avgLastTurnLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLastTurnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.avgLastTurnLbl.Location = new System.Drawing.Point(30, 30);
            this.avgLastTurnLbl.Margin = new System.Windows.Forms.Padding(30);
            this.avgLastTurnLbl.Name = "avgLastTurnLbl";
            this.avgLastTurnLbl.Size = new System.Drawing.Size(288, 32);
            this.avgLastTurnLbl.TabIndex = 0;
            this.avgLastTurnLbl.Text = "Average of dice last turn: ";
            // 
            // totalLastTurnLbl
            // 
            this.totalLastTurnLbl.AutoSize = true;
            this.totalLastTurnLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLastTurnLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLastTurnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.totalLastTurnLbl.Location = new System.Drawing.Point(30, 122);
            this.totalLastTurnLbl.Margin = new System.Windows.Forms.Padding(30);
            this.totalLastTurnLbl.Name = "totalLastTurnLbl";
            this.totalLastTurnLbl.Size = new System.Drawing.Size(252, 32);
            this.totalLastTurnLbl.TabIndex = 1;
            this.totalLastTurnLbl.Text = "Total of dice last turn: ";
            // 
            // avgTotalLbl
            // 
            this.avgTotalLbl.AutoSize = true;
            this.avgTotalLbl.BackColor = System.Drawing.Color.Transparent;
            this.avgTotalLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.avgTotalLbl.Location = new System.Drawing.Point(30, 214);
            this.avgTotalLbl.Margin = new System.Windows.Forms.Padding(30);
            this.avgTotalLbl.Name = "avgTotalLbl";
            this.avgTotalLbl.Size = new System.Drawing.Size(172, 32);
            this.avgTotalLbl.TabIndex = 2;
            this.avgTotalLbl.Text = "Average Total: ";
            // 
            // historylbl
            // 
            this.historylbl.AutoSize = true;
            this.historylbl.BackColor = System.Drawing.Color.Transparent;
            this.historylbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.historylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.historylbl.Location = new System.Drawing.Point(1727, 280);
            this.historylbl.Name = "historylbl";
            this.historylbl.Size = new System.Drawing.Size(45, 15);
            this.historylbl.TabIndex = 10;
            this.historylbl.Text = "History";
            // 
            // historyContainer
            // 
            this.historyContainer.AutoScroll = true;
            this.historyContainer.AutoScrollMargin = new System.Drawing.Size(50, 0);
            this.historyContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.historyContainer.Location = new System.Drawing.Point(1730, 300);
            this.historyContainer.Name = "historyContainer";
            this.historyContainer.Size = new System.Drawing.Size(161, 729);
            this.historyContainer.TabIndex = 9;
            // 
            // hintLbl
            // 
            this.hintLbl.BackColor = System.Drawing.Color.Transparent;
            this.hintLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hintLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.hintLbl.Location = new System.Drawing.Point(0, 245);
            this.hintLbl.Name = "hintLbl";
            this.hintLbl.Size = new System.Drawing.Size(1920, 50);
            this.hintLbl.TabIndex = 8;
            this.hintLbl.Text = "Click a die to roll it";
            this.hintLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monoFlat_ControlBox2
            // 
            this.monoFlat_ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox2.EnableHoverHighlight = false;
            this.monoFlat_ControlBox2.EnableMaximizeButton = true;
            this.monoFlat_ControlBox2.EnableMinimizeButton = true;
            this.monoFlat_ControlBox2.Location = new System.Drawing.Point(1792, 15);
            this.monoFlat_ControlBox2.Name = "monoFlat_ControlBox2";
            this.monoFlat_ControlBox2.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox2.TabIndex = 7;
            this.monoFlat_ControlBox2.Text = "monoFlat_ControlBox2";
            // 
            // die1
            // 
            this.die1.BackColor = System.Drawing.Color.DimGray;
            this.die1.Image = ((System.Drawing.Image)(resources.GetObject("die1.Image")));
            this.die1.Location = new System.Drawing.Point(610, 300);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(100, 100);
            this.die1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die1.TabIndex = 6;
            this.die1.TabStop = false;
            // 
            // die2
            // 
            this.die2.BackColor = System.Drawing.Color.DimGray;
            this.die2.Image = ((System.Drawing.Image)(resources.GetObject("die2.Image")));
            this.die2.Location = new System.Drawing.Point(760, 300);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(100, 100);
            this.die2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die2.TabIndex = 5;
            this.die2.TabStop = false;
            // 
            // die5
            // 
            this.die5.BackColor = System.Drawing.Color.DimGray;
            this.die5.Image = ((System.Drawing.Image)(resources.GetObject("die5.Image")));
            this.die5.Location = new System.Drawing.Point(1210, 300);
            this.die5.Name = "die5";
            this.die5.Size = new System.Drawing.Size(100, 100);
            this.die5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die5.TabIndex = 4;
            this.die5.TabStop = false;
            // 
            // die4
            // 
            this.die4.BackColor = System.Drawing.Color.DimGray;
            this.die4.Image = ((System.Drawing.Image)(resources.GetObject("die4.Image")));
            this.die4.Location = new System.Drawing.Point(1060, 300);
            this.die4.Name = "die4";
            this.die4.Size = new System.Drawing.Size(100, 100);
            this.die4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die4.TabIndex = 3;
            this.die4.TabStop = false;
            // 
            // die3
            // 
            this.die3.BackColor = System.Drawing.Color.DimGray;
            this.die3.Image = ((System.Drawing.Image)(resources.GetObject("die3.Image")));
            this.die3.Location = new System.Drawing.Point(910, 300);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(100, 100);
            this.die3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die3.TabIndex = 2;
            this.die3.TabStop = false;
            // 
            // turnLbl
            // 
            this.turnLbl.AutoSize = true;
            this.turnLbl.BackColor = System.Drawing.Color.Transparent;
            this.turnLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.turnLbl.Location = new System.Drawing.Point(13, 98);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(344, 65);
            this.turnLbl.TabIndex = 1;
            this.turnLbl.Text = "Player1\'s Turn";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(1792, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(0, 0);
            this.monoFlat_ControlBox1.TabIndex = 0;
            // 
            // rollAllBtn
            // 
            this.rollAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.rollAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rollAllBtn.Image = null;
            this.rollAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rollAllBtn.Location = new System.Drawing.Point(871, 445);
            this.rollAllBtn.Name = "rollAllBtn";
            this.rollAllBtn.Size = new System.Drawing.Size(179, 63);
            this.rollAllBtn.TabIndex = 13;
            this.rollAllBtn.Text = "Roll All Dice Once (Double Points)";
            this.rollAllBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.rollAllBtn.Click += new System.EventHandler(this.rollAllBtn_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.statsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Three or More";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.statsContainer.ResumeLayout(false);
            this.statsContainer.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer statsContainer;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private System.Windows.Forms.PictureBox die1;
        private System.Windows.Forms.PictureBox die2;
        private System.Windows.Forms.PictureBox die5;
        private System.Windows.Forms.PictureBox die4;
        private System.Windows.Forms.PictureBox die3;
        private MonoFlat.MonoFlat_HeaderLabel turnLbl;
        private MonoFlat.MonoFlat_Label hintLbl;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox2;
        private System.Windows.Forms.FlowLayoutPanel historyContainer;
        private MonoFlat.MonoFlat_Label historylbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MonoFlat.MonoFlat_Label avgLastTurnLbl;
        private MonoFlat.MonoFlat_Label totalLastTurnLbl;
        private MonoFlat.MonoFlat_Label avgTotalLbl;
        private MonoFlat.MonoFlat_Label statsLbl;
        private MonoFlat.MonoFlat_Button rollAllBtn;
    }
}