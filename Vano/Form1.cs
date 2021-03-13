using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vano
{
    public partial class Game : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool isGameOver = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        int horizontalSpeed = 5;
        public Game()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
            
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.XButton1)
            {
                RestartGame();
            }
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scoretxt.Text = "Score: " + score;

            player.Top += jumpSpeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (goleft)
            {
                player.Left -= 5;
            }

            if (goright)
            {
                player.Left += 5;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;


                        if ((string)x.Name == "Horizontaal" && goleft == false || (string)x.Name == "Horizontaal" && goright == false)
                        {
                            player.Left -= horizontalSpeed;
                        }
                    }
                    x.BringToFront();
                }
            }

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "floor")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                        {
                            force = 8;
                            player.Top = 
                            x.Bottom;
                        }
                        x.BringToFront();
                    }
                

                    if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }
                if ((string)x.Tag == "spike")
                    {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                        RestartGame();
                }
            }

            Horizontaal.Left -= horizontalSpeed;
           
            if(Horizontaal.Left <0 || Horizontaal.Left + Horizontaal.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("All I do is win win win no matter what");
            }
        }

        private void door_Click(object sender, EventArgs e)
        {

        }

        private void coin_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }
        private void RestartGame()
        {

            goleft = false;
            goright = false;
            jumping = false;
            isGameOver = false;
            score = 0;

            Scoretxt.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true; 
                }
            }

            //reset position from player

            player.Left = 51;
            player.Top = 518;

            timer1.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
