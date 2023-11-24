using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool rigth = false, left = false;
        int speedball = 3, check = 0;
        public Form1()
        {
            InitializeComponent();
        }
        int vdr = +1;
        private void vert_Tick(object sender, EventArgs e)
        {
            if (circle.Top < 0)
            {
                vdr = +1;
            }
            else if (circle.Top > (this.Height - circle.Height - bar.Height))
            {

                if (circle.Left < bar.Left || ((circle.Left + circle.Width) > (bar.Width*10)))
                {
                    vert.Enabled = hozer.Enabled = false;
                    lbpause.Text = "Game Over";
                    lbpause.ForeColor = Color.Red;
                }
                else
                {
                    speedball++;
                }


                vdr = -1;
            }
            circle.Top += (vdr * speedball);
        }
        int hdr = +1;

        private void hozer_Tick(object sender, EventArgs e)
        {
            if (circle.Left < 0)
            {
                hdr = +1;
            }
            else if (circle.Left > (this.Width - circle.Width))
            {
                hdr = -1;
            }

            circle.Left += (hdr * speedball);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rigth = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            else if (e.KeyCode == Keys.Space && check == 0)
            {
                vert.Enabled = hozer.Enabled = false;
                lbpause.Text = "Game Pause";
                check = 1;
            }
            else if (e.KeyCode == Keys.Space && check != 0)
            {
                check = 0;
                lbpause.Text = "";
                vert.Enabled = hozer.Enabled = true;
            }else if (e.KeyCode == Keys.Enter)
            {
                vert.Enabled=hozer.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                rigth = left = false;
                lbpause.Text = "";
            }
        }

        private void watch_Tick(object sender, EventArgs e)
        {
            if (rigth && bar.Left < (this.Width - bar.Width))
            {
                bar.Left = bar.Left + 10;
            }
            else if (left && bar.Left > 0)
            {
                bar.Left = bar.Left - 10;
            }
        }
    }
}