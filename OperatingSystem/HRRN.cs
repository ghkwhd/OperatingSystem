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
        static int[] readyTime = { 0, 0, 0, 0 };
        static int[] runningTime = { 0, 0, 0, 0 };

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

                if (temp > responseratio)
                {
                    responseratio = temp;
                    indexList.Clear();
                    indexList.Add(readyQueue[i]);
                }

                else if (temp == responseratio)
                    indexList.Add(readyQueue[i]);
            }
        }
        public void Event(object sender, EventArgs e)
        {

            // 동작시간 출력용 (나중에 제거)
            Console.WriteLine("대기 시간");
            for (int i = 0; i < processorList.Length; i++)
                Console.WriteLine(readyTime[i]);

            Console.WriteLine("동작 시간");

            for (int i = 0; i < processorList.Length; i++)
                Console.WriteLine(runningTime[i]);


            // 레디큐 만들기
            for (int i = 0; i < processList.Count(); i++)
            {
                if (processList[i].At == Form1.time)
                    readyQueue.Add(processList[i]);
            }

            for (int i = 0; i < processorList.Length; i++)
            {
                if (processorList[i].runningState())
                {
                    runningTime[i] += 1;    //  동작시간 증가
                    processorList[i].GetProcessList().Last().Bt -= 1;

                    if (processorList[i].GetProcessList().Last().Bt == 0)
                    {
                        processorList[i].setRunning(false);
                        int idx = processList.IndexOf(processorList[i].GetProcessList().Last());
                        processList.RemoveAt(idx);

                        if (readyQueue.Count != 0)
                        {
                            calResponseRatio();
                            processorList[i].addProcessor(indexList[0]);
                            readyQueue.Remove(indexList[0]);
                            indexList.RemoveAt(0);
                            processorList[i].setRunning(true);
                        }

                        else
                        {
                            readyTime[i] += 1;
                            processorList[i].setRunning(false);
                        }

                    }

                }

                else  // 프로세서가 비어있는 경우
                {

                    if (readyQueue.Count != 0)
                    {
                        calResponseRatio();
                        processorList[i].addProcessor(indexList[0]);
                        readyQueue.Remove(indexList[0]);
                        indexList.RemoveAt(0);
                        runningTime[i] += 1;
                        processorList[i].setRunning(true);
                    }

                    else
                    {
                        readyTime[i] += 1;
                        processorList[i].setRunning(false);
                    }
                }
            }
        }
    }
}
