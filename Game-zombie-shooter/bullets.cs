using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_zombie_shooter
{
    internal class bullets
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speeds = 20;
        private PictureBox bullet = new PictureBox();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public void Makebullet(Form form)
        {
            bullet.BackColor = Color.Yellow;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();
            form.Controls.Add(bullet);
            timer.Interval = speeds;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(direction == "Left")
            {
                bullet.Left -= speeds;
            }
            if(direction == "Right")
            {
                bullet.Left += speeds;
            }
            if (direction == "Up")
            {
                bullet.Top -= speeds;
            }
            if(direction == "Down")
            {
                bullet.Top += speeds;
            }
            if(bullet.Left < 5 || bullet.Left>1020 || bullet.Top<10|| bullet.Top > 620)
            {
                timer.Stop();
                timer.Dispose();
                bullet.Dispose();
                timer = null;
                bullet = null;
            }
        }
    }
}
