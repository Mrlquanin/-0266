using System;

namespace 第二周作业第二小题
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                int[] a = { 1, 2, 3, 4, 5 };

                int average,min;
                int max = min =  a[0];
               
                int sum = 0;
                 


          
               
               
                for (int i = 0; i < a.Length-1; i++)
                {
                    sum += a[i];
                    if (a[i] > max) max = a[i];
                    if (a[i] < min) min = a[i];
                sum = sum + a[i];
                }
                average = sum / a.Length;
            
                Console.WriteLine("平均数是"+average);
                Console.WriteLine("最大值是"+max);
                Console.WriteLine("最小值是"+min);
                Console.WriteLine("和是"+sum);
            }
    }
}
