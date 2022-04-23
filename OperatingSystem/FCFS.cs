using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OperatingSystem
{
    class FCFS
    {
        static System.Timers.Timer timer;

        static List<string> psNameList = new List<string>();
        static List<int> psATList = new List<int>();
        static List<int> psBTList = new List<int>();

        static int time = 0;    // 현재 시간
        static int idx = 0;    // 실행해야 할 프로세스의 인덱스
        static int waiting = 0; // 호출을 무시하기 위한 카운트 (프로세스의 bt만큼 무시)
        public FCFS(List<string> name, List<int> at, List<int> bt)
        {
            psNameList = name;
            psATList = at;
            psBTList = bt;
        }

        public static void FirstCome()
        {
            int min = psATList.Min();
            for (int i = 0; i < psNameList.Count; i++)
            {
                if (min <= time)
                {
                    if (min == psATList[i])
                    {
                        idx = i;
                        Console.WriteLine("min: " + min + " index: " + idx);
                    }
                }
            }
        }

        private static void timerEvent(object source, ElapsedEventArgs e)
        {
            if (waiting == psBTList[idx])   //  현재 수행 중인 프로세스의 실행시간만큼 시간이 지난 경우
            {
                waiting = 0;    // waiting 초기화
                psNameList.RemoveAt(idx);
                psATList.RemoveAt(idx);
                psBTList.RemoveAt(idx);


                if (psNameList.Count == 0)// 더 이상 남아 있는 프로세스가 없다면 타이머 종료
                {
                    Console.WriteLine("종료");
                    timer.Stop();
                }

                else // 남아 있는 프로세스가 있는 경우 다음 프로세스 탐색
                {
                    FirstCome();
                    Form1.running = psNameList[idx];
                    Console.WriteLine("\n실행 시작 프로세스 = " + psNameList[idx]);
                    waiting += 1;
                }
            }
            else
                waiting++;

            ++time;
        }



        public void startFCFS()
        {

            timer = new System.Timers.Timer(1000);  // 1초마다
            timer.Elapsed += timerEvent;
            timer.AutoReset = true; // 반복적으로 실행
            timer.Start();

            FirstCome();
            Form1.running = psNameList[idx];
            Console.WriteLine("실행 시작 프로세스 = " + psNameList[idx]);
            waiting += 1;

            Console.Read(); // 콘솔창 유지
        }


    }
}