using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Array
    {
        public void ArrayOutput()
        {
            int[,] arrayOut
                = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 0, 1, 2, 3, 4 }, { 10, 11, 12, 13, 14 } };
            System.Console.WriteLine(arrayOut[0, 0]);
        }
             
    }
}
