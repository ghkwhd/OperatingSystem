﻿using System;
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
                if (processList[i].At == Form1.time)
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
                        if (ps.Bt > 0 && ps.Bt < 2)
                            ps.Bt = 0;
                        else
                            ps.Bt -= 2; // 2배 실행
                    }


                    if (ps.Bt == 0)  // 실행이 끝났을 때
                    {
                        processCopyList[ps.index].Tt = Form1.time - ps.At;
                        processorList[i].setRunning(false);  // 실행 끝 알림
                        int idx = processList.IndexOf(ps);  //프로세스 리스트에서 위치 검색 
                        processList.RemoveAt(idx);  // 프로세스 리스트에서 삭제
                        RRtime[i] = 1; // 실행시간 초기화

                        if (readyQueue.Count != 0)  // 레디큐에 프로세스가 존재할 경우
                        {
                            processorList[i].addProcess(readyQueue[0]);  // FCFS 특성으로 인해 레디큐 맨 앞의 프로세스 추가
                            readyQueue.RemoveAt(0);  // 레디큐에서 삭제
                            processorList[i].setRunning(true);  // 프로세서 동작 설정
                        }

                        else  // 레디큐에 프로세스가 없으면
                        {   
                            //readyTime[i] += 1;
                            processorList[i].setRunning(false);  // 대기 상태 설정
                        }
                    }

                    else  if (timeQuantum+1 == RRtime[i])  // 실행시간이 남았을 때
                    {
                        int idx = processList.IndexOf(ps);  // 프로세스 위치 찾기
                        ps.At += timeQuantum;  // 프로세스 timeQuantum만큼 AT 증가
                        RRtime[i] = 1; // 실행시간 증가
                        processList.RemoveAt(idx);  // 프로세스 리스트 삭제
                        processList.Add(ps);  // 새롭게 프로세스 추가
                        // Console.WriteLine(processList.Last().name + " ps AT = " + processList.Last().At + " ps BT = " + processList.Last().Bt);

                        if (readyQueue.Count != 0)  // 레디큐에 프로세스가 존재할 경우
                        {
                            processorList[i].addProcess(readyQueue[0]);  // FCFS 특성으로 인해 레디큐 맨 앞의 프로세스 추가
                            readyQueue.RemoveAt(0);  // 레디큐에서 삭제
                            readyQueue.Add(ps);
                            processorList[i].setRunning(true);  // 프로세서 동작 설정
                        }

                        else  // 레디큐에 프로세스가 없으면
                        {
                            //readyTime[i] += 1;
                            readyQueue.Add(ps);
                            processorList[i].setRunning(false);  // 대기 상태 설정
                        }
                    }

                }

                else  // 프로세서가 비어있는 경우
                {
                    if (readyQueue.Count != 0) // 레디큐에 프로세스가 존재할 경우
                    {
                        processorList[i].addProcess(readyQueue[0]);  // FCFS 특성으로 인해 레디큐 맨 앞의 프로세스 추가 
                        readyQueue.RemoveAt(0);   // 레디큐에서 삭제
                        processorList[i].runningTime += 1;  // 동작시간 증가
                        RRtime[i] += 1; // 실행시간 증가
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

