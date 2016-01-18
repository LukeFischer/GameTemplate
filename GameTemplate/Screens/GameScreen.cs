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

        public GameScreen()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            ballX = 490;
            ballY = 100;
            label1.Visible = false;
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
            if (e.KeyCode == Keys.Escape)
            {
                pauseGame();
            }
            if (e.KeyCode == Keys.Space)
            {
                //gameTimer.Enabled = false;
                if (ballY > 470 && ballY < 480)
                {
                    ballDirection = "leftcenter";
                }
                if (ballY > 450 && ballY < 469)
                {
                    ballDirection = "rightcenter";
                }
                if (ballY > 481 && ballY < 510)
                {
                    ballDirection = "leftbomb";
                }
                if (ballY > 420 && ballY < 449)
                {
                    ballDirection = "rightbomb";
                }
                if (ballY > 511 && ballY < 540)
                {
                    ballDirection = "foulleft";
                }
                if (ballY > 400 && ballY < 419)
                {
                    ballDirection = "foulright";
                }
                if (ballY == 500)
                {
                    gameTimer.Enabled = false;
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
            //label1.Visible = true;
            //label1.Text = "3";
            //Thread.Sleep(100);
            //Refresh();
            //label1.Text = "2";
            //Thread.Sleep(100);
            //Refresh();
            //label1.Text = "1";
            //Thread.Sleep(100);
            //Refresh();
            if (ballDirection == "down")
            {

                ballY += 20;

            }
            else if (ballDirection == "leftcenter")
            {
                ballY -= 50;
                ballX -= 10;
            }
            else if (ballDirection == "rightcenter")
            {
                ballY -= 50;
                ballX += 10;
            }
            else if (ballDirection == "leftbomb")
            {
                ballY -= 40; 
                ballX -= 40;
            }
            else if (ballDirection == "rightbomb")
            {
                ballY -= 40;
                ballX += 40;
            }
            else if (ballDirection == "foulright")
            {
                ballY -= 30;
                ballX += 60;
            }
            else if (ballDirection == "foulleft")
            {
                ballY -= 30;
                ballX -= 80;
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
