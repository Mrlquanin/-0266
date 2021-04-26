using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 2;
            Console.WriteLine("输入一个数字");
            int a = Convert.ToInt32(Console.ReadLine());
           while(a>=2) {
                if (a % b == 0)


                {
                    if (a == b)
                    {
                        Console.Write(b + "\t");
                    }

                    else
                    {
                        Console.Write(b+"\t");
                        
                    }
                    a = a / b;
                   

                }
                if (a % b != 0)
                    b++;

            }


        }
        
    }
}
