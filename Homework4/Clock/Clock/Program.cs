using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class TimeCounter
    {
        public event EventHandler Alert;
        public int[] TimeSet()
        {
            int []timeSet = new int[3];
            string s;
            Console.WriteLine("输入小时");
            s = Console.ReadLine();
            timeSet[0] = int.Parse(s);
            Console.WriteLine("输入分钟");
            s = Console.ReadLine();
            timeSet[1] = int.Parse(s);
            Console.WriteLine("输入秒钟");
            s = Console.ReadLine();
            timeSet[2] = int.Parse(s);
            Console.WriteLine("SetTime: " + timeSet[0] + " h " + timeSet[1] + " m " + timeSet[2] + " s ");
            return timeSet;
        }
        public void DoCount(int []timeSet)
        {
            int hour = int.Parse( DateTime.Now.Hour.ToString());
            int min = int.Parse(DateTime.Now.Minute.ToString());
            int sec = int.Parse(DateTime.Now.Second.ToString());
            Console.WriteLine(hour + " h " + min + " m " + sec + " s ");
            while (hour < timeSet[0] || min < timeSet[1] || sec < timeSet[2])
            {
                System.Threading.Thread.Sleep(1000);
                hour = int.Parse(DateTime.Now.Hour.ToString());
                min = int.Parse(DateTime.Now.Minute.ToString());
                sec = int.Parse(DateTime.Now.Second.ToString());
                Console.WriteLine(hour+" h "+ min + " m "+ sec+" s ");
            }
            EventArgs args = new EventArgs();
            Alert(this, args);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var timeCounter = new TimeCounter();
            timeCounter.Alert += ShowAlert;
            int[] timeSet = timeCounter.TimeSet();
            timeCounter.DoCount(timeSet);
            Console.ReadLine();
        }

        static void ShowAlert(object sender, EventArgs e)
        {
            Console.WriteLine("响铃");
        }
    }
}
