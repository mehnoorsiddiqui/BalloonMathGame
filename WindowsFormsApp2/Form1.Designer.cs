namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bomb = new System.Windows.Forms.PictureBox();
            this.balloon12 = new System.Windows.Forms.PictureBox();
            this.balloon11 = new System.Windows.Forms.PictureBox();
            this.balloon10 = new System.Windows.Forms.PictureBox();
            this.balloon18 = new System.Windows.Forms.PictureBox();
            this.balloon17 = new System.Windows.Forms.PictureBox();
            this.balloon15 = new System.Windows.Forms.PictureBox();
            this.balloon16 = new System.Windows.Forms.PictureBox();
            this.balloon14 = new System.Windows.Forms.PictureBox();
            this.balloon13 = new System.Windows.Forms.PictureBox();
            this.balloon9 = new System.Windows.Forms.PictureBox();
            this.balloon8 = new System.Windows.Forms.PictureBox();
            this.balloon7 = new System.Windows.Forms.PictureBox();
            this.balloon5 = new System.Windows.Forms.PictureBox();
            this.balloon3 = new System.Windows.Forms.PictureBox();
            this.balloon4 = new System.Windows.Forms.PictureBox();
            this.balloon2 = new System.Windows.Forms.PictureBox();
            this.balloon6 = new System.Windows.Forms.PictureBox();
            this.balloon1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.TimeRemaining = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.Image = global::WindowsFormsApp2.Properties.Resources.icons8_bomb_96;
            this.bomb.Location = new System.Drawing.Point(899, 40);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(79, 92);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb.TabIndex = 11;
            this.bomb.TabStop = false;
            this.bomb.Tag = "bomb";
            this.bomb.Click += new System.EventHandler(this.bomb_Click);
            // 
            // balloon12
            // 
            this.balloon12.BackColor = System.Drawing.Color.Transparent;
            this.balloon12.Image = global::WindowsFormsApp2.Properties.Resources.bln12;
            this.balloon12.Location = new System.Drawing.Point(390, 26);
            this.balloon12.Name = "balloon12";
            this.balloon12.Size = new System.Drawing.Size(80, 96);
            this.balloon12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon12.TabIndex = 6;
            this.balloon12.TabStop = false;
            this.balloon12.Tag = "balloon";
            this.balloon12.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon11
            // 
            this.balloon11.BackColor = System.Drawing.Color.Transparent;
            this.balloon11.Image = global::WindowsFormsApp2.Properties.Resources.bln11;
            this.balloon11.Location = new System.Drawing.Point(155, 459);
            this.balloon11.Name = "balloon11";
            this.balloon11.Size = new System.Drawing.Size(80, 96);
            this.balloon11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon11.TabIndex = 6;
            this.balloon11.TabStop = false;
            this.balloon11.Tag = "balloon";
            this.balloon11.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon10
            // 
            this.balloon10.BackColor = System.Drawing.Color.Transparent;
            this.balloon10.Image = global::WindowsFormsApp2.Properties.Resources.bln10;
            this.balloon10.Location = new System.Drawing.Point(279, 26);
            this.balloon10.Name = "balloon10";
            this.balloon10.Size = new System.Drawing.Size(80, 96);
            this.balloon10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon10.TabIndex = 6;
            this.balloon10.TabStop = false;
            this.balloon10.Tag = "balloon";
            this.balloon10.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon18
            // 
            this.balloon18.BackColor = System.Drawing.Color.Transparent;
            this.balloon18.Image = global::WindowsFormsApp2.Properties.Resources.bln18;
            this.balloon18.Location = new System.Drawing.Point(527, 352);
            this.balloon18.Name = "balloon18";
            this.balloon18.Size = new System.Drawing.Size(80, 96);
            this.balloon18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon18.TabIndex = 6;
            this.balloon18.TabStop = false;
            this.balloon18.Tag = "balloon";
            this.balloon18.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon17
            // 
            this.balloon17.BackColor = System.Drawing.Color.Transparent;
            this.balloon17.Image = global::WindowsFormsApp2.Properties.Resources.bln17;
            this.balloon17.Location = new System.Drawing.Point(575, 199);
            this.balloon17.Name = "balloon17";
            this.balloon17.Size = new System.Drawing.Size(80, 96);
            this.balloon17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon17.TabIndex = 6;
            this.balloon17.TabStop = false;
            this.balloon17.Tag = "balloon";
            this.balloon17.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon15
            // 
            this.balloon15.BackColor = System.Drawing.Color.Transparent;
            this.balloon15.Image = global::WindowsFormsApp2.Properties.Resources.bln15;
            this.balloon15.Location = new System.Drawing.Point(672, 26);
            this.balloon15.Name = "balloon15";
            this.balloon15.Size = new System.Drawing.Size(80, 96);
            this.balloon15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon15.TabIndex = 6;
            this.balloon15.TabStop = false;
            this.balloon15.Tag = "balloon";
            this.balloon15.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon16
            // 
            this.balloon16.BackColor = System.Drawing.Color.Transparent;
            this.balloon16.Image = global::WindowsFormsApp2.Properties.Resources.bln16;
            this.balloon16.Location = new System.Drawing.Point(807, 36);
            this.balloon16.Name = "balloon16";
            this.balloon16.Size = new System.Drawing.Size(80, 96);
            this.balloon16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon16.TabIndex = 6;
            this.balloon16.TabStop = false;
            this.balloon16.Tag = "balloon";
            this.balloon16.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon14
            // 
            this.balloon14.BackColor = System.Drawing.Color.Transparent;
            this.balloon14.Image = global::WindowsFormsApp2.Properties.Resources.bln14;
            this.balloon14.Location = new System.Drawing.Point(175, 26);
            this.balloon14.Name = "balloon14";
            this.balloon14.Size = new System.Drawing.Size(80, 96);
            this.balloon14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon14.TabIndex = 6;
            this.balloon14.TabStop = false;
            this.balloon14.Tag = "balloon";
            this.balloon14.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon13
            // 
            this.balloon13.BackColor = System.Drawing.Color.Transparent;
            this.balloon13.Image = global::WindowsFormsApp2.Properties.Resources.bln13;
            this.balloon13.Location = new System.Drawing.Point(886, 315);
            this.balloon13.Name = "balloon13";
            this.balloon13.Size = new System.Drawing.Size(80, 96);
            this.balloon13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon13.TabIndex = 6;
            this.balloon13.TabStop = false;
            this.balloon13.Tag = "balloon";
            this.balloon13.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon9
            // 
            this.balloon9.BackColor = System.Drawing.Color.Transparent;
            this.balloon9.Image = global::WindowsFormsApp2.Properties.Resources.bln9;
            this.balloon9.Location = new System.Drawing.Point(754, 418);
            this.balloon9.Name = "balloon9";
            this.balloon9.Size = new System.Drawing.Size(104, 96);
            this.balloon9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon9.TabIndex = 6;
            this.balloon9.TabStop = false;
            this.balloon9.Tag = "balloon";
            this.balloon9.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon8
            // 
            this.balloon8.BackColor = System.Drawing.Color.Transparent;
            this.balloon8.Image = global::WindowsFormsApp2.Properties.Resources.bln8;
            this.balloon8.Location = new System.Drawing.Point(656, 331);
            this.balloon8.Name = "balloon8";
            this.balloon8.Size = new System.Drawing.Size(92, 96);
            this.balloon8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon8.TabIndex = 6;
            this.balloon8.TabStop = false;
            this.balloon8.Tag = "balloon";
            this.balloon8.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon7
            // 
            this.balloon7.BackColor = System.Drawing.Color.Transparent;
            this.balloon7.Image = global::WindowsFormsApp2.Properties.Resources.bln7;
            this.balloon7.Location = new System.Drawing.Point(137, 288);
            this.balloon7.Name = "balloon7";
            this.balloon7.Size = new System.Drawing.Size(80, 96);
            this.balloon7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon7.TabIndex = 6;
            this.balloon7.TabStop = false;
            this.balloon7.Tag = "balloon";
            this.balloon7.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon5
            // 
            this.balloon5.BackColor = System.Drawing.Color.Transparent;
            this.balloon5.Image = global::WindowsFormsApp2.Properties.Resources.bln51;
            this.balloon5.Location = new System.Drawing.Point(-18, 400);
            this.balloon5.Name = "balloon5";
            this.balloon5.Size = new System.Drawing.Size(80, 96);
            this.balloon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon5.TabIndex = 6;
            this.balloon5.TabStop = false;
            this.balloon5.Tag = "balloon";
            this.balloon5.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon3
            // 
            this.balloon3.BackColor = System.Drawing.Color.Transparent;
            this.balloon3.Image = global::WindowsFormsApp2.Properties.Resources.bln3;
            this.balloon3.Location = new System.Drawing.Point(511, 26);
            this.balloon3.Name = "balloon3";
            this.balloon3.Size = new System.Drawing.Size(96, 96);
            this.balloon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balloon3.TabIndex = 4;
            this.balloon3.TabStop = false;
            this.balloon3.Tag = "balloon";
            this.balloon3.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon4
            // 
            this.balloon4.BackColor = System.Drawing.Color.Transparent;
            this.balloon4.Image = global::WindowsFormsApp2.Properties.Resources.bln4;
            this.balloon4.Location = new System.Drawing.Point(401, 212);
            this.balloon4.Name = "balloon4";
            this.balloon4.Size = new System.Drawing.Size(79, 92);
            this.balloon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon4.TabIndex = 2;
            this.balloon4.TabStop = false;
            this.balloon4.Tag = "balloon";
            this.balloon4.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon2
            // 
            this.balloon2.BackColor = System.Drawing.Color.Transparent;
            this.balloon2.Image = global::WindowsFormsApp2.Properties.Resources.bln21;
            this.balloon2.Location = new System.Drawing.Point(316, 315);
            this.balloon2.Name = "balloon2";
            this.balloon2.Size = new System.Drawing.Size(96, 96);
            this.balloon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balloon2.TabIndex = 1;
            this.balloon2.TabStop = false;
            this.balloon2.Tag = "balloon";
            this.balloon2.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon6
            // 
            this.balloon6.BackColor = System.Drawing.Color.Transparent;
            this.balloon6.Image = global::WindowsFormsApp2.Properties.Resources.bln6;
            this.balloon6.Location = new System.Drawing.Point(-34, 186);
            this.balloon6.Name = "balloon6";
            this.balloon6.Size = new System.Drawing.Size(96, 96);
            this.balloon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balloon6.TabIndex = 0;
            this.balloon6.TabStop = false;
            this.balloon6.Tag = "balloon";
            this.balloon6.Click += new System.EventHandler(this.PopBalloon);
            // 
            // balloon1
            // 
            this.balloon1.BackColor = System.Drawing.Color.Transparent;
            this.balloon1.Image = global::WindowsFormsApp2.Properties.Resources.bln1;
            this.balloon1.Location = new System.Drawing.Point(28, 36);
            this.balloon1.Name = "balloon1";
            this.balloon1.Size = new System.Drawing.Size(84, 86);
            this.balloon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon1.TabIndex = 0;
            this.balloon1.TabStop = false;
            this.balloon1.Tag = "balloon";
            this.balloon1.Click += new System.EventHandler(this.PopBalloon);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(990, 48);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Score : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wrong : 0";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "0 + 0 = ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(945, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 45);
            this.label5.TabIndex = 14;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CountDown
            // 
            this.CountDown.Interval = 1000;
            this.CountDown.Tick += new System.EventHandler(this.Countdown);
            // 
            // TimeRemaining
            // 
            this.TimeRemaining.BackColor = System.Drawing.Color.Ivory;
            this.TimeRemaining.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemaining.ForeColor = System.Drawing.Color.Black;
            this.TimeRemaining.Location = new System.Drawing.Point(792, 9);
            this.TimeRemaining.Name = "TimeRemaining";
            this.TimeRemaining.Size = new System.Drawing.Size(123, 31);
            this.TimeRemaining.TabIndex = 15;
            this.TimeRemaining.Text = "0  Sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.back1001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 593);
            this.Controls.Add(this.TimeRemaining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.balloon12);
            this.Controls.Add(this.balloon11);
            this.Controls.Add(this.balloon10);
            this.Controls.Add(this.balloon18);
            this.Controls.Add(this.balloon17);
            this.Controls.Add(this.balloon15);
            this.Controls.Add(this.balloon16);
            this.Controls.Add(this.balloon14);
            this.Controls.Add(this.balloon13);
            this.Controls.Add(this.balloon9);
            this.Controls.Add(this.balloon8);
            this.Controls.Add(this.balloon7);
            this.Controls.Add(this.balloon5);
            this.Controls.Add(this.balloon3);
            this.Controls.Add(this.balloon4);
            this.Controls.Add(this.balloon2);
            this.Controls.Add(this.balloon6);
            this.Controls.Add(this.balloon1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "balloon";
            this.Text = " Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox balloon1;
        private System.Windows.Forms.PictureBox balloon2;
        private System.Windows.Forms.PictureBox balloon4;
        private System.Windows.Forms.PictureBox balloon3;
        private System.Windows.Forms.PictureBox balloon5;
        private System.Windows.Forms.PictureBox balloon6;
        private System.Windows.Forms.PictureBox balloon7;
        private System.Windows.Forms.PictureBox balloon8;
        private System.Windows.Forms.PictureBox balloon9;
        private System.Windows.Forms.PictureBox balloon10;
        private System.Windows.Forms.PictureBox balloon13;
        private System.Windows.Forms.PictureBox balloon11;
        private System.Windows.Forms.PictureBox balloon12;
        private System.Windows.Forms.PictureBox balloon16;
        private System.Windows.Forms.PictureBox balloon15;
        private System.Windows.Forms.PictureBox balloon17;
        private System.Windows.Forms.PictureBox balloon14;
        private System.Windows.Forms.PictureBox balloon18;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer CountDown;
        private System.Windows.Forms.Label TimeRemaining;
    }
}

