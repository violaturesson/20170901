using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgiftA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening.");
            string s = Console.ReadLine();

            string[] words = s.Split(' ');

            Console.WriteLine("Antal ord är: "+ words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
                Console.WriteLine("("+words[i].Length+")");
            }
        }
    }
}
