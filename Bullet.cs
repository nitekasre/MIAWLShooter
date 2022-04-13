using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace ShooterDLL
{
    public class Bullet
    {
        //public variables to be used for the bullet
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        //private variables that will be specific to the class
        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            //design controls fro the bullet. defines color, size & name
            //defines the variables for left and top and brings the bullet to the front of the form
            bullet.BackColor = Color.Crimson;
            bullet.Size = new Size(5,5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            //adds the bullet to the form
            form.Controls.Add(bullet);

            //sets the interval for the bullet timer to the variable 20 and creates an event for the bullet
            bulletTimer.Interval = speed;

            //will start the event when the timer is enabled and pass the bullet timer event defined below
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        { 
            //sets parameters for how the bullet will move based on the direction the player is facing.
            if (direction == "left")
            {
                bullet.Left -= speed;
            }

            if (direction == "right")
            {
                bullet.Left += speed;
            }

            if (direction == "up")
            {
                bullet.Top -= speed;
            }

            if (direction == "down")
            {
                bullet.Top += speed;
            }

            //removes the bullet from the form if it does not hit a target -- decreases memory used by closing events that are no longer being used.
            //if the bullet is outside of the bounds below, the timer will stop & be disposed. the bullet will dispose and both values will be null.
            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }

    }
}
