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
            List<magicChar> result = new List<magicChar>();
            //int locationInResult = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] arrayFromLine = lines[i].Split(' ');
                result.Add(new magicChar(arrayFromLine[0], arrayFromLine[1], arrayFromLine[2]));
                //locationInResult++;
            }

            foreach (magicChar item in result)
            {
                /*Console.Write(item.getLowest());
                Console.WriteLine(", " + item.getHighest());
                Console.WriteLine(item.getChar());
                Console.WriteLine(item.getPass());
                */
                if (!item.isAllowed())
                {
                    Console.Write(item.getLowest());
                    Console.WriteLine(", " + item.getHighest());
                    Console.WriteLine(item.getChar());
                    Console.WriteLine(item.getPass());
                }
            }
            Console.ReadLine();
        }
    }

    class magicChar
    {
        int lowestNumber;
        int highestNumber;
        char desiredCharecter;
        string password;

        public magicChar(string range, string letter, string password)
        {
            this.password = password;
            string[] rangeSTR = range.Split('-');
            lowestNumber = Convert.ToInt32(rangeSTR[0]);
            highestNumber = Convert.ToInt32(rangeSTR[1]);
            desiredCharecter = letter.ToCharArray()[0];
        }
        
        public int getLowest()
        {
            return lowestNumber;
        }
        public int getHighest()
        {
            return highestNumber;
        }
        public string getPass()
        {
            return Convert.ToString(password);
        }
        public char getChar()
        {
            return desiredCharecter;
        }

        public bool isAllowed()
        {
            int amountOfDesiredLetter = 0;
            foreach (char item in password)
            {
                if (item == desiredCharecter)
                {
                    amountOfDesiredLetter++;
                }
            }
            if (amountOfDesiredLetter > lowestNumber && amountOfDesiredLetter < highestNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
