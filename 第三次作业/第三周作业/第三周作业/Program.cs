using System;

namespace 第三周作业
{
    abstract class fun{
        public abstract double  area();
        public abstract bool islegal();
 }

    class triangle : fun { 


        private double a;
        private double b;
        private double c;
      public triangle(double a, double b, double c) {
            this.a = a;this.b = b; this.c = c;

        
        }
       public override double area() {
            double p = (a + b + c) / 2;
            double s= Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        public override bool islegal()
        {
            if (a>0 && b>0 && c>0 && a + b > c && a + c > b && b + c > a )
             return true; 
            else return false;
        }



    }
    class rectangle : fun
    {


        private double a;
        private double b;
        
        public rectangle(double a, double b)
        {
            this.a = a; this.b = b; 


        }
        public override double area()
        {
            double s = a * b;
            return s;
        }

        public override bool islegal()
        {
            if (a > 0 && b > 0) return true;
            else return false;
           
        }



    }

    class square : fun
    {


        private double a;
        private double b;

        public square(double a)
        {
            this.a = a; 

        }
        public override double area()
        {
            double s = a * a;
            return s;
        }

        public override bool islegal()
        {
            if (a > 0) return true;
            else return false;
        }



    }


    class simplefactory
    {
        private  static double All_area = 0;
        
        public  static double Get_All() { return All_area; }
        
        public static void factory(int type)
        {
            Random ran = new Random();
            if (type == 1)
            { 
                triangle t = new triangle(ran.Next(0,10),ran.Next(0,10),ran.Next(0,10));
                if (t.islegal()) All_area = All_area + t.area();
                else Console.WriteLine("生成了一个错误的三角形");
            }
            else if (type == 2)
            {
               
                rectangle r = new rectangle(ran.Next(10), ran.Next(10));
                if (r.islegal()) All_area += r.area();
                else Console.WriteLine("生成了一个错误的长方形");
            }
            else
            {
               
                square s = new square(ran.Next(10));
                if (s.islegal()) All_area += s.area();
                else Console.WriteLine("生成了一个错误的正方形");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            for (int i = 1; i <= 10; i++)
            { int a = ran.Next(3) + 1;
                simplefactory.factory(a);
               
            }
            Console.WriteLine($"总面积是{simplefactory.Get_All()}");
          
        }
    }
}
