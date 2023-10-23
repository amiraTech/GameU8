using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameU8
{
    public partial class Form1 : Form
    {


        // Declaring variables \\

        bool goLeft, goRight, jumping, hasKey;
        int jumpSpeed = 10;
        int force = 0;
        int score = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 8;
        int lives = 3;


        // Initialise the code \\

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }



        private bool isPlayerDead = false;


        private void MainTimerEvent(object sender, EventArgs e)
        {

            lblScore.Text = "Score: " + score;
            pbPlayer.Top += jumpSpeed;

            // Ensures player movement \\

            if (goLeft == true && pbPlayer.Left > 60)
            {
                pbPlayer.Left -= playerSpeed;
            }
            if (goRight == true && pbPlayer.Left + (pbPlayer.Width + 60) < this.ClientSize.Width)
            {
                pbPlayer.Left += playerSpeed;
            }


            // Ensures that the background can move \\

            if (goLeft == true && pbBackground.Left < 0)
            {
                pbBackground.Left += backgroundSpeed;
                MoveGameElements("forward");

            }

            if (goRight == true && pbBackground.Left > -1342)
            {
                pbBackground.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            // Ensures that the player can jump \\

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }


            // Ensures that the player can collide with the platforms \\

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        pbPlayer.Top = x.Top - pbPlayer.Height;
                        jumpSpeed = 0;
                    }

                    x.BringToFront();

                }


                // Ensures the player can collide with coins and the score add up to 50 \\

                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 50;
                    }
                }


                // Ensures that the player can interact with the keys and doors \\

                if (pbPlayer.Bounds.IntersectsWith(pbKey.Bounds))
                {
                    pbKey.Visible = false;
                    hasKey = true;
                }


                if (pbPlayer.Bounds.IntersectsWith(door.Bounds) && hasKey == true)
                {
                    door.Image = Properties.Resources.door_open;
                    GameTimer.Stop();
                    MessageBox.Show("Well done, you have now advanced to the next level! " + Environment.NewLine + "Click OK to play again");
                    RestartGame();
                }


                // If the player fall off the platform and collide with the ground then their lives decreased by 1 \\

                if (pbPlayer.Top + pbPlayer.Height > this.ClientSize.Height && !isPlayerDead)
                {
                    isPlayerDead = true;
                    if (lives > 0)
                    {
                        lives--;

                        MessageBox.Show("OH NO, YOU LOST A LIFE " + Environment.NewLine + "Lives Left " + lives + Environment.NewLine + "Click OK to play again");

                        if (lives == 2)
                        {
                            pbLives3.Visible = false;
                        }
                        else if (lives == 1)
                        {
                            pbLives2.Visible = false;
                        }
                        else if (lives == 0)
                        {
                            pbLives1.Visible = false;
                            GameTimer.Stop();
                            MessageBox.Show("OH NO, YOU DIED!" + Environment.NewLine + "Click OK to play again");
                        }


                        RestartGame();

                    }
                    
                     
                }
               

            }

        }


        // Ensures that the players movement are controlled by arrow keys \\

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }
        



        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }

        }



        private int seconds = 0;

        // Initiates the timer once the game starts \\

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string timerText = time.ToString("mm\\:ss");
            lblTimer.Text = timerText;
            Refresh();
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void RestartGame()
        {
            pbPlayer.Location = new Point(50, 300);
            isPlayerDead = false;

            if (lives == 2)
            {
                pbLives3.Visible = false;
            }
            else if (lives == 1)
            {
                pbLives2.Visible = false;
            }
            else if (lives == 0)
            {
                pbLives1.Visible = false;
            }
       
            GameTimer.Start();
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                
                // Ensures that the platform, coin, door and keys are remained at a fixed position \\

                if (x is PictureBox && (string)x.Tag == "platform" || (string)x.Tag == "coin" || (string)x.Tag == "door" || (string)x.Tag == "key")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    else if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
               
            }
        }




    }
}
