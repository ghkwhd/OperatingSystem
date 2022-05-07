using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystem
{
    class FOF
    {
        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static List<Process> processCopyList = new List<Process>();
        static List<Process> deadQueue = new List<Process>();
        static Processor[] processorList = new Processor[4];

        static int minDeadline = int.MaxValue;  // 남은 deadline

        public FOF(List<Process> psList, List<Process> psCopyList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            processCopyList = psCopyList;
            readyQueue = readyQ;
            processorList = processors;
        }

        public void checkDeadline(int i)    // readyQueue에 프로세스가 있을 때 실행됨
        {
            int readyIDX = 0;
            minDeadline = int.MaxValue;

            for (int x = 0; x < readyQueue.Count(); x++)
            {
                //1.deadline 비교
                if (readyQueue[x].deadline < minDeadline)
                {
                    minDeadline = readyQueue[x].deadline;
                    readyIDX = x;
                }
            }

            if (!(processorList[i].runningState())) // 프로세서가 실행 중이 아닌 경우
            {
                processorList[i].addProcess(readyQueue[readyIDX]);
                readyQueue.RemoveAt(readyIDX);
            }

            // 프로세서가 실행 중인 경우
            else
            {
                int processIDX = processList.IndexOf(readyQueue[readyIDX]);

                // 2. deadline 지킬 수 있는지
                if (minDeadline >= processList[processIDX].Bt)
                {
                    // 현재 실행 중인 프로세스의 deadline보다 readyQueue에 있는 프로세스의 deadline이 더 적은 경우
                    if(processorList[i].getLastProcess().deadline > processList[processIDX].deadline)
                    {
                        readyQueue.Add(processorList[i].getLastProcess());  // 현재 프로세스를 레디큐에 저장
                        processorList[i].addProcess(processList[processIDX]);
                        readyQueue.RemoveAt(readyIDX);
                    }
                }


                // deadline을 지킬 수 없는 경우 deadQueue에 추가
                else
                {
                    deadQueue.Add(readyQueue[readyIDX]);
                    readyQueue.RemoveAt(readyIDX);
                }
            }
        }

         void allocation(int i)
        {
            if (processorList[i].runningState()) // 프로세서가 동작 중인 경우 실행
            {
                processorList[i].runningTime += 1;    //  동작시간 증가
                processorList[i].getLastProcess().deadline -= 1;

                Process ps = processorList[i].getLastProcess();  // 실행 중인 프로세스
                processCopyList[ps.index].runBt++;  // 현재 프로세스 실제 수행 시간 증가

                // 코어에 따른 bt값 변경
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


                if (ps.Bt == 0) // 프로세스 수행 종료
                {
                    processCopyList[ps.index].Tt = Form1.time - ps.At;
                    processorList[i].setRunning(false); // 프로세서 상태 변화
                    int idx = processList.IndexOf(processorList[i].getLastProcess());
                    processList.RemoveAt(idx);  // 프로세스 리스트에서 제거

                    if (readyQueue.Count != 0)  // 대기 중인 프로세스가 있는 경우
                    {
                        checkDeadline(i);
                        processorList[i].setRunning(true);
                    }
                }

                // 프로세스 수행이 끝나지 않은 경우
                else
                {
                    if (readyQueue.Count != 0)  // 대기 중인 프로세스가 있는 경우
                    {
                        checkDeadline(i);
                        processorList[i].setRunning(true);
                    }
                }

            }
            else  // 프로세서가 비어있는 경우
            {
                if (readyQueue.Count != 0)
                {
                    checkDeadline(i);
                    processorList[i].setRunning(true);
                }
            }
        }

        public void Event(object sender, EventArgs e)
        {   
            // 도착한 프로세스 레디큐에 추가
            for (int i = 0; i < processList.Count(); i++)
                if (processList[i].At == Form1.time)
                    readyQueue.Add(processList[i]);

            // deadQueue에 아무도 없는 경우, 모든 프로세서 사용
            if(deadQueue.Count == 0)
            {
                for (int i = 0; i < processorList.Length; i++)
                {
                    allocation(i);
                }
            }

            // deadQueue에 프로세서가 있는 경우
            else
            {
                for (int i = 0; i < processorList.Length - 1; i++)
                {
                    allocation(i);
                }

                // deadQueue를 처리하는 프로세서의 동작
                int last = processorList.Length - 1;

                if (processorList[last].runningState()) // processor 동작 중이면
                {
                    processorList[last].runningTime += 1;  // 동작시간 증가
                    Process nps = processorList[last].getLastProcess();  // 실행 중인 프로세스
                    processCopyList[nps.index].runBt++;  // 현재 프로세스 실제 수행 시간 증가

                    if (processorList[last].getType() == "e")
                    {
                        nps.Bt -= 1;  // 1초 실행
                    }

                    else
                    {
                        if (nps.Bt > 0 && nps.Bt < 2)
                            nps.Bt = 0;
                        else
                            nps.Bt -= 2; // 2배 실행
                    }

                    // 현재 실행 중인 프로세스가 deadQueue에 없는 프로세스인 경우
                    if (deadQueue.IndexOf(processorList[last].getLastProcess()) == -1)
                    {
                        // 마지막 프로세서에서 수행 중인 프로세스의 수행 시간이 끝나지 않은 경우
                        if (processorList[last].getLastProcess().Bt != 0)
                        {
                            readyQueue.Add(processorList[last].getLastProcess());  // 현재 프로세스를 레디큐에 저장
                            processorList[last].addProcess(deadQueue[0]);
                        }

                        // 수행 시간이 끝난 경우
                        else
                        {
                            Process ps = processorList[last].getLastProcess();  // 실행 중인 프로세스
                            processCopyList[ps.index].Tt = Form1.time - ps.At;
                            processorList[last].setRunning(false);  // 실행 끝 알림
                            int idx = processList.IndexOf(processorList[last].getLastProcess());  //프로세스 리스트에서 위치 검색 
                            processList.RemoveAt(idx);  // 프로세스 리스트에서 삭제

                            processorList[last].addProcess(deadQueue[0]);
                            processorList[last].setRunning(true);
                        }
                    }

                    // deadQueue에 있는 프로세스가 실행 중인 경우 (비선점)
                    else
                    {
                        if (processorList[last].getLastProcess().Bt == 0)
                        {
                            Process ps = processorList[last].getLastProcess();  // 실행 중인 프로세스
                            processCopyList[ps.index].Tt = Form1.time - ps.At;
                            processorList[last].setRunning(false);  // 실행 끝 알림
                            int idx = processList.IndexOf(processorList[last].getLastProcess());  //프로세스 리스트에서 위치 검색 
                            processList.RemoveAt(idx);  // 프로세스 리스트에서 삭제
                            deadQueue.RemoveAt(0);

                            if (deadQueue.Count != 0)
                            {
                                processorList[last].addProcess(deadQueue[0]);
                                processorList[last].setRunning(true);
                            }
                        }
                    }
                }

                // 실행 중이지 않으면 deadQueue에 있는 프로세스 실행
                else
                {
                    processorList[last].addProcess(deadQueue[0]);
                    processorList[last].setRunning(true);
                }
            }

            // 도착한 프로세스의 deadline 1씩 감소
            for (int i = 0; i < readyQueue.Count; i++)
            {
                readyQueue[i].deadline -= 1;
            }

            for (int i = 0; i < deadQueue.Count; i++)
            {
                deadQueue[i].deadline -= 1;
            }
        }
    }
}
