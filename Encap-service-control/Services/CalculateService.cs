using Encap_service_control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encap_service_control.Services
{
    internal class CalculateService
    {
        public void Calculation(double num1,double num2)
        {
            double result = 0;

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter second number :");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("choose one :");
            Console.WriteLine(" + : Add");
            Console.WriteLine(" - : Subtract");
            Console.WriteLine("* : Multipl");
            Console.WriteLine("/ : Divide");


            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = " + result);
                    break;

                default:
                    Console.WriteLine("Please enter numbers again");
                    break;
            }
        }
    }
}
