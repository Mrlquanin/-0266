using System;

namespace 第二次作业第四题
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4,3];
            a[0,0] = 1; a[1,0] = 2; a[2,0] = 3; a[3,0] = 4;
            a[0,1] = 5; a[1,1] = 1; a[2,1] = 2; a[3,1] = 3;
            a[0,2] = 9; a[1,2] = 5; a[2,2] = 1; a[3,2] = 2;

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 2; j++) {
                    if (a[i,j] == a[i + 1,j + 1])
                    {
                        continue;

                    }
                    else Console.WriteLine("不是托普利茨矩阵");
                
                }
            
            }
            Console.WriteLine("这是一个托普利茨矩阵");
        }
    }
}
