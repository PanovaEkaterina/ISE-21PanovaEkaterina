using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba2
{
    class Diamond : Adamant, IComparable<Diamond>, IEquatable<Diamond>
    {
        private bool facet; 
        private Color dopColor;

        public Diamond(double weight, double price, int hardness, Color color, bool facet, Color dopColor) : base(weight, price, hardness, color)
        {
            this.facet = facet;
            this.dopColor = dopColor;
        }

        public Diamond(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                Weight = Convert.ToInt32(strs[0]);
                Price = Convert.ToInt32(strs[1]);
                Hardness = Convert.ToInt32(strs[2]);
                ColorStone = Color.FromName(strs[3]);
                facet = Convert.ToBoolean(strs[4]);
                dopColor = Color.FromName(strs[5]);
            }
        }

        protected override void drawAdamant(Graphics g)
        {
            base.drawAdamant(g);

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

        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public override string getInfo()
        {
            return Weight + ";" + Price + ";" + Hardness + ";" + ColorStone.Name + ";" + facet + ";" + dopColor.Name;
        }

        public int CompareTo(Diamond other)
        {
            var res = (this is Adamant).CompareTo(other is Adamant);
            if (res != 0)
            {
                return res;
            }
            if (facet != other.facet)
            {
                return facet.CompareTo(other.facet);
            }
            if (dopColor != other.dopColor)
            {
                return dopColor.Name.CompareTo(other.facet);
            }
            return 0;
        }

        public bool Equals(Diamond other)
        {
            var res = (this is Adamant).Equals(other is Adamant);
            if (!res)
            {
                return res;
            }
            if (facet != other.facet)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;

            }
            Diamond DiamondObj = obj as Diamond;
            if (DiamondObj == null)
            {
                return false;
            }
            else
            {
                return Equals(DiamondObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
