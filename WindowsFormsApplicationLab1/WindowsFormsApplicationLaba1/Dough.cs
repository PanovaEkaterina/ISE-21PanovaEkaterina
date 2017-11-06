using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class Dough
    {
        private Egg[] eggs;
        private Sugar sugar;
        private Flour flour;
       
        public void Init(int countegg)
        {
            eggs = new Egg[countegg];
        }

        public void AddEgg(Egg e)
        {
            for (int i = 0; i < eggs.Length; i++)
            {
                if (eggs[i] == null)
                {
                    eggs[i] = e;
                    return;
                }
            }
        }

        public void AddSugar(Sugar s)
        {
            sugar = s;
            sugar.Count_Sugar = true;
        }

        public void AddFlour(Flour f)
        {
            flour = f;
            flour.Count_Flour = true;
        }

        public bool Check()
        {
            if (eggs == null)
            {
                return false;
            }
            if (eggs.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Have_shell_egg)
                {
                    return false;
                }
            }

            if (eggs.Length < 1) return false;

            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i] == null) return false;
            }

            if (!sugar.Count_Sugar) return false;

            if (!flour.Count_Flour) return false;

            return true;
        }
    }            
 }

