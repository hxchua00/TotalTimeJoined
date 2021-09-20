using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalTimeJoined
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of days: ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of sessions per day: ");
            int sessions = int.Parse(Console.ReadLine());
            TotalTIme t = new TotalTIme(days, sessions);
            Object dTime = t;

            t.TotalTimeTaken(dTime);
            Console.ReadLine();
        }
    }
}
