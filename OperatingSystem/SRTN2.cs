using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OperatingSystem
{
    class SRTN2
    {
        static System.Timers.Timer p_timer;

        static int time = 0;
        static int idx = 0;
        static int min = 100;
        static int confirm = 0;
        static List<Process> processList = null;
        static List<Process> readyQueue = null;
        static Processor[] processorList = new Processor[4];
        static List<Label> labels = new List<Label>();

        public SRTN2(List<Process> psList)
        {
            processList = psList;
        }

        public static void check_min()
        {
            for (int i = 0; i < readyQueue.Count; i++)
            {
                if (min > readyQueue[i].Bt)
                {
                    min = readyQueue[i].Bt;
                    idx = i;
                }
            }
        }

        public static void timerEvent(object source, ElapsedEventArgs e)
        {

            if (processList.Count == 0)//모든 프로세스가 다 처리 끝냄
                p_timer.Stop(); //타이머 끝내!


            if (readyQueue.Count != 0) //레디큐에 있어
            {
                for (int i = 0; i < 4; i++)
                {
                    if (processorList[i].running_process_idx == null) // 레디큐에도 있고 프로세서 자리 있어
                    {
                        check_min(); //readyqueue에서 찾ㅇ,ㅁ
                        processorList[i].running_process_idx = idx; //idx정보 넣어주기
                        readyQueue.RemoveAt(idx); //할당 되어서 레디큐에서 지워줌
                        readyQueue[idx].Bt -= 1; //할당 되었으니 bt하나 줄여줌
                        if (readyQueue[idx].Bt == 0)//근데 bt가 0이면
                        {
                            processList.RemoveAt(idx); // 프로세스 리스트에서 지워줌
                        }

                    }
                    else //레디큐에는 들어와 있는데 프로세서에 자리 없어
                    {
                        readyQueue[idx].Bt -= 1; //들어있는거 bt 줄여
                        if (readyQueue[idx].Bt == 0)//근데 bt가 0이면
                        {
                           processList.RemoveAt(idx); // 프로세스 리스트에서 지워
                        }
                    }
                }
                time++;
            }
            else //레대큐에 없어
            {
                for (int i =0; i < 4; i++) {
                    if (processorList[i].running_process_idx == null) // 프로세서 돌아가는거 없으면
                    {
                        confirm += 1; //프로세서가 다 비었는지 확인할거
                        if(confirm == 4) //프로세서 다 비었으면
                            p_timer.Stop(); //타이머 끝내!

                    }
                    else //레디 큐에 있는 것들이 다 할당받아서 레디큐에만 없는 상황
                    {
                        readyQueue[idx].Bt -= 1; //들어있는거 bt 줄여
                        if (readyQueue[idx].Bt == 0)//근데 bt가 0이면
                        {
                            processList.RemoveAt(idx); // 프로세스 리스트에서 지워
                        }
                    }
                }
                time++;
            }

        }
    }
}

//레디큐 append해주는 부분 필요
// sort를 하는 방향으로 => 현재 bt가 가장 적은 순으로 정렬
// timer한 바퀴 돌고 처리 된 것(=즉, 레디큐에서 빠졌던것의 bt확인해서 0보다 크면 레디큐에 다시 어펜드,
// 아니라면 프로세스 리스트에서 삭제.