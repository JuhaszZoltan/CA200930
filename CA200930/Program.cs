using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace CA200930
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            //iterációs vezérlőszerkezetek == ciklusok
            //előre meghatározott lépésszámú ("számláló")
            //for - foreach

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] t = new int[100];

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 100);
                Console.Write($"{t[i]} ");
                if ((i + 1) % 10 == 0) Console.Write("\n");
            }

            //"bejáró" ciklus
            string[] s = { "aaa", "bbb", "ccc" };
            foreach (var e in s)
            {
                Console.Write($"{e} ");
            }

            int x = 200;
            for ( ; x < 4000 ; )
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.WriteLine("még");
                if(rnd.Next(100) % 2 == 0) x += 200;
            }


            for (var d = new DateTime(2001, 09, 11);
                d <= DateTime.Now;
                d = d.AddDays(1))
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                if (d.DayOfWeek == DayOfWeek.Sunday)
                    Console.WriteLine(d.ToLongDateString());
            }


            for (double i = 10.4; i < 40; i += 0.2)
            {
                Console.WriteLine(i);
            }

            //feltételes (tesztelő)
            //while - do..while

            Console.ReadKey();
        }
    }
}
