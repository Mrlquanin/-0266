using System;

namespace 第四次作业第二题
{


    public delegate void AlarmHandler(object sender);
    public delegate void TickHandler(object sender);

    public class Clock
    {
        public event TickHandler Tick;
        public event AlarmHandler Alarm;
        public string AlarmTime { get; set; }
        public string NowTime { get; set; }

       
     
        public void tick(string time)
        {
            NowTime = time;
            Tick(this);
        }
        public void alarm(string time)
        {
            if (NowTime == AlarmTime)
            {
                
                Alarm(this);
            }
        }
        public void SetAlarm()
        {
            Console.WriteLine("请设定你的闹铃时间：");
            AlarmTime = Console.ReadLine();
            
        }

        
    }

    class show
    {
        public Clock c = new Clock();
        public show()
        {
            c.Alarm += new AlarmHandler(alarm);
            c.Tick += new TickHandler(tick);
        }


        void alarm(object sender)
        {

            Console.WriteLine("叮叮叮！");
            Console.WriteLine("叮叮叮！");
            Console.WriteLine("叮叮叮！");

        }
        void tick(object seder)
        {
            Console.WriteLine("Tick! Nowtime:" + c.NowTime);
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            Clock c = new Clock();
            c.SetAlarm();

            show s = new show();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
               s.c.alarm(DateTime.Now.ToString("T"));
               s.c.tick(DateTime.Now.ToString("T"));
            }
        }
    }
   
}
