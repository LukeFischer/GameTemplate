using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;  
using GameTemplate.Dialogs;

namespace GameTemplate.Screens
{
    //Evan Moorehead, Brad Kraemer, Luke Fischer
    //ICS3U
    //Home Run Derby 
    public partial class GameScreen : UserControl
    {
        Graphics g;
        //Random number for homerun words
        public static Random randNum = new Random();
        int rand;
        //variables
        int score = 0;
        int outy = 0;
        SoundPlayer player = new SoundPlayer(Properties.Resources.hit);

        public GameScreen()
        {            
            InitializeComponent();
            g = this.CreateGraphics();
            ballX = 490;
            ballY = 80;
        }

        //TODO - Place game global variables here
        int ballX, ballY;
        string ballDirection = "down"; 

        SolidBrush ball = new SolidBrush(Color.White);
        SolidBrush bat = new SolidBrush(Color.SaddleBrown);

      
        bool swingBat = false;
        int swing = 0;
        //----------------------------------------

        // PreviewKeyDown required for UserControl instead of KeyDown as on a form
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rand = randNum.Next(1, 10);

   

            if (e.KeyCode == Keys.Escape)
            {
                pauseGame();
            }
           
            if (e.KeyCode == Keys.Space)
            {
                swingBat = true;
               
                if (ballY > 499 && ballY < 510)
                {
                    player.Play();
                    ballDirection = "leftbomb";

                    if (rand == 1)
                    {
                        label1.Text = "Homerun!";
                    }
                    if (rand == 2)
                    {
                        label1.Text = "Dinger!";
                    }
                    if (rand == 3)
                    {
                        label1.Text = "Moonshot!";
                    }
                    if (rand == 4)
                    {
                        label1.Text = "Long Bomb!";
                    }
                    if (rand == 5)
                    {
                        label1.Text = "Upper-decker!";
                    }
                    if (rand == 6)
                    {
                        label1.Text = "No-Doubter!";
                    }
                    if (rand == 7)
                    {
                        label1.Text = "See Ya!";
                    }
                    if (rand == 8)
                    {
                        label1.Text = "Missile!";
                    }
                    if (rand == 9)
                    {
                        label1.Text = "What a Poke!";
                    }
                }

                if (ballY > 479 && ballY < 500)
                {
                    player.Play();
                    ballDirection = "leftcenter";
                    if (rand == 1)
                    {
                        label1.Text = "Homerun!";
                    }
                    if (rand == 2)
                    {
                        label1.Text = "Dinger!";
                    }
                    if (rand == 3)
                    {
                        label1.Text = "Moonshot!";
                    }
                    if (rand == 4)
                    {
                        label1.Text = "Long Bomb!";
                    }
                    if (rand == 5)
                    {
                        label1.Text = "Upper-decker!";
                    }
                    if (rand == 6)
                    {
                        label1.Text = "No-Doubter!";
                    }
                    if (rand == 7)
                    {
                        label1.Text = "See Ya!";
                    }
                    if (rand == 8)
                    {
                        label1.Text = "Missile!";
                    }
                    if (rand == 9)
                    {
                        label1.Text = "What a Poke!";
                    }
                }

                if (ballY > 469 && ballY < 480)
                {
                    player.Play();
                    ballDirection = "deadcenter";
                    if (rand == 1)
                    {
                        label1.Text = "Homerun!";
                    }
                    if (rand == 2)
                    {
                        label1.Text = "Dinger!";
                    }
                    if (rand == 3)
                    {
                        label1.Text = "Moonshot!";
                    }
                    if (rand == 4)
                    {
                        label1.Text = "Long Bomb!";
                    }
                    if (rand == 5)
                    {
                        label1.Text = "Upper-decker!";
                    }
                    if (rand == 6)
                    {
                        label1.Text = "No-Doubter!";
                    }
                    if (rand == 7)
                    {
                        label1.Text = "See ya!";
                    }
                    if (rand == 8)
                    {
                        label1.Text = "Missile!";
                    }
                    if (rand == 9)
                    {
                        label1.Text = "What a Poke!";
                    }
                }

                if (ballY > 459 && ballY < 470)
                {
                    player.Play();
                    ballDirection = "rightcenter";
                    if (rand == 1)
                    {
                        label1.Text = "Homerun!";
                    }
                    if (rand == 2)
                    {
                        label1.Text = "Dinger!";
                    }
                    if (rand == 3)
                    {
                        label1.Text = "Moonshot!";
                    }
                    if (rand == 4)
                    {
                        label1.Text = "Long Bomb!";
                    }
                    if (rand == 5)
                    {
                        label1.Text = "Upper-decker!";
                    }
                    if (rand == 6)
                    {
                        label1.Text = "No-Doubter!";
                    }
                    if (rand == 7)
                    {
                        label1.Text = "See Ya!";
                    }
                    if (rand == 8)
                    {
                        label1.Text = "Missile!";
                    }
                    if (rand == 9)
                    {
                        label1.Text = "What a Poke!";
                    }
                }

                if (ballY > 439 && ballY < 460)
                {
                    player.Play();
                    ballDirection = "rightbomb";

                    if (rand == 1)
                    {
                        label1.Text = "Homerun!";
                    }
                    if (rand == 2)
                    {
                        label1.Text = "Dinger!";
                    }
                    if (rand == 3)
                    {
                        label1.Text = "Moonshot!";
                    }
                    if (rand == 4)
                    {
                        label1.Text = "Long Bomb!";
                    }
                    if (rand == 5)
                    {
                        label1.Text = "Upper-decker!";
                    }
                    if (rand == 6)
                    {
                        label1.Text = "No-Doubter!";
                    }
                    if (rand == 7)
                    {
                        label1.Text = "See Ya!";
                    }
                    if (rand == 8)
                    {
                        label1.Text = "Missile!";
                    }
                    if (rand == 9)
                    {
                        label1.Text = "What a Poke!";
                    }
                }               
            }
        }

