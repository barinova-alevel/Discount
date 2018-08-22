using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiscount
{
    public class Truck: CarBase
    {
        public Truck() {
            Discount = 30;
            CarType = "Truck";
        }
        //private double Capacity;
        //private bool Insurance;
        //private double Mileage; 
    } 
}
