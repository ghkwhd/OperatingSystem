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
        static int readyIDX = 0;


        public FOF(List<Process> psList, List<Process> psCopyList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            processCopyList = psCopyList;
            readyQueue = readyQ;
            processorList = processors;
        }

        public void checkDeadline(int i)
        {
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

            else
            {
                int processIDX = processList.IndexOf(readyQueue[readyIDX]);

                // 2. deadline 지킬 수 있는지
                if (minDeadline > processList[processIDX].Bt)
                {
                    if(processorList[i].getLastProcess().deadline > processList[processIDX].deadline)
                    {
                        readyQueue.Add(processorList[i].getLastProcess());  // 현재 프로세스를 레디큐에 저장
                        processorList[i].addProcess(processList[processIDX]);
                        readyQueue.RemoveAt(readyIDX);
                    }
                }

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

            if(deadQueue.Count == 0)
            {
                for (int i = 0; i < processorList.Length; i++)
                {
                    allocation(i);
                }
            }

            else
            {
                readyQueue.Add(processorList[processorList.Length-1].getLastProcess());  // 현재 프로세스를 레디큐에 저장
                processorList[processorList.Length - 1].addProcess(deadQueue[0]);
                deadQueue.RemoveAt(0);

                for (int i = 0; i < processorList.Length-1; i++)
                {
                    allocation(i);
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
