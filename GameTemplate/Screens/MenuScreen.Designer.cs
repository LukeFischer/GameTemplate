namespace GameTemplate.Screens
{
    partial class MenuScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.scoresButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.instructionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Bell Gothic Std", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Navy;
            this.exitButton.Location = new System.Drawing.Point(106, 255);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 39);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.White;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Font = new System.Drawing.Font("Bell Gothic Std", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.ForeColor = System.Drawing.Color.Navy;
            this.optionsButton.Location = new System.Drawing.Point(106, 126);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(120, 39);
            this.optionsButton.TabIndex = 9;
            this.optionsButton.Tag = "OptionsScreen";
            this.optionsButton.Text = "Practice";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.White;
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Font = new System.Drawing.Font("Bell Gothic Std", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresButton.ForeColor = System.Drawing.Color.Navy;
            this.scoresButton.Location = new System.Drawing.Point(106, 169);
            this.scoresButton.Margin = new System.Windows.Forms.Padding(2);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(120, 39);
            this.scoresButton.TabIndex = 8;
            this.scoresButton.Tag = "ScoreScreen";
            this.scoresButton.Text = "High Scores";
            this.scoresButton.UseVisualStyleBackColor = false;
            this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Red;
            this.playButton.Font = new System.Drawing.Font("Bell Gothic Std", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Navy;
            this.playButton.Location = new System.Drawing.Point(106, 83);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 39);
            this.playButton.TabIndex = 6;
            this.playButton.Tag = "GameScreen";
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.Font = new System.Drawing.Font("Hobo Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.Color.White;
            this.gameTitle.Location = new System.Drawing.Point(49, 25);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(259, 68);
            this.gameTitle.TabIndex = 5;
            this.gameTitle.Text = "Ram Slam";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.Color.White;
            this.instructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionButton.Font = new System.Drawing.Font("Bell Gothic Std", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionButton.ForeColor = System.Drawing.Color.Navy;
            this.instructionButton.Location = new System.Drawing.Point(106, 212);
            this.instructionButton.Margin = new System.Windows.Forms.Padding(2);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(120, 39);
            this.instructionButton.TabIndex = 7;
            this.instructionButton.Text = "How To Play";
            this.instructionButton.UseVisualStyleBackColor = false;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.scoresButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(350, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button instructionButton;
    }
}
