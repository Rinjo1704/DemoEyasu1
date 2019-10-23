using System;

namespace DemoEyasu1
{
    class Program
    {
        
   

        //Test change
        static void Main(string[] args)
            
        {
            Console.WriteLine("Hello World!");

            double x = 34.1;
            double y = 65.9;
            double xy = x + y;

            Console.WriteLine("my double total =" + xy);
            var n = 321.12;
            var m = 854.15;
            var nm = m / n;
            Console.WriteLine("my double total =" + nm);

            var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };

            var result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
                Console.WriteLine(result);


            
        }
    }
}
