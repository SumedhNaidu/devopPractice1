using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int [] { 1,2,3,4 };
            arr[1] = new int[] { 5, 6, 7 };
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("{ ");
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.Write(arr[i][j]+ " ");
                }
                Console.WriteLine(" }");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
