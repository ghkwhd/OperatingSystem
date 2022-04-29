using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OperatingSystem
{
    class SRTN
    {
        static System.Timers.Timer p_timer;

        static int p_time = 0;
        static int run_idx = 0;
        static int min = 100;

        static List<string> name = new List<string>();
        static List<int> a_t = new List<int>(); // 도착시간들을 저장해놓을 리스트
        static List<int> b_t = new List<int>(); //  실행 시간들을 저장해놓을 리스트
        //static List<string> processor = new List<string>(); //프로세서 리스트

        public SRTN(List<string> pname, List<int> arrival_time, List<int> burst)
        {
            name = pname;
            a_t = arrival_time;
            b_t = burst;
        }
        public static int Get_AT(int i)
        {
            return a_t[i];
        }
        public static int Get_BT(int i)
        {
            return b_t[i];
        }

        public static void check_next() //다음 프로세스를 결정할 함수
        {
            for (int i = 0; i < b_t.Count; i++) //b_t에 있는 값들을 모두 비교함
            {
                if (a_t[i] <= p_time && min > b_t[i]) // 도착 시간이 지나 들어온 것들 중 지금의 프로세스보다 min값이 작으면
                {
                    min = b_t[i]; //min값을 바꿔주고
                    run_idx = i; //돌고 있는 걸 바꿔줌
                }
            }

        }

        public static void timerEvent(object source, ElapsedEventArgs e)
        {
            check_next(); //다음에 돌꺼 정해줌
            Form1.running = name[run_idx];
            b_t[run_idx] -= 1; //실행이 한번 되었으니 b_t를-1해줌

            if (b_t[run_idx] == 0) //현재 프로세스의 b_t가 0이 되어 다 끝났을때
            {
                name.RemoveAt(run_idx);//정보를 지워줌
                a_t.RemoveAt(run_idx);
                b_t.RemoveAt(run_idx);
                min = 100; // 다른 애가 들어올 수 있게
            }

            if (b_t.Count == 0)
                p_timer.Stop();

            p_time++;

        }
        public void startSRTN()
        {

            p_timer = new System.Timers.Timer(1000);
            p_timer.Elapsed += timerEvent; //1초마다 check_next를 실행시켜라
            p_timer.AutoReset = true; //timer에서 계속해서 반복시키게
            p_timer.Start(); // 타이머 시작
            check_next();
            Form1.running = name[run_idx];

        }


    }

}
}
