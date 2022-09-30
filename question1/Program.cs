using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eval1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            Console.WriteLine("Please enter 6 nums: ");
            for (int i = 0; i < 6; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = array[0];
            int min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("maximum value is : " + max);
            Console.WriteLine("minimum value is : " + min);
        }
    }

}
