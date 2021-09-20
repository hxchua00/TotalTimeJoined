using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalTimeJoined
{
    class TotalTIme
    {
        double hours;
        int days;
        int sessions;
        double sessionTime;

        public TotalTIme(int days, int sessions)
        {
            this.days = days;
            this.sessions = sessions;
        }

        public void TotalTimeTaken(Object t)
        {
            TotalTIme s = new TotalTIme(days, sessions);
            t = s;

            sessionTime = 1.5 * sessions;
            hours = sessionTime * days;

            Console.WriteLine("Total time in seconds: " + (hours * 60));
            Console.WriteLine();
            
        }
    }
}
