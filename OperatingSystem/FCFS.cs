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

        /*
        static List<string> psNameList = new List<string>();
        static List<int> psATList = new List<int>();
        static List<int> psBTList = new List<int>();
        */
        static List<Process> proessList = new List<Process>();


        static int time = 0;    // 현재 시간
        static int idx = 0;    // 실행해야 할 프로세스의 인덱스
        static int waiting = 0; // 호출을 무시하기 위한 카운트 (프로세스의 bt만큼 무시)
        static List<Label> labels = new List<Label>();
        /*
        public FCFS(List<string> name, List<int> at, List<int> bt)
        {
            psNameList = name;
            psATList = at;
            psBTList = bt;
        }
        */

        public FCFS(List<Process> psList, List<Label> lbls)
        {
            proessList = psList;
            labels = lbls;
        }

        public static void FirstCome()
        {
            int minAT = proessList[0].At;
            foreach (var p in proessList){
                if (minAT > p.At)
                    minAT = p.At;
            }

            for (int i = 0; i < proessList.Count; i++)
            {
                if (minAT <= time)
                {
                    if (minAT == proessList[i].At)
                    {
                        idx = i;
                        Console.WriteLine("min: " + minAT + " index: " + idx + " count: "+proessList.Count);
                    }
                }
            }
        }

        private static void timerEvent(object source, ElapsedEventArgs e)
        {
            if (waiting == proessList[idx].Bt)   //  현재 수행 중인 프로세스의 실행시간만큼 시간이 지난 경우
            {
                Console.WriteLine("waiting: "+waiting + " now Time: "+ time);
                waiting = 0;    // waiting 초기화
                proessList.RemoveAt(idx);


                if (proessList.Count == 0)// 더 이상 남아 있는 프로세스가 없다면 타이머 종료
                {
                    Console.WriteLine("프로세서 0개 이므로 종료");
                    timer.Stop();
                }

                else // 남아 있는 프로세스가 있는 경우 다음 프로세스 탐색
                {
                    FirstCome();

                    Label label = new Label();
                    label.Text = proessList[idx].name;

                    Form1.running = proessList[idx].name;
                    labels.Add(label);
                    Form1.check = true;

                    Console.WriteLine("실행 시작 프로세스 = " + proessList[idx].name );
                    waiting+=1;
                }
            }
            else
            {
                Form1.check = false;
                waiting++;
            }
                
            ++time;
        }



        public void startFCFS()
        {
            timer = new System.Timers.Timer(1000);  // 1초마다
            timer.Elapsed += timerEvent;
            timer.AutoReset = true; // 반복적으로 실행
            timer.Start();

            FirstCome();
            Label label = new Label();
            label.Text = proessList[idx].name;

            Form1.check = true;
            Form1.running = proessList[idx].name;
            labels.Add(label);
            
            Console.WriteLine("실행 시작 프로세스 = " + proessList[idx].name);
            waiting += 1;

            Console.Read(); // 콘솔창 유지
        }
    }
}