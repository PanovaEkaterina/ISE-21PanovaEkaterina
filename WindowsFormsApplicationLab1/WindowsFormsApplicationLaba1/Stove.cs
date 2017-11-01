using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class Stove
    {
        private Pan pan;

        private bool state = false;
        public bool State { set { state = value; } get { return state; } }

        public Pan Pan { set { pan = value; } get { return pan; } }

        public void Cook()
        {
            if (State)
            {
                while (!pan.IsReadyPan())
                {
                    pan.Cook();
                }
            }
        }
    }
}
