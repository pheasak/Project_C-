namespace Mole_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mole = new PictureBox();
            lbscore = new Label();
            lbtotal = new Label();
            lbmiss = new Label();
            button1 = new Button();
            button2 = new Button();
            timer = new System.Windows.Forms.Timer(components);
            lbgameover = new Label();
            timming = new Label();
            setting_time = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)mole).BeginInit();
            SuspendLayout();
            // 
            // mole
            // 
            mole.BackColor = Color.Transparent;
            mole.Image = (Image)resources.GetObject("mole.Image");
            mole.Location = new Point(379, 474);
            mole.Name = "mole";
            mole.Size = new Size(65, 51);
            mole.SizeMode = PictureBoxSizeMode.AutoSize;
            mole.TabIndex = 0;
            mole.TabStop = false;
            mole.Click += mole_Click;
            // 
            // lbscore
            // 
            lbscore.AutoSize = true;
            lbscore.BackColor = Color.Transparent;
            lbscore.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbscore.ForeColor = Color.White;
            lbscore.Location = new Point(12, 12);
            lbscore.Name = "lbscore";
            lbscore.Size = new Size(117, 29);
            lbscore.TabIndex = 1;
            lbscore.Text = "Score : 0";
            // 
            // lbtotal
            // 
            lbtotal.AutoSize = true;
            lbtotal.BackColor = Color.Transparent;
            lbtotal.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtotal.ForeColor = Color.White;
            lbtotal.Location = new Point(12, 50);
            lbtotal.Name = "lbtotal";
            lbtotal.Size = new Size(212, 29);
            lbtotal.TabIndex = 1;
            lbtotal.Text = "Total shoted : 0";
            // 
            // lbmiss
            // 
            lbmiss.AutoSize = true;
            lbmiss.BackColor = Color.Transparent;
            lbmiss.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmiss.ForeColor = Color.Red;
            lbmiss.Location = new Point(12, 90);
            lbmiss.Name = "lbmiss";
            lbmiss.Size = new Size(162, 29);
            lbmiss.TabIndex = 1;
            lbmiss.Text = "Miss Shot : 0";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(709, 64);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 2;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(709, 12);
            button2.Name = "button2";
            button2.Size = new Size(121, 35);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lbgameover
            // 
            lbgameover.AutoSize = true;
            lbgameover.BackColor = Color.Transparent;
            lbgameover.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbgameover.ForeColor = Color.Red;
            lbgameover.Location = new Point(312, 251);
            lbgameover.Name = "lbgameover";
            lbgameover.Size = new Size(0, 50);
            lbgameover.TabIndex = 1;
            // 
            // timming
            // 
            timming.AutoSize = true;
            timming.BackColor = Color.Transparent;
            timming.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            timming.ForeColor = SystemColors.ControlLightLight;
            timming.Location = new Point(395, 12);
            timming.Name = "timming";
            timming.Size = new Size(77, 39);
            timming.TabIndex = 3;
            timming.Text = "0:00";
            // 
            // setting_time
            // 
            setting_time.Enabled = true;
            setting_time.Interval = 1000;
            setting_time.Tick += setting_time_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(842, 598);
            Controls.Add(timming);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbgameover);
            Controls.Add(lbmiss);
            Controls.Add(lbtotal);
            Controls.Add(lbscore);
            Controls.Add(mole);
            Cursor = Cursors.NoMove2D;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mole_Shot_game";
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)mole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mole;
        private Label lbscore;
        private Label lbtotal;
        private Label lbmiss;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer;
        private Label lbgameover;
        private Label timming;
        private System.Windows.Forms.Timer setting_time;
    }
}