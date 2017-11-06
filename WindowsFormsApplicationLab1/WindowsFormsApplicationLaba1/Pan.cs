using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class Pan
    {
        private Apple[] apples;
        private Dough d;

        private int ready = 0;
        public int Ready { get { return ready; } }

        public void Init(int countapple)
        {
            apples = new Apple[countapple];
        }

        public void AddApple(Apple a)
        {
            for (int i = 0; i < apples.Length; i++)
            {
                if (apples[i] == null)
                {
                    apples[i] = a;
                    return;
                }
            }
        }

        public void AddDough(Dough dd)
        {
            if (dd.Check())
            {
                d = dd;
            }
        }

        public bool Check()
        {
            if (apples == null)
            {
                return false;
            }
            if (apples.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < apples.Length; ++i)
            {
                if (apples[i] == null) return false;
            }
            if (apples.Length < 1) return false;
            for (int i = 0; i < apples.Length; ++i)
            {
                if (!apples[i].Dirty)
                {
                    if (apples[i].Have_skin_apple)
                    {
                        return false;
                    }
                }
                else return false;
            }
            if (d == null)
            {
                return false;
            }       
            return true;
        }

        public bool IsReadyPan()
        {
            if (apples == null)
            {
                return false;
            }
            if (apples.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < apples.Length; ++i)
            {
                if (!apples[i].Dirty)
                {
                    if (apples[i].Have_skin_apple)
                    {
                        return false;
                    }
                }
                else return false;
            }

            if (apples.Length < 1) return false;
            for (int i = 0; i < apples.Length; ++i)
            {
                if (apples[i] == null) return false;
            }
            if (d == null)
            {
                return false;
            }
            return true;
        }

        public void Cook()
        {
            if (Check())
            {
                if (Ready < 10)
                {
                    ready++;
                }
            }
            else return;

        }
    }
}
