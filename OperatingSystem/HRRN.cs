using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatingSystem
{
    class HRRN
    {
        // 1. 필드
        static List<Process> processList = new List<Process>();
        static List<Process> readyQueue = new List<Process>();
        static Processor[] processorList = new Processor[4];
        static List<Process> processCopyList = new List<Process>();
        static List<Process> indexList = new List<Process>();
        static double responseratio;


        // 2. 생성자
        public HRRN(List<Process> psList, List<Process> psCopyList, List<Process> readyQ, Processor[] processors)
        {
            processList = psList;
            processCopyList = psCopyList;
            readyQueue = readyQ;
            processorList = processors;
        }

        // 3. Response Ratio 계산
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

                //else if (temp == responseratio) // 현재 response ratio 최댓값과 같은 경우
                //    indexList.Add(readyQueue[i]); // indexList에 추가
            }
        }
        // 4. 실행 함수 Event
        public void Event(object sender, EventArgs e)
        {
            //4-1) HRRN 레디큐 세팅
            for (int i = 0; i < processList.Count(); i++)
                if (processList[i].At == Form1.time)    // 도착시간이 된 프로세스들 레디큐에 삽입 반복
                    readyQueue.Add(processList[i]);

            // 4-2) 실행
            for (int i = 0; i < processorList.Length; i++)
            {
                // 4-2-1) 해당 프로세서가 실행 중일 때
                if (processorList[i].runningState())
                {
                    processorList[i].runningTime += 1;    // 해당 프로세서의 실행시간 1초 증가

                    Process ps = processorList[i].getLastProcess();  // 실행 중인 프로세스를 ps로 정의
                    processCopyList[ps.index].runBt++;   // 현재 실행 중인 프로세스의 실제 수행 시간 증가

                    // 4-2-1-1) 프로세서가 E core 일 경우
                    if (processorList[i].getType() == "e")
                    {
                        ps.Bt -= 1;  // 1초에 1의 일을 수행
                    }

                    // 4-2-1-2) 프로세서가 P core 일 경우
                    else
                    {
                        if (ps.Bt > 0 && ps.Bt < 2) // 남은 시간이 1인 경우 
                            ps.Bt = 0;              // 남은 수행 시간 0으로 변경
                        else
                            ps.Bt -= 2;             // 1초에 2의 일을 수행 (E코어의 2배의 성능)
                    }

                    // 4-2-1-3) 실행 중인 프로세스의 수행이 종료된 경우
                    if (ps.Bt == 0)
                    {
                        processCopyList[ps.index].Tt = Form1.time - ps.At;  // 전체 실행시간 TT는 현재 시간에서 도착시간을 뺀 값
                        processorList[i].setRunning(false);                 // 프로세서의 실행상태를 false로 변경
                        int idx = processList.IndexOf(processorList[i].getLastProcess());
                        processList.RemoveAt(idx);                          // 실행이 끝난 프로세스를 프로세스 리스트에서 찾아서 삭제

                        // 레디큐에 대기 중인 프로세스가 존재하는 경우
                        if (readyQueue.Count != 0) 
                        {
                            calResponseRatio(); // response ratio 계산
                            processorList[i].addProcess(indexList[0]); // indexList의 0번째 항목을 할당
                            readyQueue.Remove(indexList[0]);          // 레디큐에서 제거
                            indexList.RemoveAt(0);                   // indexLIst에서 제거
                            processorList[i].setRunning(true);      // 프로세서의 실행상태를 true로 변경
                        }
                    }

                    // 프로세스 수행이 끝나지 않은 경우
                    else
                        processorList[i].addProcess(processorList[i].getLastProcess());
                }

                // 4-2-2) 프로세서가 비어있을 때
                else
                {
                    // 레디큐에 대기 중인 프로세스가 존재하는 경우
                    if (readyQueue.Count != 0)
                    {
                        calResponseRatio();
                        processorList[i].addProcess(indexList[0]);
                        readyQueue.Remove(indexList[0]);
                        indexList.RemoveAt(0);
                        processorList[i].setRunning(true);
                    }
                }
            }
        }
    }
}