using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] studentMarks = new int[3][];

            Console.WriteLine("=== Student Marks Entry ===");

            for (int i = 0; i < studentMarks.Length; i++)
            {
               
                Console.Write($"\nEnter the number of subjects for Student {i + 1}: ");
                int subjectCount = Convert.ToInt32(Console.ReadLine());

                studentMarks[i] = new int[subjectCount];

                
                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write($"  Enter marks for Subject {j + 1}: ");
                    studentMarks[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < studentMarks.Length; i++)
            {
                int total = 0;
                int subjectCount = studentMarks[i].Length;

                
                for (int j = 0; j < subjectCount; j++)
                {
                    total += studentMarks[i][j];
                }

                double average = (double)total / subjectCount;

                Console.WriteLine($"--- Student {i + 1} ---");
                Console.WriteLine($"Total Marks: {total}");
                Console.WriteLine($"Average Marks: {average:F2}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}