using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class Worker
    {
        string currentJob;
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        int shiftsLeft;
        public int ShiftsLeft
        {
            get
            {
                return shiftsLeft;
            }
        }

        string[] jobsICanDo;
        private int shiftsToWork;
        int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;  
        }
        public bool DoThisJob(string jobToDo, int shiftsToWork)
        {
            if (!string.IsNullOrEmpty(CurrentJob))
            {
                return false;
            }

            for (int i = 0; i < jobsICanDo.Length; i++)
                {
                if (jobsICanDo[i]==jobToDo)
                {
                    currentJob = jobToDo;
                    shiftsLeft = shiftsToWork;
                    this.shiftsToWork = shiftsToWork;
                    return true;
                }
            }
            return false;
        }
        
        public bool DidYouFinish()
        {
            shiftsLeft -=1;
            shiftsWorked += 1;

            if (shiftsLeft == 0)
            {
                currentJob = "";
                return true;
            }
            return false;
        }
    }
}
