namespace Cargame
{
    public partial class Form1 : Form
    {
        int gamespeed = 10, timing = 0, oldtime, pt = 0;
        Random random = new Random();
        int x, collectcoin = 0, counter1 = 4;
        bool stop = false;
        public Form1()
        {
            InitializeComponent();
            lbover.Visible = false;
            stop = false;

        }
        void coins(int speed)
        {
            if (c1.Top >= 755)
            {
                c1.Visible = true;
                c2.Visible = true;
                c3.Visible = true;
                c4.Visible = true;
                c5.Visible = true;
                x = random.Next(20, 300);
                c1.Location = new Point(x, 0);
                c2.Location = new Point(x, 30);
                c3.Location = new Point(x, 60);
                c4.Location = new Point(x, 90);
                c5.Location = new Point(x, 120);
            }
            else
            {

                c1.Top += speed;
                c2.Top += speed;
                c3.Top += speed;
                c4.Top += speed;
                c5.Top += speed;
            }
            if (c1.Top >= 755)
            {
                c6.Visible = true;
                c7.Visible = true;
                c8.Visible = true;
                c9.Visible = true;
                c10.Visible = true;
                x = random.Next(20, 300);
                c6.Location = new Point(x, 0);
                c7.Location = new Point(x, 30);
                c8.Location = new Point(x, 60);
                c9.Location = new Point(x, 90);
                c10.Location = new Point(x, 120);
            }
            else
            {

                c6.Top += speed;
                c7.Top += speed;
                c8.Top += speed;
                c9.Top += speed;
                c10.Top += speed;
            }
            if (c1.Top >= 755)
            {
                c11.Visible = true;
                c12.Visible = true;
                c13.Visible = true;
                c14.Visible = true;
                c15.Visible = true;
                x = random.Next(20, 300);
                c11.Location = new Point(x, 0);
                c12.Location = new Point(x, 30);
                c13.Location = new Point(x, 60);
                c14.Location = new Point(x, 90);
                c15.Location = new Point(x, 120);
            }
            else
            {

                c11.Top += speed;
                c12.Top += speed;
                c13.Top += speed;
                c14.Top += speed;
                c15.Top += speed;
            }
        }
        public void enemy(int speed)
        {
            if (ecar1.Top >= 755)
            {
                x = random.Next(20, 200);
                ecar1.Location = new Point(x, 0);
            }
            else
            {
                ecar1.Top += speed;
            }
            if (ecar2.Top >= 755)
            {
                x = random.Next(20, 100);
                ecar2.Location = new Point(x, 0);
            }
            else
            {
                ecar2.Top += speed;
            }
            if (ecar3.Top >= 755)
            {
                x = random.Next(20, 300);
                ecar3.Location = new Point(x, 0);
            }
            else
            {
                ecar3.Top += speed;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter1 == 0)
            {
                lbcounter.Visible = false;
                stop = false;
                moveline(gamespeed);
                enemy(gamespeed);
                gamevore();
                coins(gamespeed);
                collection();
                point.Text = (pt++).ToString();
            }
            else { stop = true; }

        }
        void collection()
        {
            if (car.Bounds.IntersectsWith(c1.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c1.Visible = false;
                x = random.Next(20, 200);
                c1.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(c2.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c2.Visible = false;
                x = random.Next(20, 200);
                c2.Location = new Point(x, 30);

            }
            if (car.Bounds.IntersectsWith(c3.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c3.Visible = false;
                x = random.Next(20, 200);

                c3.Location = new Point(x, 60);

            }
            if (car.Bounds.IntersectsWith(c4.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c4.Visible = false;
                x = random.Next(20, 200);

                c4.Location = new Point(x, 90);

            }
            if (car.Bounds.IntersectsWith(c5.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c5.Visible = false;
                x = random.Next(20, 200);

                c5.Location = new Point(x, 120);
            }
            if (car.Bounds.IntersectsWith(c6.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c6.Visible = false;
                x = random.Next(20, 300);
                c6.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(c7.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c7.Visible = false;
                x = random.Next(20, 300);

                c7.Location = new Point(x, 30);

            }
            if (car.Bounds.IntersectsWith(c8.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c8.Visible = false;
                x = random.Next(20, 300);

                c8.Location = new Point(x, 60);

            }
            if (car.Bounds.IntersectsWith(c9.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c9.Visible = false;
                x = random.Next(20, 300);

                c9.Location = new Point(x, 90);

            }
            if (car.Bounds.IntersectsWith(c10.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c10.Visible = false;
                x = random.Next(20, 300);

                c10.Location = new Point(x, 120);
            }
            if (car.Bounds.IntersectsWith(c11.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c11.Visible = false;
                x = random.Next(20, 100);
                c11.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(c12.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c12.Visible = false;
                x = random.Next(20, 100);

                c12.Location = new Point(x, 30);

            }
            if (car.Bounds.IntersectsWith(c13.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c13.Visible = false;
                x = random.Next(20, 100);

                c13.Location = new Point(x, 60);

            }
            if (car.Bounds.IntersectsWith(c14.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c14.Visible = false;
                x = random.Next(20, 100);

                c14.Location = new Point(x, 90);

            }
            if (car.Bounds.IntersectsWith(c15.Bounds))
            {
                collectcoin = collectcoin + 1;
                lbcn.Text = "×" + collectcoin;
                c15.Visible = false;
                x = random.Next(20, 100);

                c15.Location = new Point(x, 120);
            }
        }
        public void gamevore()
        {
            if (car.Bounds.IntersectsWith(ecar1.Bounds))
            {
                timer1.Enabled = false;
                lbover.Visible = true;
                stop = true;
            }
            if (car.Bounds.IntersectsWith(ecar2.Bounds))
            {
                timer1.Enabled = false;
                lbover.Visible = true;
                stop = true;
            }
            if (car.Bounds.IntersectsWith(ecar3.Bounds))
            {
                timer1.Enabled = false;
                lbover.Visible = true;
                stop = true;
            }
        }
        public void moveline(int speed)
        {
            if (pcB1.Top >= 755)
            {
                pcB1.Top = 0;
            }
            else
            {
                pcB1.Top += speed;
            }
            if (pcB2.Top >= 755)
            {
                pcB2.Top = 0;
            }
            else
            {
                pcB2.Top += speed;
            }
            if (pcB3.Top >= 755)
            {
                pcB3.Top = 0;
            }
            else
            {
                pcB3.Top += speed;
            }
            if (pcB4.Top >= 755)
            {
                pcB4.Top = 0;
            }
            else
            {
                pcB4.Top += speed;
            }
            if (pcB5.Top >= 755)
            {
                pcB5.Top = 0;
            }
            else
            {
                pcB5.Top += speed;
            }
            if (pcB6.Top >= 755)
            {
                pcB6.Top = 0;
            }
            else
            {
                pcB6.Top += speed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (stop == false)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (car.Left > 20)
                        car.Left += -10;
                }

                if (e.KeyCode == Keys.Right)
                {
                    if (car.Right < 350)
                        car.Left += 20;
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (car.Top > 20)
                        car.Top += -20;
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (car.Bottom < 700)
                        car.Top += 20;
                }
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void c1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((counter1--) == 0)
            {
                counter1 = 0;

            }
            lbcounter.Text = counter1.ToString();
            timing++;
            if (timing - oldtime == 10)
            {
                gamespeed += 5;
                oldtime = timing;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}