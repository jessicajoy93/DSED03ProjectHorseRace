using System.Windows.Forms;

namespace DSED03ProjectHorseRace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panelBets = new System.Windows.Forms.Panel();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJoshua = new System.Windows.Forms.Label();
            this.lblJoe = new System.Windows.Forms.Label();
            this.lblSam = new System.Windows.Forms.Label();
            this.panelBetting = new System.Windows.Forms.Panel();
            this.btnNewRace = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblBettor = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.nudCash = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTortoiseNumber = new System.Windows.Forms.NumericUpDown();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBets.SuspendLayout();
            this.panelBetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTortoiseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pb4);
            this.splitContainer1.Panel1.Controls.Add(this.pb1);
            this.splitContainer1.Panel1.Controls.Add(this.pb3);
            this.splitContainer1.Panel1.Controls.Add(this.pb2);
            this.splitContainer1.Panel1.Controls.Add(this.pbRaceTrack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1151, 738);
            this.splitContainer1.SplitterDistance = 526;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelBetting);
            this.splitContainer2.Size = new System.Drawing.Size(1151, 208);
            this.splitContainer2.SplitterDistance = 138;
            this.splitContainer2.TabIndex = 15;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panelBets);
            this.splitContainer3.Size = new System.Drawing.Size(1151, 138);
            this.splitContainer3.SplitterDistance = 383;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMinimumBet);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.lblMaxBet);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 138);
            this.panel2.TabIndex = 16;
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Location = new System.Drawing.Point(16, 25);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(35, 13);
            this.lblMinimumBet.TabIndex = 0;
            this.lblMinimumBet.Text = "Bettor";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.Location = new System.Drawing.Point(182, 37);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(35, 13);
            this.lblMaxBet.TabIndex = 14;
            this.lblMaxBet.Text = "label3";
            this.lblMaxBet.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 99);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
            // 
            // panelBets
            // 
            this.panelBets.Controls.Add(this.lblWinner);
            this.panelBets.Controls.Add(this.label2);
            this.panelBets.Controls.Add(this.lblJoshua);
            this.panelBets.Controls.Add(this.lblJoe);
            this.panelBets.Controls.Add(this.lblSam);
            this.panelBets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBets.Location = new System.Drawing.Point(0, 0);
            this.panelBets.Name = "panelBets";
            this.panelBets.Size = new System.Drawing.Size(764, 138);
            this.panelBets.TabIndex = 19;
            this.panelBets.Visible = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(208, 25);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(35, 13);
            this.lblWinner.TabIndex = 19;
            this.lblWinner.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bets";
            // 
            // lblJoshua
            // 
            this.lblJoshua.Location = new System.Drawing.Point(13, 94);
            this.lblJoshua.Name = "lblJoshua";
            this.lblJoshua.Size = new System.Drawing.Size(388, 17);
            this.lblJoshua.TabIndex = 18;
            this.lblJoshua.Text = "label3";
            // 
            // lblJoe
            // 
            this.lblJoe.Location = new System.Drawing.Point(13, 48);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(388, 17);
            this.lblJoe.TabIndex = 16;
            this.lblJoe.Text = "label3";
            // 
            // lblSam
            // 
            this.lblSam.Location = new System.Drawing.Point(13, 71);
            this.lblSam.Name = "lblSam";
            this.lblSam.Size = new System.Drawing.Size(388, 17);
            this.lblSam.TabIndex = 17;
            this.lblSam.Text = "label3";
            // 
            // panelBetting
            // 
            this.panelBetting.Controls.Add(this.btnNewRace);
            this.panelBetting.Controls.Add(this.btnRace);
            this.panelBetting.Controls.Add(this.lblBettor);
            this.panelBetting.Controls.Add(this.btnBet);
            this.panelBetting.Controls.Add(this.nudCash);
            this.panelBetting.Controls.Add(this.label1);
            this.panelBetting.Controls.Add(this.nudTortoiseNumber);
            this.panelBetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBetting.Location = new System.Drawing.Point(0, 0);
            this.panelBetting.Name = "panelBetting";
            this.panelBetting.Size = new System.Drawing.Size(1151, 66);
            this.panelBetting.TabIndex = 15;
            this.panelBetting.Visible = false;
            // 
            // btnNewRace
            // 
            this.btnNewRace.Location = new System.Drawing.Point(522, 8);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(94, 43);
            this.btnNewRace.TabIndex = 10;
            this.btnNewRace.Text = "New Race";
            this.btnNewRace.UseVisualStyleBackColor = true;
            this.btnNewRace.Visible = false;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(422, 8);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(94, 43);
            this.btnRace.TabIndex = 9;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Visible = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(111, 13);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(35, 13);
            this.lblBettor.TabIndex = 4;
            this.lblBettor.Text = "label1";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(278, 8);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(138, 44);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "Bet for ...";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // nudCash
            // 
            this.nudCash.Location = new System.Drawing.Point(152, 6);
            this.nudCash.Name = "nudCash";
            this.nudCash.Size = new System.Drawing.Size(120, 20);
            this.nudCash.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "bucks on tortoise number";
            // 
            // nudTortoiseNumber
            // 
            this.nudTortoiseNumber.Location = new System.Drawing.Point(152, 32);
            this.nudTortoiseNumber.Name = "nudTortoiseNumber";
            this.nudTortoiseNumber.Size = new System.Drawing.Size(120, 20);
            this.nudTortoiseNumber.TabIndex = 8;
            this.nudTortoiseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.InitialImage = null;
            this.pb4.Location = new System.Drawing.Point(76, 395);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(94, 127);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 2;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.InitialImage = null;
            this.pb1.Location = new System.Drawing.Point(76, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(94, 127);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.InitialImage = null;
            this.pb3.Location = new System.Drawing.Point(76, 264);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(94, 127);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            // 
            // pb2
            // 
            this.pb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.InitialImage = null;
            this.pb2.Location = new System.Drawing.Point(76, 135);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(94, 127);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackgroundImage = global::DSED03ProjectHorseRace.Resource1.racetrack2;
            this.pbRaceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRaceTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRaceTrack.Location = new System.Drawing.Point(0, 0);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(1151, 526);
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 738);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBets.ResumeLayout(false);
            this.panelBets.PerformLayout();
            this.panelBetting.ResumeLayout(false);
            this.panelBetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTortoiseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRace;
        private NumericUpDown nudTortoiseNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCash;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblMinimumBet;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.Panel panelBetting;
        private System.Windows.Forms.Label lblJoshua;
        private System.Windows.Forms.Label lblSam;
        private System.Windows.Forms.Label lblJoe;
        private System.Windows.Forms.Panel panelBets;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Panel panel2;
        private Button btnNewRace;
        private Label lblWinner;
    }
}

