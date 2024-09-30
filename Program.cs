// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program 
    {
        static void Main (string[] args) 
        {

            int x =20, y = 40, z = 60;

            //INTEGER
            int age = -23;
            Console.WriteLine("Hello World");
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 900000000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);


            double negative = -55.23D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 4.566F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            age = 10;

            Console.ReadLine();
        }
    }
}
