using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 7, 1, 20};
            //array[0] = 3;
            //array[1] = 7;
            //array[2] = 1;
            //array[3] = 20;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;

                    }

                }
                Console.WriteLine(array [i]);

            }
            Console.ReadLine();
        }
    }
}
