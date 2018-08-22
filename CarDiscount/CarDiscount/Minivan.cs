using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiscount
{
    public class Minivan: CarBase
    {
        public Minivan() {
            Discount = DateTime.Now.Month * 2;
            CarType = "Minivan";
        }
        public double AddDiscount;
        public int SeetCount;


    } 
}
