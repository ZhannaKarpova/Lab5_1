using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    int n;
                    Console.WriteLine("введите семь чисел  n");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[6];
                    float summa = 0;
                    for (int i=0;i<array.Length; i++)
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                        summa += array[i];
                    }
                    Console.Write("среднее значение:"+summa/6);
                    Console.WriteLine();


                }

                Console.ReadKey();


            }

        }
    }
}

