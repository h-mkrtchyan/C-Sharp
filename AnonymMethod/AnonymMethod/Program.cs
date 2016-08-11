using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a third number");
            int k = Convert.ToInt32(Console.ReadLine());

            MyDelegate del = (a, b, c) => (double)(a + b + c) / 3;
            Console.WriteLine("Average is: {0:##.###}", del(i, j, k));

            string f = "Hakob";
            string ff = " Mkrtchyan";

            MyDelegate2 dell = (a, c) => (a + c);
            Console.WriteLine(dell(f, ff));
            dell.Invoke?.del = 
            
        }

        private delegate double MyDelegate(int a, int b, int c);

        private delegate string MyDelegate2(string a, string b);

        private event MyDelegate del;
    }
}
