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
    public partial class OptionScreen : UserControl
    {
        Graphics g;

        public OptionScreen()
        {
            InitializeComponent();
            label1.Text = "100 Points = Legendary";
            label2.Text = "50 Points = Pro";
            label3.Text = "20 Points = Rookie";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }
    }
}
