namespace Fly_Bird
{
    public partial class Form1 : Form
    {
        int pipespeed = 10, gravity = 15, score = 0, oldscore = 0;
        bool gameover = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            lbgameover.Visible = false;
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipe.Left -= pipespeed;
            pipe1.Left -= pipespeed;
            pipedown1.Left -= pipespeed;
            if (pipe.Left < -90)
            {
                pipe.Left = 800;
                score++;
            }
            if (pipe1.Left < -90)
            {
                pipe1.Left = 2220;
                score++;
            }

            if (pipedown1.Left < -90)
            {
                pipedown1.Left = 1500;
                score++;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "pipedown" || (string)x.Tag == "ground" || (string)x.Tag == "pipe")
                {
                    if (bird.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameover = true;
                        gametimer.Stop();
                        lbgameover.Visible=true;
                    }
                }
            }
            lbscore.Text = "Score :" + score;
            oldscore = score;
            if (score - oldscore > 10)
            {
                pipespeed += 1;
            }
            if (bird.Top < -100)
            {
                gravity = 15;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gameover == false)
            {
                gravity = -15;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
    }
}