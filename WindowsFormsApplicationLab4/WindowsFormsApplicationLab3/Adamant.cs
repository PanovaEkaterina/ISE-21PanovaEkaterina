using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLab3
{
    class Adamant: Jewelry
    {
        public override double Weight
       {
            get
           {
               return base.Weight;
            }

            protected set
           {
               if (value > 0 && value< 34)
                {
                    base.Weight = value;
                }
                else { base.Weight = 15; }
            }
        }

        public override double Price
        {
            get
            {
                return base.Price;
            }

            protected set
            {
               if (value > 0 && value< 10000)
                {
                    base.Weight = value;
                }
                else { base.Weight = 5000; }
            }
        }

        public override int Hardness
        {
            get
            {
                return base.Hardness;
            }

            protected set
            {
               if (value > 0 && value< 11)
                {
                    base.Weight = value;
                }
                else { base.Weight = 10; }
            }
        }

        public Adamant(double weight, double price, int hardness, Color color)
        {
            this.Weight = weight;
            this.Price = price;
            this.Hardness = hardness;
            this.ColorStone = color;
            Random rand = new Random();
            srartRosX = rand.Next(10, 200);
            srartRosY = rand.Next(10, 200);
        }
       public override void drawStone(Graphics g)
        {
            drawAdamant(g);
        }

        protected virtual void drawAdamant(Graphics g)
        {
            Pen pen = new Pen(ColorStone);
            g.DrawLine(pen, srartRosX, srartRosY, srartRosX - 30, srartRosY - 30);
            g.DrawLine(pen, srartRosX, srartRosY, srartRosX + 30, srartRosY - 30);
            g.DrawLine(pen, srartRosX - 30, srartRosY - 30, srartRosX - 25, srartRosY - 35);
            g.DrawLine(pen, srartRosX + 30, srartRosY - 30, srartRosX + 25, srartRosY - 35);
            g.DrawLine(pen, srartRosX - 25, srartRosY - 35, srartRosX + 25, srartRosY - 35);
        }



    }
    }

