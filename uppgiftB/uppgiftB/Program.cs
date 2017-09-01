using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgiftB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            string sentence = Console.ReadLine();
            int j = 0;

            string[] words = sentence.Split(' ');

            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));
            foreach (string s in words)
            {

                Console.WriteLine(words[j]);
                j++;
            }

            j = 0;
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in words)
            {

                Console.WriteLine(words[j]);
                j++;
            }
        }
    }
}
