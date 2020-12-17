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
            for (int i = 0; i < lines.Length; i++)
            {
                string[] arrayFromLine = lines[i].Split(' ');
                result.Add(new magicChar(arrayFromLine[0], arrayFromLine[1], arrayFromLine[2]));
            }

            Part1(result);
            Console.WriteLine("Press enter to continue to part 2");
            Console.ReadLine();
            Console.Clear();
            Part2(result);
            Console.ReadLine();
        }
        public static void Part2(List<magicChar> result)
        {
            int amountOfValidPasswords = 0;
            foreach (magicChar item in result)
            {
                if (item.getPass()[item.getLowest()-1] == item.getChar() && item.getPass()[item.getHighest()-1] != item.getChar())
                {
                    amountOfValidPasswords++;
                }
            }
            Console.WriteLine(amountOfValidPasswords);
        }
        public static void Part1(List<magicChar> result)
        {
            
            int numberOfValidPasswords = 0;
            foreach (magicChar item in result)
            {
                /*Console.Write(item.getLowest());
                Console.WriteLine(", " + item.getHighest());
                Console.WriteLine(item.getChar());
                Console.WriteLine(item.getPass());
                */

                if (item.isAllowed())
                {
                    /*
                    Console.Write(item.getLowest());
                    Console.WriteLine(", " + item.getHighest());
                    Console.WriteLine(item.getChar());
                    Console.WriteLine(item.getPass());
                    */
                    numberOfValidPasswords++;
                }
            }
            Console.WriteLine(numberOfValidPasswords);
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
            if (amountOfDesiredLetter >= lowestNumber && amountOfDesiredLetter <= highestNumber)
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
