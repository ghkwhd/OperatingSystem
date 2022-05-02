using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatingSystem
{
    public partial class Form1 : Form
    {
        public static int time = 0;
        static List<Process> processList = new List<Process>();
        static Processor[] processorArray = new Processor[4];
        static List<Process> ReadyQueue = new List<Process>();

        static Timer timer2 = new Timer();  // 추가한 코드

        List<TableLayoutPanel> tableLayouts = new List<TableLayoutPanel>();
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000; // 추가한 코드
        }

        Color[] bgColor = {Color.Red, Color.Orange,Color.Yellow,Color.Green,Color.Blue,Color.Gray,Color.Purple,
            Color.Pink,Color.Ivory,Color.Chocolate,Color.LemonChiffon,Color.Brown,Color.Violet,Color.HotPink,Color.Lime };

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAlgorithm.Items.Add("FCFS");
            cmbAlgorithm.Items.Add("RR");
            cmbAlgorithm.Items.Add("SPN");
            cmbAlgorithm.Items.Add("SRTN");
            cmbAlgorithm.Items.Add("HRRN");
            cmbAlgorithm.Items.Add("New Algorithm");

            cmbProcessor.Items.Add(1);
            cmbProcessor.Items.Add(2);
            cmbProcessor.Items.Add(3);
            cmbProcessor.Items.Add(4);

            cmbPcore.Items.Add(0);
            cmbPcore.Items.Add(1);
            cmbPcore.Items.Add(2);
            cmbPcore.Items.Add(3);
            cmbPcore.Items.Add(4);
        }

        private void addListView(string p_name, string at, string bt)
        {
            ListViewItem process = new ListViewItem(new string[] { p_name, at, bt });

            // 리스트에 추가하는 코드
            int idx = processList.Count;
            processList.Add(new Process(p_name, int.Parse(at), int.Parse(bt), idx));

            timeTable.Items.Add(process);
            process.BackColor = bgColor[timeTable.Items.Count - 1];
            processName.Text = "";
            arrivalTime.Text = "";
            burstTime.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (burstTime.Text == "" || arrivalTime.Text == "" || processName.Text == "")
                {
                    MessageBox.Show("입력하지 않은 값이 있습니다.");
                }

                else if (timeTable.Items.Count >= 15)
                {
                    MessageBox.Show("최대 프로세스 개수를 초과했습니다.");
                }

                else
                {
                    addListView(processName.Text, arrivalTime.Text, burstTime.Text);
                    processName.Focus();
                }
            }
        }

        private void timeTable_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = timeTable.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timeTable.Items.Clear();

        }

        private void timeTable_ColumnSizeAutoChange(ListView LV)
        {
            LV.Columns[LV.Columns.Count - 1].Width = -2;
        }

        private void timeTable_Resize(object sender, EventArgs e)
        {
            timeTable_ColumnSizeAutoChange((ListView)sender);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (burstTime.Text == "" || processName.Text == "")
            {
                MessageBox.Show("입력하지 않은 값이 있습니다.");
            }

            else if (timeTable.Items.Count >= 15)
            {
                MessageBox.Show("최대 프로세스 개수를 초과했습니다.");
            }

            else
            {
                addListView(processName.Text, arrivalTime.Text, burstTime.Text);
                processName.Focus();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbProcessor.Text == "" || cmbPcore.Text == "")
            {
                MessageBox.Show("입력하지 않은 값이 있습니다.");
            }

            else if (int.Parse(cmbProcessor.Text) < int.Parse(cmbPcore.Text))
            {
                MessageBox.Show("유효하지 않은 P Core 값입니다.");
            }

            else
            {
                TableLayoutPanel[] processors = { processor1, processor2, processor3, processor4 };
                Label[] texts = { LBLProcessor1, LBLProcessor2, LBLProcessor3, LBLProcessor4 };

                int processorNum = int.Parse(cmbProcessor.Text);
                int pCoreNum = int.Parse(cmbPcore.Text);

                processorArray = new Processor[processorNum];


                for (int i = processorNum-1; i >= 0; i--)
                {
                    tableLayouts.Add(processors[processorNum - i - 1]);

                    tableLayouts[processorNum - i - 1].Visible = true;
                    if (i >= pCoreNum)
                    {
                        texts[processorNum - i -1].Text = "e Processor" + (processorNum - i);
                        processorArray[processorNum - i -1] = new Processor(texts[processorNum - i - 1].Text, "e");
                    }
                    else
                    {
                        texts[processorNum - i - 1].Text = "p Processor" + (processorNum - i);
                        processorArray[processorNum - i - 1] = new Processor(texts[processorNum - i - 1].Text, "p");
                    }
                    texts[i].Visible = true;
                }

                time = 0;   // 위치 이동
                timer.Start();  // 위치 이동

                if (cmbAlgorithm.SelectedItem.ToString() == "FCFS")
                {
                    FCFS fcfs = new FCFS(processList, ReadyQueue, processorArray);
                    timer2.Tick += new EventHandler(fcfs.Event);
                    timer2.Start();
                }

                else if (cmbAlgorithm.SelectedItem.ToString() == "HRRN")
                {
                    HRRN hrrn = new HRRN(processList, ReadyQueue, processorArray);
                    timer2.Tick += new EventHandler(hrrn.Event);    // 추가한 코드
                    timer2.Start(); // 추가한 코드
                }

                else if (cmbAlgorithm.SelectedItem.ToString() == "SPN")
                {
                    SPN spn = new SPN(processList, ReadyQueue, processorArray);
                    timer2.Tick += new EventHandler(spn.Event);    // 추가한 코드
                    timer2.Start(); // 추가한 코드
                }
                else if (cmbAlgorithm.SelectedItem.ToString() == "SRTN")
                {
                    SRTN srtn = new SRTN(processList, ReadyQueue, processorArray);
                    timer2.Tick += new EventHandler(srtn.Event);    // 추가한 코드
                    timer2.Start(); // 추가한 코드
                }
                else if ((cmbAlgorithm.SelectedItem.ToString() == "RR"))
                {
                    if (timeQuantunm.Text == "" || Int32.Parse(timeQuantunm.Text) <= 0)
                    {
                        MessageBox.Show("timeQuantunm값을 넣어주세요!");
                    }
                    else
                    {
                        RR rr = new RR(processList, ReadyQueue, processorArray, Int32.Parse(timeQuantunm.Text));
                        timer2.Tick += new EventHandler(rr.Event);
                        timer2.Start();
                    }
                }
            }
        }

        public void stopTimer(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timerTick(object sender, EventArgs e)
        {
            LBLTime.Text = (time).ToString();

            if (processList.Count == 0)
            {
                timer.Stop();
                timer2.Stop();
            }

            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < ReadyQueue.Count; i++)
            {
                Label ps = new Label();
                ps.Text = ReadyQueue[i].name;
                int idx = ReadyQueue[i].index;

                tableLayoutPanel1.Controls.Add(ps);
                tableLayoutPanel1.Controls[i].BackColor = bgColor[idx];  // 레디큐에 색깔 삽입
            }

            for (int i = 0; i < int.Parse(cmbProcessor.Text); i++)
            {
                List<Process> psList = processorArray[i].getRunningProcess();
                
                tableLayouts[i].Controls.Clear();
                for (int j = 0; j < psList.Count; j++)
                {
                    Label ps = new Label();
                    ps.Text = psList[j].name;
                    int idx = psList[j].index;

                    tableLayouts[i].Controls.Add(ps);
                    tableLayouts[i].Controls[j].BackColor = bgColor[idx];  // 간트차트에 색깔 삽입
                }              
            }

            ++time;
        }
    }
            
}
