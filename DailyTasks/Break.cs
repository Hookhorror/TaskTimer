using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DailyTasks
{
    class Break
    {
        private DateTime startingTime;
        private DateTime endingTime;
        private Stopwatch timeUsed = new Stopwatch();

        #region methods
        public void Start()
        {
            startingTime = DateTime.Now;
            timeUsed.Start();
        }

        public void Stop()
        {
            endingTime = DateTime.Now;
            timeUsed.Stop();
        }
        #endregion methods

        #region getters
        public TimeSpan GetTimeUsed()
        {
            return timeUsed.Elapsed;
        }
        #endregion getters

        public Break()
        {

        }
    }
}
