using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            CarList baseCar = new CarList();
            baseCar.CarInitial();
            baseCar.FillSalesDiscount();
            Console.ReadKey();
        }
    }
}
