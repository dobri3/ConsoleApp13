using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] array = new int[5, 5];

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10,20);
                    Console.Write($"{array[i,j]} "  );
                }
                Console.WriteLine();
            }

            int[] utilArray = new int[5];

            for (int i = 0;i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        utilArray[i] = array[i, j];
                    }
                    
                }
            }

            Console.WriteLine("Значение главной диагонали");

            foreach (var aTest in utilArray)
            {
                Console.Write($"{aTest} ");
            }

            int sum = 0;

            

            for (int i = 0; i < utilArray.Length; i++)
            {
                sum += utilArray[i];    
            }

            Console.WriteLine($"Сумма элементов главной диагонали = {sum}");

            array[4,4] = sum;

            Console.WriteLine("Измененный массив");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }



            Thread.Sleep(5000);
            

        }
    }
}
