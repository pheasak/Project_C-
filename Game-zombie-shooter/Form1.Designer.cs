namespace Game_zombie_shooter
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
            lbkill = new Label();
            lbammon = new Label();
            lbhealth = new Label();
            progb1 = new ProgressBar();
            player = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lbdie = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbkill
            // 
            lbkill.AutoSize = true;
            lbkill.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbkill.ForeColor = Color.White;
            lbkill.Location = new Point(189, 12);
            lbkill.Name = "lbkill";
            lbkill.Size = new Size(48, 28);
            lbkill.TabIndex = 0;
            lbkill.Text = "Kill:";
            // 
            // lbammon
            // 
            lbammon.AutoSize = true;
            lbammon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbammon.ForeColor = Color.White;
            lbammon.Location = new Point(3, 8);
            lbammon.Name = "lbammon";
            lbammon.Size = new Size(91, 28);
            lbammon.TabIndex = 0;
            lbammon.Text = "Ammon:";
            // 
            // lbhealth
            // 
            lbhealth.AutoSize = true;
            lbhealth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbhealth.ForeColor = Color.White;
            lbhealth.Location = new Point(945, 12);
            lbhealth.Name = "lbhealth";
            lbhealth.Size = new Size(75, 28);
            lbhealth.TabIndex = 0;
            lbhealth.Text = "Health";
            // 
            // progb1
            // 
            progb1.Location = new Point(708, 12);
            progb1.Name = "progb1";
            progb1.Size = new Size(231, 24);
            progb1.TabIndex = 1;
            progb1.Value = 100;
            // 
            // player
            // 
            player.Image = Properties.Resources.up;
            player.Location = new Point(470, 496);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbammon);
            panel1.Controls.Add(lbkill);
            panel1.Controls.Add(progb1);
            panel1.Controls.Add(lbhealth);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 52);
            panel1.TabIndex = 3;
            // 
            // lbdie
            // 
            lbdie.AutoSize = true;
            lbdie.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbdie.ForeColor = Color.FromArgb(192, 0, 0);
            lbdie.Location = new Point(454, 237);
            lbdie.Name = "lbdie";
            lbdie.Size = new Size(0, 35);
            lbdie.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1032, 598);
            Controls.Add(lbdie);
            Controls.Add(panel1);
            Controls.Add(player);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zombie-Hunter";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbkill;
        private Label lbammon;
        private Label lbhealth;
        private ProgressBar progb1;
        private PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label lbdie;
    }
}