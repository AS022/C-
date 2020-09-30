
 using System;
using System.ComponentModel;

namespace NewProject
    {
        class Ex02
        {
            static void Main(string[] args)
            {
                int value = 123;
                Console.WriteLine("the value is" + value);

                double dVal = 231.345;
                Console.WriteLine("The double value is" + dVal);

                int bigInt = int.MaxValue;
                Console.WriteLine("The max value of int is" + bigInt);
                Console.WriteLine("The range of int is {0} to {1}", int.MinValue, int.MaxValue);

                float f = 3.3f;
                Console.WriteLine("The max value of float is" + f);
                Console.WriteLine("The range of float is {0} to {1}", float.MinValue, float.MaxValue);

                decimal d = 1;
                Console.WriteLine("The max value of decimal is" + d);
                Console.WriteLine("The range of decimal is {0} to {1}", decimal.MinValue, decimal.MaxValue);

                long l = 1;
                Console.WriteLine("The max value of decimal is" + l);
                Console.WriteLine("The range of decimal is {0} to {1}", long.MinValue, long.MaxValue);


            }
        }
    }

