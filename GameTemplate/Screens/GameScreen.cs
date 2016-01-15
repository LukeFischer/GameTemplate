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
        }


            #region required global values - DO NOT CHANGE


            //player1 button control keys - DO NOT CHANGE
            Boolean spaceDown;

        #endregion

        //TODO - Place game global variables here
        int ballX, ballY;

        SolidBrush ball = new SolidBrush(Color.White);
        //----------------------------------------

        // PreviewKeyDown required for UserControl instead of KeyDown as on a form
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pauseGame();
            }

        }

        /// <summary>
        /// All game update logic must be placed in this event method
        /// </summary>
        /// <param name="sender"></param>    
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ballY -= 5;

            if (ballY < 20)
            {
                ballY += 20;
            }
            
            if (ballY > 500)
            {
                gameTimer.Enabled = false;
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
            e.Graphics.FillEllipse(ball, ballX, ballY, 15, 15);
        }

    }
}
