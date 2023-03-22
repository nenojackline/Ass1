using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic operators
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter operator: ");
            string operators = Console.ReadLine();

            Console.Write("Enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (operators == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (operators == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (operators == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (operators == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (operators == "%")
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator ");
            }
            //increment operator

            {
                int age = 30;
                age++;
                Console.WriteLine(age);
            }

            //Decrement operator

            {
                int y = 10;
                y--;
                Console.WriteLine(y);
            }

            //logical operators
            bool isMale = true;
            bool isTall = false;

            if (isMale && !isTall)
            {
                Console.WriteLine("you are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("you are not a male but tall ");
            }
            else
            {
                Console.WriteLine("you are either not male or not tall or both");
            }

            //OR operator
            {
                int alpha = 20;
                Console.WriteLine(alpha > 3 || alpha < 4);
            }


            //comparison operators

            {
                Console.WriteLine(Max(13, 180, 100));

                Console.ReadLine();
            }


            int Max(int Num1, int Num2, int Num3)
            {
                int result;
                if (Num1 >= Num2 && Num1 >= Num3)
                {
                    result = Num1;
                }
                else if (Num2 >= Num1 && Num2 >= Num3)
                {
                    result = Num2;
                }
                else
                {
                    result = Num3;
                }


                return result;
            }

            Console.WriteLine("10 == 10: " + (10 == 10));
            Console.WriteLine("10 != 10: " + (10 != 10));
            Console.WriteLine("10 < 20: " + (10 < 20));
            Console.WriteLine("10 > 20: " + (10 > 20));
            Console.WriteLine("10 <= 20: " + (10 <= 20));
            Console.WriteLine("10 >= 20: " + (10 >= 20));



            //Assignment operators
            int a = 21;
            int c;
            c = a;
            Console.WriteLine("Line 1 - =  Value of c = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += Value of c = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -=  Value of c = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *=  Value of c = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /=  Value of c = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  Value of c = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - <<=  Value of c = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - >>=  Value of c = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &=  Value of c = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^=  Value of c = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |=  Value of c = {0}", c);

            //Math Class


            double baseNumber, powerNumber;

            Console.Write("Enter base number :");
            baseNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent number :");
            powerNumber = Convert.ToDouble(Console.ReadLine());

            double returnNumber = Math.Pow(baseNumber, powerNumber);
            Console.WriteLine("{0}^{1} = {2}", baseNumber, powerNumber, returnNumber);

            double squrt_value = Math.Sqrt(64);

            Console.WriteLine("Sqrt value = " + squrt_value);


            double e = Math.E;


            Console.WriteLine("Math.E = " + e);


            double pi_value = Math.PI;


            Console.WriteLine("Math.PI = " + pi_value);

            double min_value = Math.Min(5, 10);

            Console.WriteLine("Min value =" + min_value);

            Console.ReadLine();
        }
    }
}
