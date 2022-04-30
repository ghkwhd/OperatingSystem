using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace OperatingSystem
{
    class FCFS
    {
        static System.Timers.Timer timer;

        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static Processor[] processorList = new Processor[4];
        static int time = 0;    // 현재 시간        


        public FCFS(List<Process> psList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            readyQueue = readyQ;
            processorList = processors;
        }

        public static void FirstCome()
        {
            for (int i = 0; i < processList.Count-1; i++)
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


        private static void timerEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Time = " + time);

            for (int i = 0; i < processorList.Length; i++)
            {
                for (int j = 0; j < processList.Count; j++)
                {
                    if (processList[j].At == time+1)
                    {
                        readyQueue.Add(processList[j]);
                        if (processorList[i].getProcessList().Count == 0)
                        {
                            processorList[i].addProcessor(readyQueue[0]);
                            readyQueue.RemoveAt(0);
                            processorList[i].waiting += 1;
                        }
                    }

                    else if (processList[j].At > time+1)
                        break;
                }                

                if (processorList[i].getProcessList().Count > 0)
                {
                    Process ps = processorList[i].getLastProcess();

                    if (ps.Bt == 0)    //  현재 수행 중인 프로세스의 실행시간만큼 시간이 지난 경우
                    {
                        Console.WriteLine("Finish: " + ps.name + " Time = " + time);
                        int idx = processList.IndexOf(ps);
                        processList.RemoveAt(idx);
                        
                        Console.WriteLine("psNum: " + processList.Count);
                        
                        if (processList.Count == 0)// 더 이상 남아 있는 프로세스가 없다면 타이머 종료
                        {
                            Console.WriteLine("종료!");
                            timer.Stop();
                        }

                        else // 남아 있는 프로세스가 있는 경우 다음 프로세스 탐색
                        {
                            if (readyQueue.Count != 0 && readyQueue[0].At <= time)
                            {
                                processorList[i].addProcessor(readyQueue[0]);
                                readyQueue.RemoveAt(0);
                                ps = processorList[i].getLastProcess();
                                processorList[i].getLastProcess().Bt -= 1;
                            }
                        }
                    }

                    else
                    {
                        processorList[i].getLastProcess().Bt -= 1;
                    }
                }
                
            }

            ++time;
        }


        public void startFCFS()
        {
            timer = new System.Timers.Timer(1000);  // 1초마다
            timer.Elapsed += timerEvent;
            timer.AutoReset = true; // 반복적으로 실행
            FirstCome();
            timer.Start();

            for (int j = 0; j < processList.Count; j++)
            {
                if (processList[j].At == time)
                {
                    readyQueue.Add(processList[j]);
                    for (int i = 0; i < processorList.Length; i++)
                    {
                        if(processorList[i].getProcessList().Count == 0)
                        {
                            processorList[i].addProcessor(readyQueue[0]);
                            readyQueue.RemoveAt(0);
                            processorList[i].waiting += 1;
                        }
                    }
                }

                else if (processList[j].At > time)
                    break;
            }

            Console.Read(); // 콘솔창 유지
        }
    }
}