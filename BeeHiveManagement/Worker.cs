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
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }
        
        //int shiftsLeft;
        public int ShiftsLeft
        {
            get
            {
                return  shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;  
        }
        public bool DoThisJob(string jobToDo, int shiftsToWork)
        {
            if (!string.IsNullOrEmpty(CurrentJob))
                return false;

            for (int i = 0; i < jobsICanDo.Length; i++)
                {
                if (jobsICanDo[i]==jobToDo)
                {
                    currentJob = jobToDo;
                    this.shiftsToWork = shiftsToWork;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
             if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
    }
}
