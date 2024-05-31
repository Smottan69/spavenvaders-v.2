namespace Spaceinvaders
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuBtnStartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.GamePictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.label4);
            this.PanelMenu.Controls.Add(this.label6);
            this.PanelMenu.Controls.Add(this.label3);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.MenuBtnStartGame);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Location = new System.Drawing.Point(686, 148);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(662, 503);
            this.PanelMenu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(92, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 69);
            this.label4.TabIndex = 4;
            this.label4.Text = "2022 by John Pitchers Built with BabylonJS. 3D models created in Blender. Sound e" +
    "ffects by Juhani JunkalaAll code and models on Github: https://github.com/johnpi" +
    "tchers/Space-Invaders";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Image = global::Spaceinvaders.Properties.Resources.SPACE_INVADERS;
            this.label6.Location = new System.Drawing.Point(201, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 144);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(281, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "- - - - - -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(281, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "- - - - - -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(191, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arrow keys to moveShift, Space or Enter to shoot";
            // 
            // MenuBtnStartGame
            // 
            this.MenuBtnStartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuBtnStartGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuBtnStartGame.Image = global::Spaceinvaders.Properties.Resources.Start_menu_btn;
            this.MenuBtnStartGame.Location = new System.Drawing.Point(188, 214);
            this.MenuBtnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.MenuBtnStartGame.Name = "MenuBtnStartGame";
            this.MenuBtnStartGame.Size = new System.Drawing.Size(242, 42);
            this.MenuBtnStartGame.TabIndex = 0;
            this.MenuBtnStartGame.Text = "button1";
            this.MenuBtnStartGame.UseVisualStyleBackColor = false;
            this.MenuBtnStartGame.Click += new System.EventHandler(this.MenuBtnStartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(13, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 455);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.lblHighscore);
            this.gamePanel.Controls.Add(this.lblLives);
            this.gamePanel.Controls.Add(this.lblLevel);
            this.gamePanel.Controls.Add(this.lblScore);
            this.gamePanel.Controls.Add(this.GamePictureBox);
            this.gamePanel.Location = new System.Drawing.Point(77, 145);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(604, 462);
            this.gamePanel.TabIndex = 9;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHighscore.Location = new System.Drawing.Point(416, 23);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(50, 20);
            this.lblHighscore.TabIndex = 7;
            this.lblHighscore.Text = "High :";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLives.Location = new System.Drawing.Point(299, 23);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(59, 20);
            this.lblLives.TabIndex = 6;
            this.lblLives.Text = "LIves : ";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLevel.Location = new System.Drawing.Point(190, 23);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(91, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 20);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: ";
            // 
            // GamePictureBox
            // 
            this.GamePictureBox.Image = global::Spaceinvaders.Properties.Resources.Namnlös;
            this.GamePictureBox.Location = new System.Drawing.Point(17, 3);
            this.GamePictureBox.Name = "GamePictureBox";
            this.GamePictureBox.Size = new System.Drawing.Size(652, 496);
            this.GamePictureBox.TabIndex = 0;
            this.GamePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 797);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MenuBtnStartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox GamePictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

