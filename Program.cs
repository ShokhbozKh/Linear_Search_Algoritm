using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            System.Console.WriteLine(LinearSearch(numbers, 5));


        }
        static int LinearSearch(int[] ints, int findNum)
        {
            int result = 0 ;

            for(int i = 0; i < ints.Length; i++)
            {
                if(findNum == ints[i])
                {
                    result = i;
                    break;
                }
                else
                {
                    result = -1;
                }
            }

            return result;
        }
    }
}
