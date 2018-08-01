using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiscount
{
    public struct CarBase
    {
        public string Name;
        public string Color;
        public int Price;
        public int Discount;
        public double SalePrice;
    }

    public class CarList
    {
        CarBase[] carList = new CarBase[8];

        public void CarInitial()
        {
            

            carList[0].Name = "Lexus";
            carList[0].Color = "blue";
            carList[0].Price = 50;
            carList[0].Discount = 10;

            carList[1].Name = "Lanos";
            carList[1].Color = "red";
            carList[1].Price = 10;
            carList[1].Discount =5;

            carList[2].Name = "Nissan";
            carList[2].Color = "red";
            carList[2].Price = 15;
            carList[2].Discount = 5;

            carList[3].Name = "Opel";
            carList[3].Color = "grey";
            carList[3].Price = 20;
            carList[3].Discount = 3;

            carList[4].Name = "Sens";
            carList[4].Color = "white";
            carList[4].Price = 5;
            carList[4].Discount = 30;

            carList[5].Name = "Mersedes";
            carList[5].Color = "black";
            carList[5].Price = 100;
            carList[5].Discount = 10;

            carList[6].Name = "Kia";
            carList[6].Color = "yellow";
            carList[6].Price = 15;
            carList[6].Discount = 0;

            carList[7].Name = "BMV";
            carList[7].Color = "grey";
            carList[7].Price = 35;
            carList[7].Discount = 10;
            

        }
        public void FillSalesDiscount()
        {
            for (int i = 0; i < carList.Length; i++)
            {
                Console.WriteLine("Name {0}, Price {1}, Discount {2}", carList[i].Name, carList[i].Price, carList[i].Discount);
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

