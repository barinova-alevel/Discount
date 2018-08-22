using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatExample
{
    class Counter
    {
        public delegate void MethodToCount();

        public event MethodToCount OnCount;

        public void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 99)
                    OnCount(); //invoke
            }
        }
    }
}
