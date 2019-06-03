using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DailyTasks
{
    class Task
    {
        private string name;

        private DateTime startingTime;
        private DateTime endingTime;
        private Stopwatch timeUsed;

        //TODO: oikea toteutus tauoille
        //public List<Break> breaks = new List<Break>();
        private Breaks breaks = new Breaks();

        

        #region methods
        public void Start()
        {
            this.startingTime = DateTime.Now;
            this.timeUsed.Start();
        }

        public void Stop()
        {
            this.endingTime = DateTime.Now;
            this.timeUsed.Stop();
        }

        public void Pause()
        {
            this.timeUsed.Stop();
            Break breakInTask = new Break();
            breaks.Add(breakInTask);
            breakInTask.Start();
        }

        public void Continue()
        {
            breaks.GetLast().Stop();
            this.timeUsed.Start();
        }
        #endregion methods


        #region getterit
        public DateTime GetStartingTime()
        {
            return startingTime;
        }

        public DateTime GetEndingTime()
        {
            return endingTime;
        }

        public TimeSpan GetTimeUsed()
        {
            return timeUsed.Elapsed;
        }

        public Breaks GetBreaks()
        {
            return breaks;
        }
        #endregion getterit


        #region setterit
        public void SetName(string name)
        {
            this.name = name;
        }
        #endregion setterit


        public Task()
        {
            this.timeUsed = new Stopwatch();
        }
    }
}
