using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba2
{
    class ParkingIndexOutOfRangeException:Exception
    {
        public ParkingIndexOutOfRangeException():
            base("В магазине нет камня по такому индексу"){}
    }
}
