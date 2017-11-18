using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace Eksamen
{
    class Program : Wares
    {

        static void Main(string[] args)
        {


            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                // You can only point at methods
                // without arguments and that return 
                // nothing
                Thread t = new Thread(new
                    ThreadStart(MakeWare));
                t.Name = "Costumer" + i.ToString();
                threads[i] = t;
            }

            for (int i = 0; i < 5; i++)
            {
                threads[i].Start();
            }

            Console.ReadLine();


            Console.Write("\n\nPress any key to continue ...");
            //Console.ReadKey(true);
        }
    }
}
