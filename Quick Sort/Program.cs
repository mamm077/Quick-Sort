using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quick_Sort
{
    class Program
    {
        static double[] Array;
        static void Main(string[] args)
        {
            bool isNumber = true;
            char[] delimiter = { ' ' };
            do
            {
                Console.Write("Input : ");
                string input = Console.ReadLine();
                string[] splitData = input.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
                Array = new double[splitData.Length];
                for (int i = 0; i < splitData.Length; i++)
			    {
			        isNumber = double.TryParse(splitData[i],out Array[i]);
                    if(!isNumber)
                    {
                        Console.WriteLine("Error, there is not number.");
                        break;
                    }
			    }

            }while(!isNumber);
            if (Array.Length > 0)
            {
                QuickSort(0, Array.Length-1);
            }

            Console.Write("Output : ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i].ToString()+" ");
            }

            Console.ReadKey();
        }

        static void QuickSort(int p, int r)
        {
            if (p < r)
            {
                int q = Partition(p, r);
                QuickSort(p, q - 1);
                QuickSort(q + 1, r);
            }
        }

        static int Partition(int p, int r)
        {
            double x = Array[r];
            int i = p - 1;
                for (int j = p; j < r ; j++)
                {
                    if (Array[j] <= x)
                    {
                        i = i + 1;
                        Exchange(i, j);
                    }
                }
                Exchange(i + 1, r);
            return i + 1;
        }

        static void Exchange(int a, int b)
        {
            double temp = Array[a];
            Array[a] = Array[b];
            Array[b] = temp;
        }
    }
}
