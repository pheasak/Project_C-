namespace Game_zombie_shooter
{
    public partial class Form1 : Form
    {
        bool goUp, goLeft, goDown, goRight, gameOver;
        string facing = "Up";
        int playerhealth = 100;
        int playerspeed = 15;
        int zombiespeed = 3;
        int ammon = 10, kill, seconds, oldsc = 0, zombiespawn = 3, lastkill = 0;
        Random random = new Random();
        List<PictureBox> piczombie = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "Left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "Right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "Up";
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "Down";
                player.Image = Properties.Resources.down;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;

            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && ammon > 0 && gameOver == false)
            {
                ammon--;
                huntershoot(facing);
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        private void huntershoot(string position)
        {
            bullets bullets = new bullets();
            bullets.bulletLeft = player.Left + (player.Width / 2);
            bullets.bulletTop = player.Top + (player.Height / 2);
            bullets.direction = position;
            bullets.Makebullet(this);
        }
        private void Makezombie()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "Zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = random.Next(60, 1000);
            zombie.Top = random.Next(60, 600);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            piczombie.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }
        private void DropAmmon()
        {
            PictureBox amon = new PictureBox();
            amon.Image = Properties.Resources.ammo_Image;
            amon.Left = random.Next(65, this.ClientSize.Width + amon.Width);
            amon.Top = random.Next(65, this.ClientSize.Width - amon.Height);
            amon.Tag = "Ammon";
            amon.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(amon);
            amon.BringToFront();
            player.BringToFront();
        }
        private void DropHeal()
        {
            PictureBox heal = new PictureBox();
            heal.Image = Properties.Resources.Heal1;
            heal.Left = random.Next(65, this.ClientSize.Width + heal.Width);
            heal.Top = random.Next(65, this.ClientSize.Height - heal.Height);
            heal.SizeMode = PictureBoxSizeMode.AutoSize;
            heal.Tag = "Heal";
            this.Controls.Add(heal);
            heal.BringToFront();
            player.BringToFront();
        }
        private void RestartGame()
        {
            player.Image = Properties.Resources.up;
            foreach (PictureBox i in piczombie)
            {
                this.Controls.Remove(i);
            }
            piczombie.Clear();
            for (int i = 0; i < zombiespawn; i++)
            {
                Makezombie();
            }
            goDown = false;
            goLeft = false;
            goRight = false;
            goUp = false;
            gameOver = false;
            playerhealth = 100;
            kill = 0;
            ammon = 10;
            progb1.Value = playerhealth;
            timer1.Start();
            lbdie.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds - oldsc > 100)
            {
                DropAmmon();
                DropHeal();
                oldsc = seconds;

                if (playerhealth < 50)
                {
                    DropHeal();
                }
            }
            //Game Over
            if (playerhealth > 1)
            {
                playerhealth = playerhealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                playerhealth = 0;
                progb1.Value = 0;
                lbdie.Text = "You dead!";
                timer1.Stop();
            }
            //Ammon , Kill
            lbammon.Text = "Ammon:" + ammon;
            lbkill.Text = "Kill:" + kill;
            //Move
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerspeed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += playerspeed;
            }
            if (goUp == true && player.Top > 65)
            {
                player.Top -= playerspeed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerspeed;
            }
            //CollectAmmon
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Ammon")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammon += 5;
                    }

                }
                //heal
                if (x is PictureBox && (string)x.Tag == "Heal")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove((PictureBox)x);
                        ((PictureBox)x).Dispose();
                        if ((playerhealth += 25) >= 100)
                        {
                            playerhealth = 100;
                        }
                        progb1.Value = playerhealth;
                    }
                }

                //Zoombie
                if (x is PictureBox && (string)x.Tag == "Zombie")
                {
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        if (playerhealth-- == 0)
                        {
                            playerhealth = 0;
                        }
                        progb1.Value = playerhealth;
                    }
                    if (x.Left > player.Left)
                    {
                        x.Left -= zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }
                //shoot
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "Zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            kill++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            piczombie.Remove((PictureBox)x);
                            Makezombie();
                        }
                    }
                }
            }

        }
    }
}