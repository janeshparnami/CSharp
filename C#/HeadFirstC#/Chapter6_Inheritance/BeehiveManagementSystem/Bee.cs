using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal abstract class Bee : IWorker
    {
        public string Job { get; private set; }
        public virtual float CostPerShift { get; private set; }
        public Bee(string job) 
        {
            Job = job;
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
                DoJob();    
        }
        protected virtual void DoJob()
        {

        }
    }
}
