namespace Mole_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int score = 0, total = 0, miss = 0, time = 0, min = 0;
        bool gameover = false;
        string game = "Gameover";
        public Form1()
        {
            InitializeComponent();
            lbgameover.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = random.Next(150, 740);
            y = random.Next(250, 540);
            mole.Location = new Point(x, y);
            if (miss >= 10)
            {
                timer.Stop();
                setting_time.Stop();
                gameover = true;
                lbgameover.Visible = true;
                lbgameover.Text = game;
            }
        }
        private void shot()
        {
            score++;
            total++;
            lbscore.Text = "Score :" + score;
            lbtotal.Text = "Total shoted :" + total;
            sound();
        }
        private void sound()
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"C:\sound\hit-someting-6037.wav");
            soundPlayer.Play();
        }
        private void restart()
        {
            score = 0;
            total = 0;
            miss = 0;
            lbscore.Text = "Score :" + score;
            lbtotal.Text = "Total shoted :" + total;
            lbmiss.Text = "miss shot :" + miss;
            gameover = false;
            timer.Start();
            lbgameover.Visible = false;
            min = 0;
            time = 0;
            setting_time.Start();

        }
        private void missshot()
        {
            sound();

            total++;
            miss++;
            lbtotal.Text = "Total shoted :" + total;
            lbmiss.Text = "miss shot :" + miss;
        }
        private void mole_Click(object sender, EventArgs e)
        {
            if (gameover == false)
            {
                shot();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameover == false)
            {
                missshot();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void setting_time_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 59)
            {
                min = min + 1;
                time = 0;
            }
            if (time > 9)
            {
                timming.Text = +min + ":" + time.ToString();
            }
            else
            {
                timming.Text = +min + ":0" + time.ToString();
            }

        }
    }
}