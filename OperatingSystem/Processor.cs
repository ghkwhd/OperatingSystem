using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystem
{
    class Processor
    {
        string name = "";
        string type = "";
        bool running = false;   //   추가한 코드
        List<Process> runningProcess = new List<Process>();     // 크기가 1인 processList
        public int runningTime = 0;  // running Time 계산
        public int watt = 0;

        public Processor(string psName, string coreType)
        {
            name = psName;
            type = coreType;
        }

        public bool runningState()  // 추가한 코드
        {
            return running;
        }

        public void setRunning(bool state)  // 추가한 코드
        {
            running = state;
        }

        public string getName()
        {
            return name;
        }

        public string getType()
        {
            return type;
        }

        public void addProcess(Process ps)
        {
            runningProcess.Add(ps);
        }

        public List<Process> getRunningProcess()
        {
            return runningProcess;
        }

        public Process getLastProcess()
        {
            if (runningProcess.Count > 0)
                return runningProcess.Last();
            else
                return null;
        }
    }
}
