using System.Media;

namespace dinosaur_Runner
{
    public partial class Form1 : Form
    {

        bool jumping = false;
        int jumspeed, force = 12, score = 0, obstacal = 10, position;
        Random random = new Random();
        bool gameover = false;
        string option = "→ Press key Enter to Restart game";
        string gameov = "Game Over >_<";
        public Form1()
        {
            InitializeComponent();
            Restartgame();
            lbgameover.Visible = false;
            lbreset.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
                soundJump();
            }
            if (e.KeyCode == Keys.Up && jumping == false)
            {
                jumping = true;
                soundJump();
            }
        }

        private void soundJump()
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"C:\sound\cartoon-jump-6462.wav");
            soundPlayer.Play();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && gameover == true)
            {
                Restartgame();
            }
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            score++;

            dinoaur.Top += jumspeed;
            lbscore.Text = "Score :" + score;
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumspeed = -10;
                force -= 1;
                
            }
            else
            {
                jumspeed = 12;
            }
            if (dinoaur.Top > 408 && jumping == false)
            {
                dinoaur.Top = 408;
                jumspeed = 0;
                force = 12;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ocstsal")
                {
                    x.Left -= obstacal;
                    if (x.Left < -10)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200, 800) + (x.Width * 10);
                    }
                    if (dinoaur.Bounds.IntersectsWith(x.Bounds))
                    {
                        gametimer.Stop();
                        gameover = true;
                        dinoaur.Image = Properties.Resources.dead;
                        lbreset.Visible = true;
                        lbreset.Text = option;
                        lbgameover.Visible = true;
                        lbgameover.Text = gameov;
                    }
                }
            }
        }
        private void Restartgame()
        {
            force = 12;
            jumspeed = 0;
            jumping = false;
            score = 0; obstacal = 10;
            lbscore.Text = "Score :" + score;
            dinoaur.Image = Properties.Resources.running;
            gameover = false;
            dinoaur.Top = 408;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ocstsal")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }
            gametimer.Start();
            lbgameover.Visible = false;
            lbreset.Visible = false;
        }
    }
}