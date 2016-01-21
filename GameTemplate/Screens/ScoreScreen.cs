using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GameTemplate.Screens
{
    public partial class ScoreScreen : UserControl
    {
        public ScoreScreen()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();
            
            showScores();
            
        }
        
        public void showScores()
        {
            exitButton.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 2, 500);
            titleLabel.Font = new Font("Bell Gothic Std", 56, FontStyle.Underline);
            titleLabel.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 2, 20);
            label1.Font = new Font("Bell Gothic Std", 18, FontStyle.Bold);
            label1.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 4, 150);
            label1.ForeColor = Color.Navy;
            label2.Font = new Font("Bell Gothic Std", 18, FontStyle.Bold);
            label2.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 4, 280);
            label2.ForeColor = Color.Navy;
            label3.Font = new Font("Bell Gothic Std", 18, FontStyle.Bold);
            label3.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 4, 410);
            label3.ForeColor = Color.Navy;
            pictureBox1.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 2, 150);
            pictureBox2.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 2, 280);
            pictureBox3.Location = new Point(ScreenControl.controlWidth / 2 - titleLabel.Size.Width / 2, 410);
            
            foreach (int i in ScreenControl.highScores)
            {
                label1.Text += i + "\n";
                
                
            }         
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }

        
        // Change any control default values here
        
        public void defaultOverride()
        {

        }
    }
}
