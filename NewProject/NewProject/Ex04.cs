using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Ex04
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("ENTER THE PARTICIPANT'S name please");
                names[i] = Console.ReadLine();


            }
            foreach (string name in names)
                Console.WriteLine(name);

            int[] data = { 234, 345, 345, 35, 345, 5 };
            foreach (int val in data)
                Console.WriteLine(val);

            int[,] TwoDimension = new int[,]
            {
                {2, 3, 4},
                {2, 4, 5},
                {4, 5, 6}
            }; //3x3 array

            Console.WriteLine("the number of dimensions:" + TwoDimension.Rank);
            Console.WriteLine("the length of the first dimension:" + TwoDimension.GetLength(0));
            Console.WriteLine("the length of the second dimension:" + TwoDimension.GetLength(1));

            //to get into the matrix form
            for (int i = 0; i < TwoDimension.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDimension.GetLength(0); j++)
                {
                    Console.WriteLine(TwoDimension[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[][] School = new int[5][];
            School[0] = new int[] { 45, 55, 66, 56, 44, 23 };
            School[1] = new int[] { 45, 55, 78 };
            School[2]= new int[] { 90,98,78,78,55};
            School[3]=new int[] { 45, 23 };
            School[4]= new int[] { 45, 44, 23 };

            //Each row is an independent array..

            for(int i=0;i<School.Length;i++)
            {
                foreach (int no in School[i])
                    Console.Write(no + " ");
                Console.WriteLine();
            }

        }
    }
}
    

