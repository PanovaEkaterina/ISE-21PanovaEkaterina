using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLab3
{
    public abstract class Jewelry : Stone
    {
        protected float srartRosX;
        protected float srartRosY;

        public void setPosition(int x, int y)
        {
            srartRosX = x;
            srartRosY = y;
        }

        public abstract void drawStone(Graphics g);

        //public abstract void Pay(bool buy);

        public abstract void Wear(bool buy);


        //вес
        public virtual double Weight { protected set; get; }

        //цена
        public virtual double Price { protected set; get; }

        //твердость
        public virtual int Hardness { protected set; get; }

        //цвет 
        public Color ColorStone { protected set; get; }

    }
}