        /// <summary>
        /// All game update logic must be placed in this event method
        /// </summary>
        /// <param name="sender"></param>    
        /// <param name="e"></param>
 
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (swingBat == true)
            {
                swing++;
            }

            if (outy == 5)
            {
                gameTimer.Enabled = false;
                label1.Text = "Game Over";
            }

            if (ballDirection == "down")
            {
                ballY += 20;
            }
            else if (ballDirection == "windup")
            {
                ballY -= 5;
            }
            else if (ballDirection == "leftcenter")
            {
                ballY -= 50;
                ballX -= 20;
            }
            else if (ballDirection == "rightcenter")
            {
                ballY -= 50;
                ballX += 20;
            }
            else if (ballDirection == "leftbomb")
            {
                ballY -= 50; 
                ballX -= 40;
            }
            else if (ballDirection == "rightbomb")
            {
                ballY -= 50;
                ballX += 40;
            }
            else if (ballDirection == "foulright")
            {
                ballY -= 30;
                ballX += 80;
            }
            else if (ballDirection == "foulleft")
            {
                ballY -= 30;
                ballX -= 80;
            }
            else if (ballDirection == "deadcenter")
            {
                ballY -= 80;
            }

            //check to see if ball has gone off top of screen or into catchers mit. If it has set ball back to start 
            //position and direction to down
            
            if (ballY < -60)
            {
                Thread.Sleep(500);            
                ballDirection = "down";
                ballX = 490;
                ballY = 80;
                score++;
                swing = 0;
            }

            if (ballY > 550) 
            {
                Thread.Sleep(500);
                ballDirection = "down";
                ballX = 490;
                ballY = 80;
                label1.Text = "Out";
                outy++;
                swing = 0;
            }
            
            //refresh the screen, which causes the GameScreen_Paint method to run
            Refresh();
            
        }

        /// <summary>
        /// Open the pause dialog box and gets Cancel or Abort result from it
        /// </summary>
        private void pauseGame()
        {
            gameTimer.Enabled = false;

            DialogResult result = PauseDialog.Show();

            if (result == DialogResult.Cancel)
            {
                gameTimer.Enabled = true;
            }
            if (result == DialogResult.Abort)
            {
                ScreenControl.changeScreen(this, "MenuScreen");
            }
        }


        /// <summary>
        /// All drawing, (and only drawing), to be done here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //score and outs text
            Font subtitles = new Font("Arial", 25, FontStyle.Bold);
            Font scores = new Font("Arial", 50, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);            e.Graphics.DrawString("Score", subtitles, drawBrush, 80, 460);
            e.Graphics.DrawString("" + score, scores, drawBrush, 85, 510);
            e.Graphics.DrawString("Outs", subtitles, drawBrush, 820, 460);
            e.Graphics.DrawString("" + outy, scores, drawBrush, 830, 510);


            //ball drawing
            e.Graphics.FillEllipse(ball, ballX, ballY, 15, 15);
            //bat drawing

            if (swing == 0)
            {
                e.Graphics.FillEllipse(bat, 610, 400, 20, 10);
                e.Graphics.FillEllipse(bat, 610, 450, 20, 10);
                e.Graphics.FillRectangle(bat, 610, 405, 20, 50);
                e.Graphics.FillRectangle(bat, 615, 450, 10, 50);
                e.Graphics.FillEllipse(bat, 610, 490, 20, 10);
            }
            else if (swing == 1)
            {
                e.Graphics.TranslateTransform(700, 0);
                e.Graphics.RotateTransform(90);

                e.Graphics.FillEllipse(bat, 460, 0, 20, 10);
                e.Graphics.FillEllipse(bat, 460, 50, 20, 10);
                e.Graphics.FillRectangle(bat, 460, 5, 20, 50);
                e.Graphics.FillRectangle(bat, 465, 50, 10, 50);
                e.Graphics.FillEllipse(bat, 460, 90, 20, 10);

                e.Graphics.ResetTransform();
            }
            else if (swing == 2)
            {
                e.Graphics.TranslateTransform(1075, 570);
                e.Graphics.RotateTransform(180);

                e.Graphics.FillEllipse(bat, 460, 0, 20, 10);
                e.Graphics.FillEllipse(bat, 460, 50, 20, 10);
                e.Graphics.FillRectangle(bat, 460, 5, 20, 50);
                e.Graphics.FillRectangle(bat, 465, 50, 10, 50);
                e.Graphics.FillEllipse(bat, 460, 90, 20, 10);

                e.Graphics.ResetTransform();
            }
            else if (swing > 3)
            {
                e.Graphics.TranslateTransform(490, 950);
                e.Graphics.RotateTransform(270);

                e.Graphics.FillEllipse(bat, 460, 0, 20, 10);
                e.Graphics.FillEllipse(bat, 460, 50, 20, 10);
                e.Graphics.FillRectangle(bat, 460, 5, 20, 50);
                e.Graphics.FillRectangle(bat, 465, 50, 10, 50);
                e.Graphics.FillEllipse(bat, 460, 90, 20, 10);

                e.Graphics.ResetTransform();

                swingBat = false;
                swing = 0;
            }

        }

    }
}
