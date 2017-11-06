using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLab3
{
   public  interface Stone
    {
        void drawStone(Graphics g);
        void setPosition(int x, int y);
        void setMainColor(Color color);
    }
}