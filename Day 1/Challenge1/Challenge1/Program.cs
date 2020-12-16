using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] preNumbers = File.ReadAllLines(@"Rescources\input.txt");
            int[] numbers = new int[preNumbers.Length];
            for (int i = 0; i < preNumbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(preNumbers[i]);
                Console.WriteLine(numbers[i]);
            }
            //-------------------------------------------------------------
            Part1(numbers);
            Console.WriteLine("Press enter to continue to part 2");
            Console.ReadLine();
            Console.Clear();
            Part2(numbers);
            Console.ReadLine();
        }

        public static void Part2(int[] numbers)
        {
            List<int> completed = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 2020)
                        {
                            if (!completed.Contains(numbers[i] * numbers[j] * numbers[k]))
                            {
                                Console.WriteLine(numbers[i] + " + " + numbers[j] + " + " + numbers[k] + " = 2020");
                                Console.WriteLine(numbers[i] + " x " + numbers[j] + " x " + numbers[k] + " = " + numbers[i]*numbers[j]*numbers[k]);
                                completed.Add(numbers[i] * numbers[j] * numbers[k]);
                            }
                        }
                    }
                }
            }
        }

        public static void Part1(int[] numbers)
        {
            List<int> completed = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 2020)
                    {
                        if (!completed.Contains(numbers[i] * numbers[j]))
                        {
                            Console.WriteLine(numbers[i] + " + " + numbers[j] + " = 2020");
                            Console.WriteLine(numbers[i] + " x " + numbers[j] + " = " + numbers[i] * numbers[j]);
                            completed.Add(numbers[i] * numbers[j]);
                        }
                    }
                }
            }
        }
    }
}
