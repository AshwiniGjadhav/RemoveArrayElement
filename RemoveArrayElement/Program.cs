using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveArrayElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 3, 4, 5, 6, 7, 7, 2, 1 };
            int n, i;

            Console.WriteLine("Enter the want to remove");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    arr[i] = 0;
                }

            }
            foreach (var j in arr)
            {
                Console.WriteLine(j);
            }
        }
    }
}
