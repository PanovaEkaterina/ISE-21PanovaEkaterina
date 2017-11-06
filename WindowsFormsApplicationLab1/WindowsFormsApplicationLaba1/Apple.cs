using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class Apple
    {
        private bool dirty = true;
        public bool Dirty { set { dirty = value; } get { return dirty; } }

        private bool have_skin_apple = true;
        public bool Have_skin_apple { set { have_skin_apple = value; } get { return have_skin_apple; } }
    }
}
