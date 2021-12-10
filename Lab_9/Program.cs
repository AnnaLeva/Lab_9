using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                Double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b=");
                Double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Operations:");
                Console.WriteLine("1 - Summ");
                Console.WriteLine("2 - Substraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");


                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        {
                            Console.WriteLine("Result = {0}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Result = {0}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Result = {0}", a * b);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Result = {0:f2}", a / b);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not available!");
            }
            Console.ReadKey();
        }
    }
}