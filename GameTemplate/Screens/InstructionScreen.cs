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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
            instructionsLabel.Text = "Press the green button when the ball reaches the plate to swing\n\nYou are out when a home run isn't hit, you have 5 outs\n\nEarn a 'streak bonus' by hitting consecutive home runs, streak bonus ends when you fail to keep the homerun streak\n\nHave Fun!";
            instructionsLabel.Font = new Font("Bell Gothic", 20, FontStyle.Bold);            exitButton.Location = new Point(ScreenControl.controlWidth / 2 - instructionsLabel.Size.Width / 5, 500);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
            
        }
    }
}
