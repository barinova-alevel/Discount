using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiscount
{
    public class CarBase
    {
        public CarBase() {
            CarType = "BaseCar";
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public double SalePrice { get; set; }
        public string CarType { get; protected set; }
    }

    public class CarList
    {
        CarBase[] carList = new CarBase[8];

        public void CarInitial()
        {

            Truck truck = new Truck();
            truck.Name = "Lexus";
            truck.Color = "blue";
            truck.Price = 50;
            carList[0] = truck;

            CarBase carBase = new CarBase();
            carBase.Name = "Lanos";
            carBase.Color = "red";
            carBase.Price = 10;
            carBase.Discount = 5;
            carList[1] = carBase;

            carBase  = new CarBase();
            carBase.Name = "Nissan";
            carBase.Color = "red";
            carBase.Price = 15;
            carBase.Discount = 5;
            carList[2] = carBase;

            truck = new Truck();
            truck.Name = "Opel";
            truck.Color = "grey";
            truck.Price = 20;
            carList[3] = truck;

            Minivan minivan = new Minivan();
            minivan.Name = "Sens";
            minivan.Color = "white";
            minivan.Price = 5;
            carList[4] = minivan;



            minivan = new Minivan();
            minivan.Name = "Mersedes";
            minivan.Color = "black";
            minivan.Price = 100;
            carList[5] = minivan;

            minivan = new Minivan();
            minivan.Name = "Kia";
            minivan.Color = "yellow";
            minivan.Price = 15;
            carList[6] = minivan;

            carBase = new CarBase();
            carBase.Name = "BMV";
            carBase.Color = "grey";
            carBase.Price = 35;
            carBase.Discount = 10;
            carList[7] = carBase;
        }
        public void FillSalesDiscount()
        {
            for (int i = 0; i < carList.Length; i++)
            {
                Console.WriteLine("Car Type: {3}, Name {0}, Price {1}, Discount {2}", carList[i].Name, carList[i].Price, carList[i].Discount, carList[i].CarType);
                carList[i].SalePrice = GetSalePrice(carList[i].Price, carList[i].Discount);
            }
        }

        public double GetSalePrice(int price,int discount)
        {
            double salePrice = price - ((float)(price * discount) / 100);
            Console.WriteLine("Sale Price {0}", salePrice);
            return salePrice;
        }
    }

   

}

