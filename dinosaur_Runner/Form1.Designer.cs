namespace dinosaur_Runner
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
            pictureBox1 = new PictureBox();
            dinoaur = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lbscore = new Label();
            gametimer = new System.Windows.Forms.Timer(components);
            lbreset = new Label();
            lbgameover = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dinoaur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-1, 450);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(845, 26);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dinoaur
            // 
            dinoaur.BackColor = Color.Transparent;
            dinoaur.Image = Properties.Resources.running;
            dinoaur.Location = new Point(94, 407);
            dinoaur.Name = "dinoaur";
            dinoaur.Size = new Size(40, 43);
            dinoaur.SizeMode = PictureBoxSizeMode.AutoSize;
            dinoaur.TabIndex = 1;
            dinoaur.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.obstacle_1;
            pictureBox3.Location = new Point(398, 404);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "ocstsal";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.obstacle_2;
            pictureBox4.Location = new Point(648, 417);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "ocstsal";
            // 
            // lbscore
            // 
            lbscore.AutoSize = true;
            lbscore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbscore.Location = new Point(365, 0);
            lbscore.Name = "lbscore";
            lbscore.Size = new Size(104, 31);
            lbscore.TabIndex = 4;
            lbscore.Text = "Score : 0";
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gametimer_Tick;
            // 
            // lbreset
            // 
            lbreset.AutoSize = true;
            lbreset.Font = new Font("Bell MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbreset.Location = new Point(315, 135);
            lbreset.Name = "lbreset";
            lbreset.Size = new Size(0, 20);
            lbreset.TabIndex = 4;
            // 
            // lbgameover
            // 
            lbgameover.AutoSize = true;
            lbgameover.Font = new Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbgameover.Location = new Point(283, 52);
            lbgameover.Name = "lbgameover";
            lbgameover.Size = new Size(0, 51);
            lbgameover.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(842, 473);
            Controls.Add(lbgameover);
            Controls.Add(lbreset);
            Controls.Add(pictureBox1);
            Controls.Add(lbscore);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(dinoaur);
            Name = "Form1";
            Text = "Dinosaur Runner (●__●)";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dinoaur).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox dinoaur;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lbscore;
        private System.Windows.Forms.Timer gametimer;
        private Label lbreset;
        private Label lbgameover;
    }
}