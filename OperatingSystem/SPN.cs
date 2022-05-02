using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatingSystem
{
    class SPN
    {
        // 1. 필드
        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static Processor[] processorList = new Processor[4];

        // 2. 생성자
        public SPN(List<Process> psList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            readyQueue = readyQ;
            processorList = processors;
        }

        // 3. 실행 함수
        public void Event(object sender, EventArgs e)
        {
            // 3-1) SPN 레디큐 세팅
            for (int i = 0; i < processList.Count; i++)
            {
                /* At(도착시간)이 된 프로세스들 레디큐에 삽입 반복 */
                if (processList[i].At == Form1.time)
                    readyQueue.Add(processList[i]);
                readyQueue = readyQueue.OrderBy(x => x.Bt).ToList();

            }

            // 3-2) 실행
            for (int i = 0; i < processorList.Length; i++)
            {
                // 3-2-1) 해당 프로세서가 돌아가고 있을 때
                if (processorList[i].runningState())
                {
                    processorList[i].runningTime += 1;
                    Process ps = processorList[i].getLastProcess();
                    ps.Bt -= 1; // 1초 실행

                    /* 프로세스 실행시간이 끝나면 */
                    if (ps.Bt == 0)
                    {
                        processorList[i].setRunning(false);     // 프로세스 실행 끝 
                        processList.RemoveAt(processList.IndexOf(ps));  // 실행이 끝난 프로세스를 프로세스 리스트에서 찾아서 삭제

                        if (readyQueue.Count != 0)          // 레디큐에 프로세스 존재
                        {
                            processorList[i].addProcess(readyQueue[0]);     // BT순으로 오름차순 정렬된 레디큐의 맨 앞 프로세스 할당
                            readyQueue.RemoveAt(0);         // 레디큐에서 제외
                            readyQueue.RemoveAt(processList.IndexOf(readyQueue[0]));
                            processorList[i].setRunning(true);  // 프로세서 실행 상태 실행중으로 변경
                        }

                        else    // 레디큐에 프로세스 없으면
                            processorList[i].setRunning(false); // 대기상태만 변경
                    }

                }

                // 3-2-2) 해당 프로세서가 비어있을 때
                else
                {
                    if (readyQueue.Count != 0)
                    {
                        processorList[i].addProcess(readyQueue[0]);
                        readyQueue.RemoveAt(0);
                        readyQueue.RemoveAt(processList.IndexOf(readyQueue[0]));
                        processorList[i].runningTime += 1;
                        processorList[i].setRunning(true);
                    }

                    else
                        processorList[i].setRunning(false);
                }
            }
        }
    }
}
