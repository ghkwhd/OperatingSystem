//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Timers;

//namespace OperatingSystem
//{
//    class SPN
//    {
//        static System.Timers.Timer timer;

//        static int time = 0;        // 현재 시간
//        static int idx = 0;         // 실행해야 할 프로세스의 인덱스..?

//        static int process_running_time = 0;

//        static List<string> name = new List<string>();  // 프로세스 이름 저장 배열
//        static List<int> at = new List<int>();          // 프로세스 arrival time
//        static List<int> bt = new List<int>();          // 프로세스 burst time

//        public SPN(List<string> pname, List<int> arrival, List<int> burst)      // 생성자
//        {
//            name = pname;
//            at = arrival;
//            bt = burst;
//        }

//        public static void timeEvent(object source, ElapsedEventArgs e) // 1초마다 실행
//        {
//            if (process_running_time == bt[idx])
//            {
//                process_running_time = 0;
//                name.RemoveAt(idx);
//                at.RemoveAt(idx);
//                bt.RemoveAt(idx);

//                if (name.Count == 0)
//                    timer.Stop();

//                else
//                {
//                    idx = 0;
//                    for (int i = 0; i < name.Count; i++)
//                    {
//                        if (bt[idx] > bt[i])
//                            idx = i;
//                    }
//                    Form1.running = name[idx];
//                    process_running_time += 1;
//                }
//            }
//            else
//                process_running_time += 1;

//            ++time;
//        }

//        public void startSPN()
//        {
//            timer = new System.Timers.Timer(1000);
//            timer.Elapsed += timeEvent;
//            timer.AutoReset = true;
//            timer.Start();

//            Form1.running = name[idx];
//            process_running_time += 1;
//        }
//    }
//}
