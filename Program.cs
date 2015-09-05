using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            long sum1 = 0;
            long sum2 = 0;

            for (int i = 0; i < t; i++)
            {
                String elements = Console.ReadLine();
                String[] split_elements1 = elements.Split(' ');
                String[] split_elements2 = elements.Split(' ');
                sum1 += Convert.ToInt32(split_elements1[i]);
                sum2 += Convert.ToInt32(split_elements2[t-1-i]);
                
            }
            long sum = Math.Abs(sum1 - sum2);
            Console.WriteLine(sum);
            Console.ReadLine();
            
        }
    }
}
