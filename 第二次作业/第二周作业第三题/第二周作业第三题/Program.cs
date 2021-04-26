using System;

namespace 第二周作业第三题
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            for (int i = 0; i < 99; i++) {
                a[i] = i + 2;
            }
           for(int c=2; c<=100;c++) {
                for (int b = 0; b < 99; b++)
                {
                    if (a[b] % c == 0&& a[b]!=c)
                    {
                        a[b] = 0;

                    }
                }
                
            }
            for (int d = 0; d < 99; d++) {
                if (a[d] != 0) {
                    Console.Write(a[d]+"\t");
                }
            } 


        }


        
    }
}
