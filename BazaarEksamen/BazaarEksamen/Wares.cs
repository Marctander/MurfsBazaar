using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BazaarEksamen
{
    class Wares
    {
        public static Wares WareObject = new Wares();
        //private int testWare;

        // public int TestWare { get; set; }
        // {
        // get { return testWare; }
        //set { testWare = value; }
        //}

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
            //lock (WareObject)
            // {
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
                //Console.ReadLine();
            }
            //}

        }

        /*public static void Sold()
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5 };
            for (int i = 1; i < 5; i++)
            {
                Wares sellWare = new Wares();
                sellWare.TestWare = i;
                Console.WriteLine("Bazaar puts their item #" + i + " for sale");
            }
        }

       public static void SellWares()
        {
            Console.WriteLine("{0} buys item: #" + i, Thread.CurrentThread.Name);
        }*/
    }
}
