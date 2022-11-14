using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    internal class VovelOrConsonent
    {
        public void checkVowel()
        {

            Console.Write("Enter Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + ":is a Vowel");
            }
            else
            {
                Console.WriteLine(ch + ":is a Consonant");
            }

        }
    }
}