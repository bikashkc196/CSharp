using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balancedFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] userArray = new int[size];

            Console.WriteLine($"Enter {size} integers:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element [{i}]: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n--- Checking Array Balance ---");

            if (IsBalanced(userArray))
            {
                Console.WriteLine("Result: The array is balanced!");
            }
            else
            {
                Console.WriteLine("Result: The array is NOT balanced.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static bool IsBalanced(int[] arr)
        {
            if (arr == null) return false;

            int length = arr.Length;

            if (length % 2 == 0)
            {
                return false;
            }

            int midIndex = length / 2;

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < midIndex; i++)
            {
                leftSum += arr[i];
            }
            for (int i = midIndex + 1; i < length; i++)
            {
                rightSum += arr[i];
            }
            return leftSum == rightSum;
        }
    }
}