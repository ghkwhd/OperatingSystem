using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystem
{
    class Processor
    {
        string name ="";
        bool type = false;
        string schedule ="";
        List<Process> processorList = new List<Process>();
        public int waiting = 0;

        public Processor(string psName, bool psType, string scheduler)
        {
            name = psName;
            psType = type;
            scheduler = schedule;
        }

        public string getName()
        {
            return name;
        }

        public bool getType()
        {
            return type;
        }

        public string getSchedule()
        {
            return schedule;
        }

        public void addProcessor(Process ps)
        {
            processorList.Add(ps);
        }

        public List<Process> getProcessList()
        {
            return processorList;
        }

        public Process getLastProcess()
        {
            if (processorList.Count > 0)
                return processorList.Last();
            else
                return null;
        }
    }
}
