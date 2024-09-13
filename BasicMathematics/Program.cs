using System;

namespace BasicMathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicMaths basicMaths = new BasicMaths();
         

           double result1 = basicMaths.Add(48.9, 45.2);

            double result2 = basicMaths.Add(46, 10);

            Console.WriteLine(result1);

            Console.WriteLine(result2);
        }
    }
}
