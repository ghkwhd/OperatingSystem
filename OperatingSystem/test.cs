using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystem
{
    internal class test
    {

        static System.Timers.Timer timer;

        List<Process> processList = new List<Process>();
        List<Process> readyQueue = new List<Process>();
        Processor[] processorList = new Processor[4];
        //static int time = 0;    // 현재 시간


        public FCFS(List<Process> psList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            readyQueue = readyQ;
            processorList = processors;
        }

        public void FirstCome()
        {
            for (int i = 0; i < processList.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < processList.Count; j++)
                {
                    if (processList[min].At >= processList[j].At)
                        min = j;
                }
                Process tmp = processList[min];
                processList[min] = processList[i];
                processList[i] = tmp;

            }
        }

        //private static void timerEvent(object source, ElapsedEventArgs e)
        //{
        //    for(int i = 0; i < processList.Count; i++)
        //    {
        //        if (processList[i].At == time)
        //            readyQueue.Add(processList[i]);
        //        else if (processList[i].At > time)
        //            break;
        //    }


        //    for (int i = 0; i < processorList.Length; i++)
        //    {
        //        if (processorList[i].GetProcessList().Count == 0)
        //        {
        //            if (readyQueue[0].At <= time)
        //            {
        //                processorList[i].addProcessor(readyQueue[0]);
        //                readyQueue.RemoveAt(0);
        //                processorList[i].GetProcessList().Last().Bt -= 1;
        //            }
        //            continue;
        //        }

        //        Process ps = processorList[i].GetProcessList().Last();

        //        if (ps.Bt == 1)    //  현재 수행 중인 프로세스의 실행시간만큼 시간이 지난 경우
        //        {
        //            Console.WriteLine("Finish: "+ ps.name + " Time = "+ time);
        //            int idx = processList.IndexOf(ps);
        //            processList.RemoveAt(idx);


        //            if (processList.Count == 0)// 더 이상 남아 있는 프로세스가 없다면 타이머 종료
        //            {
        //                timer.Stop();
        //            }

        //            else if(readyQueue.Count > 0) // 남아 있는 프로세스가 있는 경우 다음 프로세스 탐색
        //            {
        //                if (readyQueue[0].At <= time)
        //                {
        //                    processorList[i].addProcessor(readyQueue[0]);
        //                    Console.WriteLine("Add to Core: "+readyQueue[0].name+" time = "+time);
        //                    readyQueue.RemoveAt(0);
        //                    ps.Bt -= 1;
        //                }

        //                continue;
        //            }

        //            if (processorList[i].getType())
        //            {
        //                ps = processorList[i].GetProcessList().Last();
        //                ps.Bt -= 1;
        //            }

        //            else
        //            {
        //                ps = processorList[i].GetProcessList().Last();
        //                ps.Bt -= 1;
        //            }
        //        }

        //        else
        //        {
        //            ps.Bt -= 1;
        //        }
        //    }

        //    ++time;
        //}

        public void test(object sender, EventArgs e)
        {
            int time = Form1.time;
            Console.WriteLine("FCFS Timer = " + time);

            for (int i = 0; i < processList.Count; i++)
            {
                if (processList[i].At == time)
                    readyQueue.Add(processList[i]);
                else if (processList[i].At > time)
                    break;
            }

            for (int i = 0; i < processorList.Length; i++)
            {
                if (processorList[i].GetProcessList().Count == 0)
                {
                    if (readyQueue[0].At <= time)
                    {
                        processorList[i].addProcessor(readyQueue[0]);
                        processorList[i].GetProcessList()[0].Bt -= 1;
                        readyQueue.RemoveAt(0);
                    }
                    continue;
                }

                Process ps = processorList[i].GetProcessList().Last();

                if (ps.Bt == 0)    //  현재 수행 중인 프로세스의 실행시간만큼 시간이 지난 경우
                {
                    Console.WriteLine("Finish: " + ps.name + " Time = " + time);
                    int idx = processList.IndexOf(ps);
                    processList.RemoveAt(idx);


                    if (processList.Count == 0)// 더 이상 남아 있는 프로세스가 없다면 타이머 종료
                    {
                        Form1.timer1.Stop();
                    }

                    else if (readyQueue.Count > 0) // 남아 있는 프로세스가 있는 경우 다음 프로세스 탐색
                    {
                        if (readyQueue[0].At <= time)
                        {
                            processorList[i].addProcessor(readyQueue[0]);
                            Console.WriteLine("Add to Core: " + readyQueue[0].name + " time = " + time);
                            readyQueue.RemoveAt(0);
                            ps.Bt -= 1;
                        }

                        continue;
                    }

                    if (processorList[i].getType())
                    {
                        ps = processorList[i].GetProcessList().Last();
                        ps.Bt -= 1;
                    }

                    else
                    {
                        ps = processorList[i].GetProcessList().Last();
                        ps.Bt -= 1;
                    }
                }

                else
                {
                    ps.Bt -= 1;
                }
            }
        }

        public void startFCFS()
        {
            //timer = new System.Timers.Timer(1000);  // 1초마다
            //timer.Elapsed += timerEvent;
            //timer.AutoReset = true; // 반복적으로 실행
            //FirstCome();
            //timer.Start();


            Console.Read(); // 콘솔창 유지
        }

    }
}
