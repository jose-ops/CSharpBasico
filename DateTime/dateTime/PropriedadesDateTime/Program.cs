using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275, DateTimeKind.Local);

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58, 275, DateTimeKind.Utc);

            Console.WriteLine(d);//convert string para dateTime
            Console.WriteLine(d2.ToUniversalTime());
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            DateTime date= new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = date.ToLongDateString();
            string s2 = date.ToLongTimeString();
            string s3 = date.ToShortDateString();
            string s4 = date.ToShortTimeString();
            string s5 = date.ToString();
            string s6 = date.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = date.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            //DateTime day = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //DateTime y = day.Add(timeSpan);
            //DateTime y = x.AddDays(double);
            //DateTime y = x.AddHours(double);
            //DateTime y = x.AddMilliseconds(double);
            //DateTime y = x.AddMinutes(double);
            //DateTime y = x.AddMonths(int);
            //DateTime y = x.AddSeconds(double);
            //DateTime y = x.AddTicks(long);
            //DateTime y = x.AddYears(int);
            //DateTime y = x.Subtract(timeSpan);
            //TimeSpan t = x.Subtract(dateTime);

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);
            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
