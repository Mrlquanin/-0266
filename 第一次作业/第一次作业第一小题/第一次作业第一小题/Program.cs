using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一次作业
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            Console.Write("请输入第一个数字");
            string m = Console.ReadLine();
            int a = Int32.Parse(m); 
            Console.Write("在+ - * / 中选择输入你想用的运算符");
            string s = Console.ReadLine();
            Console.Write("请输入第二个数字");
            string n = Console.ReadLine();
            int b = Int32.Parse(n);
            if (s == "+")
            {
                num = a + b;
            }
            if (s == "-")
            {
                num = a - b;   
            }
            if (s == "*")
            {
                num = a * b;
            }
            if (s == "/")
            {
                num = a / b;
            }
            string D = num.ToString();
            Console.WriteLine("结果是"+num);





        }
    }
}
