namespace WinFormsApp1
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
            circle = new PictureBox();
            vert = new System.Windows.Forms.Timer(components);
            hozer = new System.Windows.Forms.Timer(components);
            bar = new PictureBox();
            label1 = new Label();
            watch = new System.Windows.Forms.Timer(components);
            lbpause = new Label();
            ((System.ComponentModel.ISupportInitialize)circle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bar).BeginInit();
            SuspendLayout();
            // 
            // circle
            // 
            circle.Image = (Image)resources.GetObject("circle.Image");
            circle.Location = new Point(1, -3);
            circle.Name = "circle";
            circle.Size = new Size(90, 90);
            circle.SizeMode = PictureBoxSizeMode.Zoom;
            circle.TabIndex = 0;
            circle.TabStop = false;
            // 
            // vert
            // 
            vert.Enabled = true;
            vert.Interval = 1;
            vert.Tick += vert_Tick;
            // 
            // hozer
            // 
            hozer.Enabled = true;
            hozer.Interval = 1;
            hozer.Tick += hozer_Tick;
            // 
            // bar
            // 
            bar.Anchor = AnchorStyles.Bottom;
            bar.BackColor = Color.Lime;
            bar.Location = new Point(395, 632);
            bar.Name = "bar";
            bar.Size = new Size(210, 13);
            bar.TabIndex = 1;
            bar.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1134, -3);
            label1.Name = "label1";
            label1.Size = new Size(44, 50);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // watch
            // 
            watch.Enabled = true;
            watch.Interval = 1;
            watch.Tick += watch_Tick;
            // 
            // lbpause
            // 
            lbpause.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbpause.AutoSize = true;
            lbpause.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbpause.ForeColor = Color.Yellow;
            lbpause.Location = new Point(499, 298);
            lbpause.Name = "lbpause";
            lbpause.Size = new Size(0, 41);
            lbpause.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1179, 645);
            Controls.Add(lbpause);
            Controls.Add(label1);
            Controls.Add(bar);
            Controls.Add(circle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)circle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox circle;
        private System.Windows.Forms.Timer vert;
        private System.Windows.Forms.Timer hozer;
        private PictureBox bar;
        private Label label1;
        private System.Windows.Forms.Timer watch;
        private Label lbpause;
    }
}