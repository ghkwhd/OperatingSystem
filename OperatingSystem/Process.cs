using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystem
{
    class Process
    {
        public string name;
        public int At;
        public int Bt;
        
        public Process(string psName, int psAt, int psBt)
        {
            name = psName;
            At = psAt;
            Bt = psBt;
        }
    }
}
