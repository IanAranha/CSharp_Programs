using System;

namespace DateTime2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dateTime = new DateTime(2018, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            //Console.WriteLine(now.Day);
            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.DayOfYear);
            //Console.WriteLine(now.Minute);
            //Console.WriteLine(now.Month);
            //Console.WriteLine(now.Ticks);
            //Console.WriteLine(now.Year);
            //Console.WriteLine(today.Day);
            //Console.WriteLine(today.DayOfYear);
            //Console.WriteLine(today.Hour);
            //Console.WriteLine(today.Millisecond);
            //Console.WriteLine(today.Year);
            //Console.WriteLine(now.ToLocalTime());
            //Console.WriteLine(now.ToUniversalTime());
            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString("D"));

            var start = DateTime.Now;
            var end = DateTime.Now.AddTicks(3);
            var duration = end - start;
            Console.WriteLine(duration);

        }

    }
}
