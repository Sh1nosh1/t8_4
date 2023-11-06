using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T8_4
{
    internal class Program
    {
        //Task
        //Two sentences are given. Find the total number of letters "n" in them. (Define function to calculate the number of "n "s in a sentence.)

        static int Count(ref string sen_1)
        {
            int count = 0;
            foreach(char n in sen_1)
            {
                if(n == 'н')
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            try
            {
                //Task
                //Two sentences are given. Find the total number of letters "n" in them. (Define function to calculate the number of "n "s in a sentence.)

                Write("Enter the first sentence: ");
                string sen_1 = ReadLine();
                Write("Enter the second sentence: ");
                string sen_2 = ReadLine();

                Write($"Quantity of н: {Count(ref sen_1) + Count(ref sen_2)}");

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
