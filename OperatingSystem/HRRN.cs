//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Timers;

//namespace OperatingSystem
//{
//    class HRRN
//    {
//        static System.Timers.Timer timer;

//        static int time = 0;    // 현재 시간
//        static int idx = 0;    // 실행해야 할 프로세스의 인덱스

//        static int waiting = 0; // 호출을 무시하기 위한 카운트 (프로세스의 bt만큼 무시)

//        static List<string> name = new List<string>();
//        static List<int> at = new List<int>();
//        static List<int> bt = new List<int>();

//        public HRRN(List<string> pname, List<int> arrival, List<int> burst)
//        {
//            name = pname;
//            at = arrival;
//            bt = burst;
//        }

//        public static int GetAT(int i)  // arrival time 반환
//        {
//            return at[i];
//        }

//        public static int GetBT(int i)  // burst time 반환
//        {
//            return bt[i];
//        }

//        public static void CalResponseRatio()   // Response Ratio 계산
//        {
//            double highest = 0;
//            double calResult;
//            //Console.WriteLine("\n");

//            for (int i = 0; i < name.Count; i++)
//            {
//                if (at[i] <= time)   // 프로세스가 도착한 경우
//                {
//                    calResult = (double)(GetBT(i) + (time - GetAT(i))) / GetBT(i);
//                    //Console.WriteLine(name[i] + "=(" + GetBT(i) + "+" + (time - GetAT(i) + ")/" + GetBT(i)) + "=" + calResult);

//                    if (calResult > highest)
//                    {
//                        highest = calResult;
//                        idx = i;
//                    }
//                }
//            }
//        }

//        private static void timerEvent(object source, ElapsedEventArgs e)
//        {
//            if (waiting == bt[idx])   //  현재 수행 중인 프로세스의 실행시간만큼 시간이 지난 경우
//            {
//                waiting = 0;    // waiting 초기화
//                name.RemoveAt(idx);
//                at.RemoveAt(idx);
//                bt.RemoveAt(idx);

//                if (name.Count == 0)    // 더 이상 남아 있는 프로세스가 없다면 타이머 종료
//                    timer.Stop();

//                else // 남아 있는 프로세스가 있는 경우 다음 프로세스 탐색
//                {
//                    CalResponseRatio();
//                    Form1.running = name[idx];
//                    //Console.WriteLine("\n실행 시작 프로세스 = " + name[idx]);
//                    waiting += 1;
//                }
//            }
//            else
//                waiting++;

//            ++time;
//        }

//        public void startHRRN()
//        {

//            timer = new System.Timers.Timer(1000);  // 1초마다
//            timer.Elapsed += timerEvent;
//            timer.AutoReset = true; // 반복적으로 실행
//            timer.Start();

//            CalResponseRatio();
//            Form1.running = name[idx];
//            //Console.WriteLine("실행 시작 프로세스 = " + name[idx]);
//            waiting += 1;

//            Console.Read(); // 콘솔창 유지
//        }


//    }
//}
