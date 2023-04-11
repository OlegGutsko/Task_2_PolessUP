using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2. Учитывая массив целых чисел nums и целое число target,
               верните индексы двух чисел так, чтобы они составляли в сумме target.
               Вы можете предположить, что каждый вход будет иметь ровно одно решение,
               и вы не можете использовать один и тот же элемент дважды. 
            */

            const int n = 4;
            int[] nums = new int[n] { 2, 7, 11, 15 };

            int target = 9;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                        Console.WriteLine($"[{i}, {j}]");
                }
            }

            Console.ReadLine();
        }
    }
}

