using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"Resources\input.txt");
            string[] result = new string[lines.Length*3];
            int locationInResult = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                foreach (string item in lines[i].Split(' '))
                {
                    result[locationInResult] = item.Trim();
                    locationInResult++;
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }
    }

    class magicChar
    {
        int lowestNumber;
        int highestNumber;
        char desiredCharecter;
        char[] password;

        public magicChar(string range, string letter, string password)
        {
            this.password = password.ToCharArray();
        }
    }
}
