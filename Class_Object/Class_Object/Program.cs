using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first digit:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second digit:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);

            Rectangle obj = new Rectangle();
            obj.Show();
            obj.Display();
            obj.multiply(3, 6);
            int div = obj.division(12, 3);
            Console.WriteLine(div);
            Constructor obj1 = new Constructor();
            obj1.sub();
            Console.WriteLine();

        }
    }
    public class Rectangle
    {
        public void Show()
        {
            Console.WriteLine("Show Method");

        }
        public void Display()
        {
            Console.WriteLine("Display Method");
        }

        public void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public int division(int a, int b)
        {
            return a / b;
        }
    }
    public class Constructor
    {
        int x, y;
        public Constructor()
        {
            x = 5;
            y = 6;
        }
        public void sub()
        {
            Console.WriteLine(x - y);
        }

    }
}
