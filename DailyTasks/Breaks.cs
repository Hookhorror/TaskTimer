using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DailyTasks
{
    class Breaks
    {
        private List<Break> breaks = new List<Break>();
        private Break last;

        public void Add(Break breakInTask)
        {
            breaks.Add(breakInTask);
            last = breakInTask;
        }


        public Break GetLast()
        {
            if (last == null) {
                throw new Exception("No breaks found");
            }

            return last;
        }


        public TimeSpan GetTotalTimeUsed()
        {
            TimeSpan totalTime = TimeSpan.Zero;
            
            foreach (Break breakInTask in breaks)
            {
                totalTime = totalTime.Add(breakInTask.GetTimeUsed());
            }
            
            /*
            for (int i = 0; i < breaks.Count; i++)
            {
                totalTime = totalTime.Add(breaks[i].GetTimeUsed());
            }
            */

            return totalTime;
        }


        public int GetTotalBreaks()
        {
            return breaks.Count;
        }


        public Breaks()
        {

        }
    }
}
