using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eksamen
{
    class Wares
    {
        public static Wares WareObject = new Wares();


        private void Ware(int wareToPrint)
        {
            Console.WriteLine("Bazaar puts their item #" + wareToPrint + " for sale");
            Console.WriteLine("{0} buys item: #" + wareToPrint, Thread.CurrentThread.Name);
            //code to print document
            Thread.Sleep(TimeSpan.FromSeconds(1));

        }

        public static void MakeWare()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int y = 1; y < numbers.Length; y++)
                {
                    lock (WareObject)
                    {
                        if (y == i)
                        {
                            WareObject.Ware(i);
                            break;
                        }
                    }
                }

            }

        }
    }
}