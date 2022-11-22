using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t          Calculator");
            Console.WriteLine("\t\t\t\t\t----------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Remainder");
            Console.WriteLine("6.Square Root"); 
            Console.WriteLine("7.Round");
            Console.WriteLine("8.Euler(e)");
            Console.WriteLine("9.PI");
            Console.WriteLine("10.Log");
            Console.WriteLine("11.Log10");
            Console.WriteLine("12.Pow");
            Console.WriteLine("13.sin");
            Console.WriteLine("14.sinh");
            Console.WriteLine("15.cos");
            Console.WriteLine("16.cosh");
            Console.WriteLine("17.tan");
            Console.WriteLine("18.tanh");
            Console.WriteLine("19.Cube Root");



            Console.Write("Enter Choice(1-19):");
            double ch = Int32.Parse(Console.ReadLine());
  
            double a, b, c;

            if (ch == 1)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Num:");
                b = Convert.ToDouble(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Sum = {0}", c);
            }

             if (ch == 2)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Num:");
                b = Convert.ToDouble(Console.ReadLine());
                c = a - b;
                Console.WriteLine("Difference = {0}", c);
            }

             if (ch == 3)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Num:");
                b = Convert.ToDouble(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Product = {0}", c);
            }

             if (ch == 4)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Num:");
                b = Convert.ToDouble(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Quotient = {0}", c);
            }

             if (ch == 5)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Num:");
                b = Convert.ToDouble(Console.ReadLine());
                c = a % b;
                Console.WriteLine("Remainder = {0}", c);
            }
             if (ch == 6)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Sqrt(a) ;
                Console.WriteLine("Square Root = {0}", c);
            }

             if (ch == 7)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Round(a);
                Console.WriteLine("Round off = {0}", c);

            }

             if (ch == 8)
            {
                
                c = Math.E ;
                Console.WriteLine("e = {0}", c);

            }

             if (ch == 9)
            {
               
                c = Math.PI;
                Console.WriteLine("PI = {0}", c);

            }

             if (ch == 10)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Log(a);
                Console.WriteLine("log = {0}", c);

            }

             if (ch == 11)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Log10(a);
                Console.WriteLine("log10 of number = {0}", c);

            }

            if (ch == 12)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Pow(a,2);
                Console.WriteLine("Power = {0}", c);

            }

             if (ch == 13)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Sin(a);
                Console.WriteLine("Sine = {0}", c);

            }

             if (ch == 14)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Sinh(a);
                Console.WriteLine("Sinh = {0}", c);

            }

             if (ch == 15)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Cos(a);
                Console.WriteLine("Cosine = {0}", c);

            }

             if (ch == 16)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Cosh(a);
                Console.WriteLine("Cosh = {0}", c);

            }

             if (ch == 17)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Tan(a);
                Console.WriteLine("Tangent = {0}", c);

            }

             if (ch == 18)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Tanh(a);
                Console.WriteLine("Tangenth = {0}", c);

            }

              if (ch == 19)
            {
                Console.Write("Enter First Num:");
                a = Convert.ToDouble(Console.ReadLine());
                c = Math.Pow(a, (1.0 / 3.0));
                Console.WriteLine("Cube Root = {0}", c);

            }
            Console.WriteLine("Press any key to exit");

            
            Console.ReadKey();

        }
    }
}
