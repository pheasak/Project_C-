namespace WinFormsApp2
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
            cb1 = new ComboBox();
            lb1 = new Label();
            btn1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // cb1
            // 
            cb1.AutoCompleteCustomSource.AddRange(new string[] { "១", "២" });
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "1", "1+1" });
            cb1.Location = new Point(648, 0);
            cb1.Name = "cb1";
            cb1.Size = new Size(151, 28);
            cb1.TabIndex = 0;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(1, -1);
            lb1.Name = "lb1";
            lb1.Size = new Size(69, 20);
            lb1.TabIndex = 1;
            lb1.Text = "Standard";
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 126);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 91);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(242, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 197);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btn1);
            Controls.Add(lb1);
            Controls.Add(cb1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb1;
        private Label lb1;
        private Button btn1;
        private Panel panel1;
    }
}