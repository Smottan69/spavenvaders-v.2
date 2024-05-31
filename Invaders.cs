using Spaceinvaders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceinvaders
{
    internal class Invaders
    {
        private game game;
        readonly Timer spawn = new Timer();
        private readonly Form form;
        // för begränsa fienden
        public int antalFienden;
        //för att kunna ta bort fienden när kulla träffar
        public List<PictureBox> TotalFienden = new List<PictureBox>();
        private int OmHögerVänster = 1; // höger
        private int GåNer = 20;
        private int FSpeed = 1;
        public Invaders(Form form)
        {
            this.form = form;
            spawn.Interval = 1000;
            spawn.Tick += spawn_Tick;
            spawn.Start();
        }

        private void spawn_Tick(object sender, EventArgs e)
        {
            spawna();
        }

        public void spawna()
        {
            if (antalFienden < 12)
            {
                PictureBox fienden = new PictureBox();
                fienden.Image = Image.FromFile("C:\\Users\\060118as\\OneDrive - Värnamo Kommun\\FIGY\\åk2\\programering 1\\inlämningar\\Spaceinvaders\\Spaceinvaders\\Resources\\skottet.png");
                fienden.Location = new Point(0, 353);
                form.Controls.Add(fienden);
                TotalFienden.Add(fienden); //lågga de i list
                antalFienden++;
            }

        }

        public void Träffad(PictureBox fiende)
        {

            form.Controls.Remove(fiende);
            TotalFienden.Remove(fiende);
            antalFienden--; //??? ksk till poängen
        }


        public void Neråt()
        {
            foreach (PictureBox fiende in TotalFienden)
            {
                fiende.Top += GåNer;
            }
        }

        public void FRun()
        {


            bool hitBorder = false;

            foreach (PictureBox fiende in TotalFienden)
            {
                fiende.Left += FSpeed * OmHögerVänster;

                // Check if any invader hits the right or left border
                if (fiende.Right >= form.ClientSize.Width || fiende.Left <= 0)
                {
                    hitBorder = true;
                }
            }

            // If any invader hits the border, move all invaders down and change direction
            if (hitBorder)
            {
                OmHögerVänster = -OmHögerVänster;
                Neråt();
            }
        }
    }
}
