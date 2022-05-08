using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OperatingSystem
{
    class RR
    {
        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static List<Process> processCopyList = new List<Process>();
        static Processor[] processorList = new Processor[4];
        static int timeQuantum = 0;
        int[] RRtime = { 0, 0, 0, 0 };  // 프로세스 실행 시간 계산

        public RR(List<Process> psList, List<Process> psCopyList, List<Process> readyQ, Processor[] processors, int tq)
        {
            processList = psList;
            processCopyList = psCopyList;
            readyQueue = readyQ;
            processorList = processors;
            timeQuantum = tq;
        }

        public void Event(object sender, EventArgs e)
        {
            for (int i = 0; i < processList.Count(); i++)
            {
                if (processList[i].At == Form1.time)  // 도착 시간이 되면
                {
                    readyQueue.Add(processList[i]);  // 레디큐 설정
                }
            }

            for (int i = 0; i < processorList.Length; i++)
            {
                if (processorList[i].runningState()) // processor 동작 중이면
                {
                    RRtime[i]++;  // 실행시간 증가
                    processorList[i].runningTime += 1;  // 동작시간 증가
                    Process ps = processorList[i].getLastProcess();  // 실행 중인 프로세스
                    processCopyList[ps.index].runBt++;  // 현재 프로세스 실제 수행 시간 증가

                    if (processorList[i].getType() == "e")
                    {
                        ps.Bt -= 1;  // 1초 실행
                    }

                    else
                    {
                        if (ps.Bt < 2)  // 2초 미만이면
                            ps.Bt = 0;  // BurstTime은 0
                        else
                            ps.Bt -= 2; // 2배 실행
                    }


                    if (ps.Bt == 0)  // 실행이 끝났을 때
                    {
                        for (int j = 0; j < processList.Count; j++)
                        {
                            if (processList[j].index == ps.index) //processList에서 프로세스를 찾고
                            {
                                processList.RemoveAt(j); // 해당 프로세스를 삭제
                            }
                        }

                        RRtime[i] = 0;  // timeQuantum과 비교할 실행 시간 초기화
                        processCopyList[ps.index].Tt = Form1.time - processCopyList[ps.index].At;
                        processorList[i].setRunning(false);  // 실행 끝 알림

                        if (readyQueue.Count != 0)  // Ready Queue에 프로세스가 존재할 경우
                        {
                            processorList[i].addProcess(readyQueue[0]);  // 레디큐 맨 앞의 프로세스 추가
                            readyQueue.RemoveAt(0);  // Ready Queue의 첫 번째 요소 삭제
                            processorList[i].setRunning(true);  // 프로세서 동작 설정
                        }
                    }

                    else if (timeQuantum == RRtime[i])  // 실행시간이 남았을 때
                    {
                        processList.Remove(ps);  // 프로세스 리스트에서 삭제
                        ps.At += timeQuantum;  // 프로세스 time quantum만큼 AT 증가
                        processList.Add(ps); // 프로세스 리스트에 프로세스 추가
                        readyQueue.Add(ps);
                        RRtime[i] = 0; // timeQuantum과 비교할 실행 시간 초기화

                        if (readyQueue.Count != 0)  // Ready Queue에 프로세스가 존재할 경우
                        {
                            processorList[i].addProcess(readyQueue[0]);  // Ready Queue 맨 앞의 프로세스 추가
                            readyQueue.RemoveAt(0);  // Ready Queue에서 삭제
                            processorList[i].setRunning(true);  // 프로세서 동작 설정
                        }
                    }
                }

                else  // 프로세서가 비어있는 경우
                {
                    if (readyQueue.Count != 0) // Ready Queue에 프로세스가 존재할 경우
                    {
                        processorList[i].addProcess(readyQueue[0]);  // Ready Queue 맨 앞의 프로세스 추가 
                        readyQueue.RemoveAt(0);   // Ready Queue의 첫 번째 삭제
                        processorList[i].setRunning(true);  // 프로세서 동작 설정
                    }
                }
            }

        }
    }
}

