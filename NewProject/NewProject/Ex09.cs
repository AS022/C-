using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * In C# there are 4 ways of passing the parameters into a function
 * DEfault in  pass by value
 * Pass by reference
 * Pass by out 
 * Params
 */
namespace NewProject
{
    class Ex09
    {
        static void simpleFunc(int arg)
        {
            Console.WriteLine("the passed value is :-" + arg);
            arg += 123;
            //the parameer is local to the fucn.Any changes made to the paramter is not reflected after the function
            //returns
        }
        /* private static void passByrefDemo()
         {

         }*/
        static void refFunc(int value)
        {
            Console.WriteLine("the passed value is :-" + value);
            value += 123;
            //the parameer is local to the fucn.Any changes made to the paramter is not reflected after the function
            //returns
        }

        static void passByref()
        {
            int value = 432;
            refFunc(ref value);
            Console.WriteLine("The value after the function returns:" + value);

        }
        static void passByvalue()
        {
            int value = 123;
            simpleFunc(value);
            Console.WriteLine("The value after the function returns:" + value);
        }

        static void Main(string[] args)
        {
            /*passByvalue()*/
            /*passByrefDemo();*/
            int v1 = 123, v2 = 234;
            double addNo = 0, subNo = 0;
            getArithmaeticValues(v1, v2, ref addNo, ref subNo);
            Console.WriteLine("The added value:" + addNo);
            Console.WriteLine("The subtracted value:" + subNo);
        }

        private static void getArithmaeticValues(int v1, int v2, ref double add, ref double sub)
        {
            add = v1 + v2;
            sub = v1 + v2;
        }
    }
}

