using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            SomeClass cl = new SomeClass();

            counter.OnCount += () =>  //call anonim method
            {
                Console.WriteLine("event raized");
            };

            counter.OnCount += Handler;

            counter.OnCount += cl.Print1;
            counter.OnCount += cl.Print2;

            counter.Start();

            Console.ReadLine();

            MyDeligate.DoSomething del;
            del = new MyDeligate().MyDo;
            del = del + NextMeth;
            del.Invoke();
            Console.ReadLine();

        }
        public static void Handler()
        {
            Console.WriteLine("jklk");
        }
        public static void NextMeth()
        {
            Console.WriteLine("8888");
        }



    }
    public class MyDeligate
    {
        public delegate void DoSomething();
        public void MyDo()
        {
            Console.WriteLine("----");
        }

        Counter counter = new Counter();
    }
    


}

