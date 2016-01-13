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
            instructionsLabel.Text = "- Press the green button once the ball reaches the plate to swing at your bat \n\n - You have 5 outs \n\n - Earn a multiplier by hitting consecutive home runs \n\n - Multiplier resets when you fail to hit a homerun \n\n Have Fun!";
            instructionsLabel.Font = new Font("Bell Gothic", 18, FontStyle.Bold);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
            
        }
    }
}
