using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatingSystem
{
    class HRRN
    {
        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static Processor[] processorList = new Processor[4];

        static List<Process> indexList = new List<Process>();

        static double responseratio;


        public HRRN(List<Process> psList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            readyQueue = readyQ;
            processorList = processors;
        }

        public void calResponseRatio()
        {
            double temp;

            responseratio = 0.0;
            indexList.Clear();

            for (int i = 0; i < readyQueue.Count; i++)
            {
                temp = ((Form1.time - readyQueue[i].At) + readyQueue[i].Bt) / readyQueue[i].Bt;

                if (temp > responseratio) // response ratio 값이 최대
                {
                    responseratio = temp;
                    indexList.Clear(); // indexList 초기화
                    indexList.Add(readyQueue[i]); // indexList에 추가
                }

                else if (temp == responseratio) // 현재 response ratio 최댓값과 같은 경우
                    indexList.Add(readyQueue[i]); // indexList에 추가
            }
        }
        public void Event(object sender, EventArgs e)
        {
            // 도착한 프로세스 레디큐에 추가
            for (int i = 0; i < processList.Count(); i++)
            {
                if (processList[i].At == Form1.time)
                {
                    readyQueue.Add(processList[i]);
                }       
            }

            for (int i = 0; i < processorList.Length; i++)
            {
                if (processorList[i].runningState()) // 프로세서가 동작 중
                {
                    processorList[i].runningTime += 1;    //  동작시간 증가
                    processorList[i].getLastProcess().Bt -= 1; // 현재 수행 중인 프로세스 bt 감소

                    if (processorList[i].getLastProcess().Bt == 0) // 현재 수행 중인 프로세스의 bt가 0 인 경우
                    {
                        processorList[i].setRunning(false); // 프로세서 상태 변화
                        int idx = processList.IndexOf(processorList[i].getLastProcess());
                        processList.RemoveAt(idx);  // 프로세스 리스트에서 제거

                        if (readyQueue.Count != 0)  // 레디큐에 다른 프로세스가 있는 경우
                        {
                            calResponseRatio(); // response ratio 계산
                            processorList[i].addProcess(indexList[0]); // indexList의 0번째 항목 동작시킴
                            readyQueue.Remove(indexList[0]);    // 레디큐에서 제거
                            indexList.RemoveAt(0);  // indexLIst에서 제거
                            processorList[i].setRunning(true);  // 프로세서 동작 중
                        }

                        else // 레디큐에 대기 중인 프로세스가 없는 경우
                            processorList[i].setRunning(false);
                    }
                }

                else  // 프로세서가 비어있는 경우
                {

                    if (readyQueue.Count != 0)
                    {
                        calResponseRatio();
                        processorList[i].addProcess(indexList[0]);
                        readyQueue.Remove(indexList[0]);
                        indexList.RemoveAt(0);
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
