using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace OperatingSystem
{
    class FCFS
    {

        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static Processor[] processorList = new Processor[4];     


        public FCFS(List<Process> psList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            readyQueue = readyQ;
            processorList = processors;
        }

        public void Event(object sender, EventArgs e)
        {
            for (int i = 0; i < processList.Count(); i++)
            {
                if (processList[i].At == Form1.time)
                {
                    readyQueue.Add(processList[i]);  // 레디큐 설정                    
                }
            }

            for (int i = 0; i < processorList.Length; i++)
            {
                if (processorList[i].runningState()) // processor 동작 중이면
                {
                    processorList[i].runningTime += 1;  // 동작시간 증가
                    Process ps = processorList[i].getLastProcess();  // 실행 중인 프로세스
                    ps.Bt -= 1;  // 1초 실행

                    if (ps.Bt == 0)  // 실행이 끝났을 때
                    {
                        processorList[i].setRunning(false);  // 실행 끝 알림
                        int idx = processList.IndexOf(ps);  //프로세스 리스트에서 위치 검색 
                        processList.RemoveAt(idx);  // 프로세스 리스트에서 삭제

                        if (readyQueue.Count != 0)  // 레디큐에 프로세스가 존재할 경우
                        {
                            processorList[i].addProcessor(readyQueue[0]);  // FCFS 특성으로 인해 레디큐 맨 앞의 프로세스 추가
                            readyQueue.RemoveAt(0);  // 레디큐에서 삭제
                            processorList[i].setRunning(true);  // 프로세서 동작 설정
                        }

                        else  // 레디큐에 프로세스가 없으면
                        {
                            //readyTime[i] += 1;
                            processorList[i].setRunning(false);  // 대기 상태 설정
                        }

                    }

                }

                else  // 프로세서가 비어있는 경우
                {
                    if (readyQueue.Count != 0) // 레디큐에 프로세스가 존재할 경우
                    {
                        processorList[i].addProcessor(readyQueue[0]);  // FCFS 특성으로 인해 레디큐 맨 앞의 프로세스 추가 
                        readyQueue.RemoveAt(0);   // 레디큐에서 삭제
                        processorList[i].runningTime += 1;  // 동작시간 증가
                        processorList[i].setRunning(true);  // 프로세서 동작 설정
                    }

                    else  // 레디큐에 프로세스가 없으면
                    {
                        //readyTime[i] += 1;
                        processorList[i].setRunning(false);  // 대기 상태 설정
                    }
                }
            }
        }
    }
}