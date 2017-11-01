using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLab3
{
    interface Stone
    {
        void drawStone(Graphics g);
        void setPosition(int x, int y);
        //void Pay(bool buy); 
        void Wear(bool wear); //ношение украшения
        // метод разбиения камня 
    }
}