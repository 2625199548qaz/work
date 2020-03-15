using System;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.clock.RunClock(0,0,50);
        }
    }
    public delegate void ClockEvent(object sender, ClockEventArgs args);

    public class ClockEventArgs
    {
        public int Hour { set; get; }
        public int Minu { set; get; }
        public int Sec { set; get; }

        public ClockEventArgs()
        {
            Hour = 0;
            Minu = 0;
            Sec = 0;
        }
    }
    public class Clock
    {
        public ClockEventArgs args;
        public event ClockEvent OnTick;
        public event ClockEvent OnAlarm;

        public Clock()
        {
            args = new ClockEventArgs();
        }
        public void RunClock(int h, int m, int s)
        {
            while (true)
            {
                Thread.Sleep(1000);
                args.Sec++;
                if (args.Sec % 60 == 0 & args.Sec != 0)
                {
                    args.Sec = 0;
                    args.Minu++;
                }
                if (args.Minu % 60 == 0 & args.Minu != 0)
                {
                    args.Minu = 0;
                    args.Hour++;
                }
                OnTick(this, args);
                if (s == args.Sec & m == args.Minu & h == args.Hour)
                {
                    OnAlarm(this, args);
                }
            }
        }
    }

    public class Form
    {
        public Clock clock;

        public Form()
        {
            clock = new Clock();
            clock.OnTick += new ClockEvent(Clo_OnTick);
            clock.OnAlarm += new ClockEvent(Clo_OnAlarm);
        }
        public void Clo_OnTick(object sender, ClockEventArgs args)
        {
            Console.WriteLine($"时间为：{clock.args.Hour}时{clock.args.Minu}分{clock.args.Sec}秒");
        }
        public void Clo_OnAlarm(object sender, ClockEventArgs args)
        {
            Console.WriteLine($"嘀嘀嘀，时间{clock.args.Hour}时{clock.args.Minu}分{clock.args.Sec}秒已经到了");
        }
    }
}
