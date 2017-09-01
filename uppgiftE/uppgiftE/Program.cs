using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgiftE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett ord i taget och skriv AVSLUTA för att avsluta." );
            string sentence = Console.ReadLine();

            string[] words = new string[100];

            int i = 0;
            while(sentence != "AVSLUTA")
            {
                words[i] = sentence;
                sentence = Console.ReadLine();
                i++;
            }
            Console.WriteLine("Din mening just nu är ");
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(words[j]+ " ");
            }
        }
    }
}
