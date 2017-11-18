using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba2
{
    class Adamant : Jewelry
    {
        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 0 && value < 34)
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
                if (value > 0 && value < 10000)
                {
                    base.Price = value;
                }
                else { base.Price = 5000; }
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
                if (value > 0 && value < 11)
                {
                    base.Hardness = value;
                }
                else { base.Hardness = 10; }
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

        public Adamant(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                Weight = Convert.ToInt32(strs[0]);
                Price = Convert.ToInt32(strs[1]);
                Hardness = Convert.ToInt32(strs[2]);
                ColorStone = Color.FromName(strs[3]);
            }
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

        public override string getInfo()
        {
           return Weight + ";" + Price + ";" + Hardness + ";" + ColorStone.Name;
        }
    }
}
