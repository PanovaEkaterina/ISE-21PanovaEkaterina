using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLab3
{
    class Diamond : Adamant
    {
        private bool facet; //грани
        private Color dopColor;

        public Diamond(double weight, double price, int hardness, Color color, bool facet, Color dopColor) : base(weight, price, hardness, color)
       {
            this.facet = facet;
            this.dopColor = dopColor;
        }

        protected override void drawAdamant(Graphics g)
        {
            base.drawAdamant(g);

            //грани
            if (facet)
            {
                Pen pen = new Pen(dopColor);
                g.DrawLine(pen, srartRosX - 30, srartRosY - 30, srartRosX + 30, srartRosY - 30);
                g.DrawLine(pen, srartRosX - 25, srartRosY - 35, srartRosX - 13, srartRosY - 30);
                g.DrawLine(pen, srartRosX, srartRosY - 35, srartRosX - 13, srartRosY - 30);
                g.DrawLine(pen, srartRosX, srartRosY - 35, srartRosX + 13, srartRosY - 30);
                g.DrawLine(pen, srartRosX + 25, srartRosY - 35, srartRosX + 13, srartRosY - 30);
                g.DrawLine(pen, srartRosX - 10, srartRosY - 30, srartRosX, srartRosY);
                g.DrawLine(pen, srartRosX + 13, srartRosY - 30, srartRosX, srartRosY);
            }

        }

        public void setDopColor(Color color) {
            dopColor = color;
        }

    }
}
