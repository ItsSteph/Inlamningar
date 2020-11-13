using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Data;

namespace Inlamning01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            string FirstNumber = Console.ReadLine();
            int sFirstNumber = Convert.ToInt32(FirstNumber);
            Console.WriteLine("Please enter the first operator");
            string FirstOp = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string SecondNumber = Console.ReadLine();
            int sSecondNumber = Convert.ToInt32(SecondNumber);

            while (FirstOp == "+")
            {
                Console.WriteLine("Please enter the second operator");
                string SecondOp = Console.ReadLine();
                Console.WriteLine("Please enter the third number");
                string ThirdNumber = Console.ReadLine();
                int sThirdNumber = Convert.ToInt32(ThirdNumber);

                if (SecondOp == "+")
                {
                    int result = sFirstNumber + sSecondNumber + sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }
                else if (SecondOp == "-")
                {
                    int result = sFirstNumber + sSecondNumber - sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "*")
                {
                    int result = sFirstNumber + sSecondNumber * sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "/")
                {
                    int result = sFirstNumber + sSecondNumber / sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }

            }
            while (FirstOp == "-")
            {
                
                Console.WriteLine("Please enter the second operator");
                string SecondOp = Console.ReadLine();
                Console.WriteLine("Please enter the third number");
                string ThirdNumber = Console.ReadLine();
                int sThirdNumber = Convert.ToInt32(ThirdNumber);

                if (SecondOp == "+")
                {
                    int result = sFirstNumber - sSecondNumber + sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }
                else if (SecondOp == "-")
                {
                    int result = sFirstNumber - sSecondNumber - sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "*")
                {
                    int result = sFirstNumber - (sSecondNumber * sThirdNumber);
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "/")
                {
                    int result = sFirstNumber - (sSecondNumber / sThirdNumber);
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }
            }
            while (FirstOp == "*")
            {

                Console.WriteLine("Please enter the second operator");
                string SecondOp = Console.ReadLine();
                Console.WriteLine("Please enter the third number");
                string ThirdNumber = Console.ReadLine();
                int sThirdNumber = Convert.ToInt32(ThirdNumber);

                if (SecondOp == "+")
                {
                    int result = sFirstNumber * sSecondNumber + sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }
                else if (SecondOp == "-")
                {
                    int result = sFirstNumber * sSecondNumber - sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "*")
                {
                    int result = sFirstNumber * sSecondNumber * sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "/")
                {
                    int result = sFirstNumber * sSecondNumber / sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }
            }

            while (FirstOp == "/")
            {
                if (sSecondNumber > sFirstNumber)
                {
                    Console.WriteLine("Calculation not possible. Please try again....");
                }

                Console.WriteLine("Please enter the second operator");
                string SecondOp = Console.ReadLine();
                Console.WriteLine("Please enter the third number");
                string ThirdNumber = Console.ReadLine();
                int sThirdNumber = Convert.ToInt32(ThirdNumber);

                if (SecondOp == "+")
                {
                    int result = sFirstNumber / sSecondNumber + sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }
                else if (SecondOp == "-")
                {
                    int result = sFirstNumber / sSecondNumber - sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "*")
                {
                    int result = sFirstNumber / sSecondNumber * sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);
                }
                else if (SecondOp == "/")
                {
                    int result = sFirstNumber / sSecondNumber / sThirdNumber;
                    Console.WriteLine("Result: " + result);
                    Environment.Exit(0);

                }
            }

        }
    }
}