using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgiftF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1-21");
            int tal;

            Random slumptal = new Random();
            int tal1 = slumptal.Next(1, 22);

            bool fel = true;
            do
            {
                tal = Convert.ToInt32(Console.ReadLine());

                if (tal1 == tal)
                {
                    Console.WriteLine("Grattis!");
                    fel = false;
                }
            }
            while (fel);
            

        }
    }
}
