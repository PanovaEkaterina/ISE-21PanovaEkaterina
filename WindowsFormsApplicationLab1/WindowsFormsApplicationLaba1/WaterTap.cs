using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class WaterTap
    {
        private bool open = false;
        public bool Open { set { open = value; } get { return open; } }

        public void Wash(Apple apple)
        {
            if (Open)
            {
                apple.Dirty = false;
            }
        }
    }
}
