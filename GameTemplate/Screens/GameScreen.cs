using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        #region required global values - DO NOT CHANGE


        //player1 button control keys - DO NOT CHANGE
        Boolean spaceDown;

        #endregion

        //TODO - Place game global variables here


        //Graphics objects
        SolidBrush ball = new SolidBrush(Color.Black);
        SolidBrush bat = new SolidBrush(Color.Red);
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
            g.FillEllipse(ball, 25, 25, 100, 200);
        }

    }
}
