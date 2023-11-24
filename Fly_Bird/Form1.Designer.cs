namespace Fly_Bird
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
            ground = new PictureBox();
            bird = new PictureBox();
            pipe = new PictureBox();
            gametimer = new System.Windows.Forms.Timer(components);
            lbscore = new Label();
            pipedown1 = new PictureBox();
            pipe1 = new PictureBox();
            lbgameover = new Label();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe1).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(0, 568);
            ground.Name = "ground";
            ground.Size = new Size(806, 48);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            ground.Tag = "ground";
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.bird;
            bird.Location = new Point(56, 229);
            bird.Name = "bird";
            bird.Size = new Size(46, 44);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 1;
            bird.TabStop = false;
            // 
            // pipe
            // 
            pipe.BackColor = Color.Transparent;
            pipe.Image = Properties.Resources.pipe;
            pipe.Location = new Point(784, 104);
            pipe.Name = "pipe";
            pipe.Size = new Size(92, 608);
            pipe.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe.TabIndex = 3;
            pipe.TabStop = false;
            pipe.Tag = "pipe";
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 10;
            gametimer.Tick += gametimer_Tick;
            // 
            // lbscore
            // 
            lbscore.AutoSize = true;
            lbscore.BackColor = Color.Transparent;
            lbscore.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbscore.ForeColor = Color.White;
            lbscore.Location = new Point(-1, 0);
            lbscore.Name = "lbscore";
            lbscore.Size = new Size(130, 27);
            lbscore.TabIndex = 4;
            lbscore.Text = "Score : 0";
            // 
            // pipedown1
            // 
            pipedown1.BackColor = Color.Transparent;
            pipedown1.Image = Properties.Resources.pipedown;
            pipedown1.Location = new Point(408, 0);
            pipedown1.Name = "pipedown1";
            pipedown1.Size = new Size(92, 124);
            pipedown1.SizeMode = PictureBoxSizeMode.StretchImage;
            pipedown1.TabIndex = 2;
            pipedown1.TabStop = false;
            pipedown1.Tag = "pipedown";
            // 
            // pipe1
            // 
            pipe1.BackColor = Color.Transparent;
            pipe1.Image = Properties.Resources.pipe;
            pipe1.Location = new Point(271, 291);
            pipe1.Name = "pipe1";
            pipe1.Size = new Size(92, 390);
            pipe1.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe1.TabIndex = 3;
            pipe1.TabStop = false;
            pipe1.Tag = "pipe";
            // 
            // lbgameover
            // 
            lbgameover.AutoSize = true;
            lbgameover.BackColor = Color.Transparent;
            lbgameover.Font = new Font("Jokerman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbgameover.ForeColor = Color.Red;
            lbgameover.Location = new Point(310, 204);
            lbgameover.Name = "lbgameover";
            lbgameover.Size = new Size(190, 43);
            lbgameover.TabIndex = 5;
            lbgameover.Text = "Game Over";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(807, 617);
            Controls.Add(lbgameover);
            Controls.Add(ground);
            Controls.Add(pipe1);
            Controls.Add(pipe);
            Controls.Add(pipedown1);
            Controls.Add(bird);
            Controls.Add(lbscore);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ground;
        private PictureBox bird;
        private PictureBox pipe;
        private System.Windows.Forms.Timer gametimer;
        private Label lbscore;
        private PictureBox pipedown1;
        private PictureBox pipe1;
        private Label lbgameover;
    }
}