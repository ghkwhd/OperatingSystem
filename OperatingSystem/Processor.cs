using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystem
{
    class Processor
    {
        public int processor_num;
        public bool processor_type; //P,E
        public string scheduling_type; //fcfs, spn...
        public bool running_process;
        static List<Processor> processorList = new List<Processor>();
        
    }
}
