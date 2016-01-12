using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate.Screens
{
    public partial class MenuScreen : UserControl
    {
       
      Color buttonActiveColor = Color.Red;

        public MenuScreen()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "GameScreen");
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "InstructionScreen");
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "ScoreScreen");
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "OptionScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Change any control default values here
        /// </summary>
        public void defaultOverride()
        {
            foreach (Control c in this.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + 75);             
            }

            gameTitle.Font = new Font("Hobo Std", 72);
            gameTitle.Location = new Point(ScreenControl.controlWidth / 2 - gameTitle.Size.Width / 2, 50);

            playButton.Location = new Point(ScreenControl.controlWidth / 2 - gameTitle.Size.Width / 5, 180);
            optionsButton.Location = new Point(ScreenControl.controlWidth / 2 - gameTitle.Size.Width / 5, 420);
            scoresButton.Location = new Point(ScreenControl.controlWidth / 2 - gameTitle.Size.Width / 5, 340);
            exitButton.Location = new Point(ScreenControl.controlWidth / 2 - gameTitle.Size.Width / 5, 500);
            instructionButton.Location = new Point(ScreenControl.controlWidth / 2 - gameTitle.Size.Width / 5, 260);



        }


    }
}
