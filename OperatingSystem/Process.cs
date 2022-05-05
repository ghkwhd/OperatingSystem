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
        public int runBt = 0;   // 실제 수행 시간
        public float Tt;
        public int index = 0;  // GUI 색깔 번호 유지 위해서
        
        public Process(string psName, int psAt, int psBt, int idx)
        {
            name = psName;
            At = psAt;
            Bt = psBt;
            index = idx;
        }
    }
}
