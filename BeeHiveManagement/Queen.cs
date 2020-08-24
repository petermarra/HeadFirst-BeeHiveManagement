using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class Queen
    {
        Worker[] workers;
        int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job, int shift)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job,shift))
                {
                    return true;
                }
            }
            return false;

        }

        public string WorkTheNextShift()
        {
            shiftNumber += 1;
            string report = $"Report for shift {shiftNumber}\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += $"Worker #{i+1} is not working\r\n";
                else
                {
                    if (workers[i].DidYouFinish())
                    {
                        report += $"Worker #{i+1} finished the job\r\n";
                        report += $"Worker #{i+1} is not working\r\n";
                    }
                    else
                    {
                        if (workers[i].ShiftsLeft == 1)
                            report += $"Worker #{i+1} will be done with {workers[i].CurrentJob} after this shift\r\n";
                        else
                            report += $"Worker #{i+1} is doing {workers[i].CurrentJob} for {workers[i].ShiftsLeft} more shifts\r\n";
                    }
                }
            }
            return report;

        }
    }
}
