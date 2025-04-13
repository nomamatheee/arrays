using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)

        { //a small console app for a teacher to review students' test score

            int sum = 0;
            int highest = 0;
            int lowest=0;
            int[] Marks = { 50, 39, 89, 90, 56 };
            for (int i = 0; i < Marks.Length; i++)
            {
              Console.WriteLine($"Mark= {Marks[i]}");
             
                sum += Marks[i];

                 if( Marks[i] > highest )//looks for the highest mark
                {
                    highest = Marks[i];
                }
                if (Marks[i] < lowest)//looks for the lowest mark
                {
                    lowest = Marks[i];
                }

              

            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Average:");

            double average = (double)sum/ Marks.Length;
            Console.WriteLine(average);
            Console.WriteLine("Highest:");
            Console.WriteLine(highest);
            Console.WriteLine("Lowest");
            Console.WriteLine(lowest);
            Console.ReadLine();


        }
    }
}
