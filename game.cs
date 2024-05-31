using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceinvaders
{
    internal class game
    {


        
        public int PSpeed = 0;
        public bool Left;
        public bool Right; // sant falskt om man går höger vänster med 
        private int poäng = 0;
        private bool Noob; // sant falskt om spelare död

        private  Form form;
        public bool sköt;
        private Invaders invaders;
        PictureBox spelare = new PictureBox();

        public game(Form1 form1)
        {
            this.form1 = form1;
        }

        public void skeppet()
        {
            spelare.Image = Image.FromFile("C:\\Users\\060118as\\OneDrive - Värnamo Kommun\\FIGY\\åk2\\programering 1\\inlämningar\\Spelet\\SpaceInvaders\\SpaceInvaders\\picturs bruv\\spachip mindre.png");
            spelare.Location = new Point(279, 353);
            form.Controls.Add(spelare);
            // Lägga till skeppet i spelet


        }

        public void tryckta(Keys högerVänster)
        {
            Direktion();

            switch (högerVänster)
            {
                case Keys.Left:
                    Left = true;
                    Right = false;
                    break;
                case Keys.Right:
                    Right = true;
                    Left = false;
                    break;
                case Keys.Space:
                    Skott();
                    sköt = true;
                    break;
                default:
                    sköt = false;
                    break;
            }//om den rör sig
            Direktion();


        }



        public void Direktion()
        {
            if (Left == true)
            {
                PSpeed = -1;
            }

            else if (Right == true)
            {
                PSpeed = +1;
            }
            else
            {
                PSpeed = 0;
            }

        }

        private PictureBox skott;

        private void Skott()
        {
            if (skott == null)
            {
                PictureBox skott = new PictureBox();
                skott.Image = Image.FromFile("\"C:\\programering 1\\inlämningar\\Spelet\\SpaceInvaders\\SpaceInvaders\\picturs bruv\\skott.png\"");
                skott.Location = new Point(spelare.Location.X + spelare.Width / 2, spelare.Location.Y + spelare.Height);
                form.Controls.Add(skott);
                lblScore.Text = (int.Parse(lblScore.Text) + 100).ToString();
            }
        }
        // skottet ska åka uppåt
        private int SSpeed = 4;

        public void dog()
        {
            foreach (PictureBox fiende in invaders.TotalFienden.ToList())
            {
                if (skott.Bounds.IntersectsWith(fiende.Bounds))
                {
                    form.Controls.Remove(skott);
                    skott = null;
                    invaders.Träffad(fiende);
                    poäng += 10;
                    break;
                }
            }
        }


        public void Uppåt()
        {
            if (skott != null)
            {

                skott.Top -= SSpeed;
                if (skott.Top < 0) // när den når toppen
                {
                    form.Controls.Remove(skott);
                    skott = null;
                }
            }
        }



        public void PRun()
        {



            // Uppdatera spelarens positionä 
            spelare.Left += PSpeed;



            //spelarens postion
            if (Left && spelare.Left > 0)
            {
                spelare.Left -= PSpeed;
            }
            else if (Right && spelare.Left < 0)
            {
                spelare.Left += PSpeed;
            }
            //gränser
            if (spelare.Location.X == 17 || spelare.Location.X == 534)
            {
                PSpeed = 0;
            }//eller left = 0 och right = 0.


            Uppåt();

            dog();


            // Uppdatera poängen

        }
    }
}