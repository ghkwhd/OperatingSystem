using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OperatingSystem
{
    internal class SRTN_sort_ver
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

        public SRTN_sort_ver(List<Process> psList)
        {
            processList = psList;
        }

        //       public static void check_min()
        //       {
        //           for (int i = 0; i < readyQueue.Count; i++)
        //          {
        //               if (min > readyQueue[i].Bt)
        //               {
        //                   min = readyQueue[i].Bt;
        //                   idx = i;
        //               }
        //           }
        //       }

//        public static int check_min() //레디큐를 bt값에 따라 정렬 시키기
//        { 
//            readyQueue = readyQueue.OrderBy(order => order.Bt).ToList();
//            return readyQueue[0];
//        }
             
        public static void timerEvent(object source, ElapsedEventArgs e)
        {

            if (processList.Count == 0)//모든 프로세스가 다 처리 끝냄
                p_timer.Stop(); //타이머 끝내!


            if (readyQueue.Count != 0) //레디큐에 있어
            {
                readyQueue = readyQueue.OrderBy(order => order.Bt).ToList(); //정렬(Bt기준으로 정렬)
                for (int i = 0; i < 4; i++)
                {
                    if (processorList[i].running_process) // 레디큐에도 있고 프로세서 자리 있어
                    {
                        
                       // idx = check_min(); //readyqueue에서 찾아
                        processorList[i].running_process = false; //할당된 것의 정보 넣어주기
                        
                        readyQueue[0].Bt -= 1; //할당 되었으니 bt하나 줄여줌
                        readyQueue.RemoveAt(0); //할당 되어서 레디큐에서 지워줌

                        if (readyQueue[0].Bt != 0)//근데 bt가 0이 아니면
                        {
                            readyQueue.Add(readyQueue[0]); //다시 레디 큐에 넣어줌
                        }
                        else if (readyQueue[0].Bt == 0)//근데 bt가 0이면
                        {
                            processList.RemoveAt(idx); // 프로세스 리스트에서 지워줌
                        }

                        processorList[i].running_process = true; //다시 프로세서 열어주기 들어올 수 있게

                    }
                    else //레디큐에는 들어와 있는데 프로세서에 자리 없어
                    {
                        readyQueue[0].Bt -= 1; //들어있는거 bt 줄여
                        if (readyQueue[0].Bt == 0)//근데 bt가 0이면
                        {
                            processList.RemoveAt(0); // 프로세스 리스트에서 지워
                        }
                    }
                }
                time++;
            }
            else //레대큐에 없어
            {
                for (int i = 0; i < 4; i++)
                {
                    if (processorList[i].running_process) // 레대큐에 없고 프로세서 돌아가는거 없으면
                    {
                        confirm += 1; //프로세서가 다 비었는지 확인할거
                        if (confirm == 4) //프로세서 다 비었으면
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

