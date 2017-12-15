using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba2
{
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException():
            base("В магазине уже есть такой камень") { }
    }
}
