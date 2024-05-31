using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceinvaders
{
    public partial class Form1 : Form
    {
        private game game;
        private Invaders invaders;
        private Timer uppdatera;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer(); // Initialize the Timer here
            this.game = new game(this);
            spelet();

            // Initialize gamePanel
            gamePanel = new Panel();
            gamePanel.Dock = DockStyle.Fill;
            gamePanel.BackColor = Color.White;
            Controls.Add(gamePanel);
        }

        private void InitializeTimer()
        {
            uppdatera = new Timer();
            uppdatera.Interval = 1000; // Set the interval (1000ms = 1 second)
            uppdatera.Tick += new EventHandler(uppdatera_Tick);
        }

        private void spelet()
        {
            PanelMenu.Show();
            this.game = new game(this);
            this.invaders = new Invaders(this);
            invaders.spawna();
        }

        private void backgrundMeny_Click(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void MenuBtnStartGame_Click(object sender, EventArgs e)
        {
            PanelMenu.Hide();
            gamePanel.Show();
            gamePanel.BringToFront();
            uppdatera.Start();
          
        }

        private void uppdatera_Tick(object sender, EventArgs e)
        {
            game.PRun();
            invaders.FRun();
        }

        private void Skeppet_Click(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event handler code
        }
    }
}
