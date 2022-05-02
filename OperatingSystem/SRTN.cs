using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatingSystem
{
    class SRTN
    {
        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static Processor[] processorList = new Processor[4];

        static List<Process> indexList = new List<Process>();
        static int remainBurst = int.MaxValue;  // 남은 수행 시간
        static bool bchanged = false;   // 프로세스 변경해야하는지 엽주


        public SRTN(List<Process> psList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            readyQueue = readyQ;
            processorList = processors;
        }

        public void calRemainBurst()
        {
            bchanged = false;

            for (int i = 0; i < readyQueue.Count; i++)
            {
                if (readyQueue[i].Bt < remainBurst)
                {
                    indexList.Clear();  //  인덱스 리스트 초기화
                    indexList.Add(readyQueue[i]);   // 인덱스 리스트에 추가
                    remainBurst = readyQueue[i].Bt; // 남은 수행시간의 최소를 저장
                    bchanged = true;    // 다음 수행할 프로세스에 변화가 있다면 true
                }

                else if (readyQueue[i].Bt == remainBurst)
                {
                    indexList.Add(readyQueue[i]);   // 인덱스 리스트에 추가
                    bchanged = true;    // 다음 수행할 프로세스에 변화가 있다면 true
                }
            }
        }
        public void Event(object sender, EventArgs e)
        {
            // 도착한 프로세스 레디큐에 추가
            for (int i = 0; i < processList.Count(); i++)
            {
                if (processList[i].At == Form1.time)
                    readyQueue.Add(processList[i]);
            }

            for (int i = 0; i < processorList.Length; i++)
            {
                if (processorList[i].runningState()) // 프로세서가 동작 중
                {
                    processorList[i].runningTime += 1;    //  프로세서 동작시간 증가
                    processorList[i].getLastProcess().Bt -= 1; // 현재 수행 중인 프로세스 bt 감소

                    if (processorList[i].getLastProcess().Bt == 0) // 현재 수행 중인 프로세스의 bt가 0 인 경우
                    {
                        processorList[i].setRunning(false); // 프로세서 상태 변화
                        int idx = processList.IndexOf(processorList[i].getLastProcess());
                        processList.RemoveAt(idx);  // 프로세스 리스트에서 제거
                        remainBurst = int.MaxValue; // 남은 수행시간은 정수의 최댓값으로 설정

                        if (readyQueue.Count != 0)  // 레디큐에 다른 프로세스가 있는 경우
                        {
                            calRemainBurst();   // 다음 수행될 프로세스 결정

                            processorList[i].addProcess(indexList[0]);
                            readyQueue.Remove(indexList[0]);
                            indexList.RemoveAt(0);
                            processorList[i].setRunning(true);  // 프로세서 동작 중

                        }

                        else // 레디큐에 대기 중인 프로세스가 없는 경우
                            processorList[i].setRunning(false);
                    }

                    else    // 현재 수행 중인 프로세스의 bt가 0이 아닌 경우
                    {
                        if (readyQueue.Count != 0)  // 레디큐에 다른 프로세스가 있는 경우
                        {
                            remainBurst = processorList[i].getLastProcess().Bt; // 현재 프로세스의 남은 수행시간 저장
                            calRemainBurst();   // 다음 프로세스 결정

                            if (bchanged)   // 현재 실행 중인 프로세스보다 다른 프로세스의 남은 수행시간이 더 적은 경우
                            {
                                readyQueue.Add(processorList[i].getLastProcess());  // 현재 프로세스를 레디큐에 저장
                                processorList[i].addProcess(indexList[0]);
                                readyQueue.Remove(indexList[0]);
                                indexList.RemoveAt(0);
                                processorList[i].setRunning(true);  // 프로세서 동작 중
                            }
                        }
                    }
                }

                else  // 프로세서가 비어있는 경우
                {
                    if (readyQueue.Count != 0)  // 레디큐에 다른 프로세스가 있는 경우
                    {
                        remainBurst = int.MaxValue; // 남은 수행 시간을 최대로 설정
                        calRemainBurst();   // 다음 수행 프로세스 계산

                        processorList[i].addProcess(indexList[0]);
                        readyQueue.Remove(indexList[0]);
                        indexList.RemoveAt(0);
                        processorList[i].setRunning(true);  // 프로세서 동작 중
                    }

                    else
                        processorList[i].setRunning(false);
                }
            }
        }
    }
}