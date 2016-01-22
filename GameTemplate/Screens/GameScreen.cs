using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;  
using GameTemplate.Dialogs;

namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        Graphics g;
        public static Random randNum = new Random();
        int rand;
        int score = 0;

        public GameScreen()
        {            
            InitializeComponent();
            g = this.CreateGraphics();
            ballX = 490;
            ballY = 80;
            

        }


            #region required global values - DO NOT CHANGE


            //player1 button control keys - DO NOT CHANGE
            Boolean spaceDown;

        #endregion

        //TODO - Place game global variables here
        int ballX, ballY;
        string ballDirection = "down";

        SolidBrush ball = new SolidBrush(Color.White);
        SolidBrush bat = new SolidBrush(Color.SaddleBrown);
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
                //gameTimer.Enabled = false;
                if (ballY > 524 && ballY < 550)
                {
                    ballDirection = "foulleft";
                    label1.Text = "Foul Ball";
                }


                if (ballY > 504 && ballY < 525)
                {
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

                if (ballY > 484 && ballY < 505)
                {
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

                if (ballY > 474 && ballY < 485)
                {
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

                if (ballY > 459 && ballY < 475)
                {
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
                if (ballY > 410 && ballY < 440)
                {
                    ballDirection = "foulright";
                    label1.Text = "Foul Ball";
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
            
           
            if (ballDirection == "down")
            {
                ballY += 20;
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

            if (ballY < 0)
            {
                ballDirection = "down";
                ballX = 490;
                ballY = 80;
                score++;         
                label2.Text = score.ToString();

            }
            if (ballY > 550) 
            {
                ballDirection = "down";
                ballX = 490;
                ballY = 80;
                label1.Text = "Out";

            }
            //refresh the screen, which causes the GameScreen_Paint method to run
            Refresh();
            //gameTimer.Enabled = false;
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
            e.Graphics.FillEllipse(ball, ballX, ballY, 15, 15);
           // e.Graphics.FillEllipse(bat, 500, 500, 25, 50);
        }

    }
}
