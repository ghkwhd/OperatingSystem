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
        DataSet process_DS = new DataSet(); // process들에 대한 정보를 가지고 있을 Dataset
        DataSet processor_DS = new DataSet(); // processor들에 대한 정보를 가지고 있을 Dataset
        DataSet watt_dataset = new DataSet(); //소비전력 데이터 테이블을 위한 데이터셋
        public static int time = 0;
        static List<Process> processList = new List<Process>();
        static List<Process> processCopyList = new List<Process>();
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
            processList.Clear();
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
            // 프로세스 리스트의 깊은 복사
            processCopyList = processList.ConvertAll(p => new Process(p.name, p.At, p.Bt, p.index));

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
                    SPN spn = new SPN(processList, processCopyList, ReadyQueue, processorArray);
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

                for (int i = 0; i < processCopyList.Count; i++)
                {
                    bool isTable = false;

                    if (process_DS.Tables.Contains("Process_ResultTable"))
                    {
                        isTable = true;
                    }

                    DataTable dt = null;

                    if (!isTable)
                    {
                        dt = new DataTable("Process_ResultTable");

                        DataColumn colProcessName = new DataColumn("Process Name", typeof(string));
                        DataColumn colAT = new DataColumn("Arrival Time(AT)", typeof(int));
                        DataColumn colBT = new DataColumn("Burst Time(BT)", typeof(int));
                        DataColumn colWT = new DataColumn("Wating Time(WT)", typeof(int));
                        DataColumn colTT = new DataColumn("Turnaround Time(TT)", typeof(int));
                        DataColumn colNTT = new DataColumn("Normalized TT(NTT)", typeof(float));

                        dt.Columns.Add(colProcessName);
                        dt.Columns.Add(colAT);
                        dt.Columns.Add(colBT);
                        dt.Columns.Add(colWT);
                        dt.Columns.Add(colTT);
                        dt.Columns.Add(colNTT);
                    }

                    else
                    {
                        dt = process_DS.Tables["Process_ResultTable"];
                    }

                    // Row 자료를 등록
                    DataRow row = dt.NewRow();

                    row["Process Name"] = processCopyList[i].name;
                    row["Arrival Time(AT)"] = processCopyList[i].At;
                    row["Burst Time(BT)"] = processCopyList[i].Bt;
                    row["Wating Time(WT)"] = processCopyList[i].Tt - processCopyList[i].Bt;
                    row["Turnaround Time(TT)"] = processCopyList[i].Tt;
                    row["Normalized TT(NTT)"] = processCopyList[i].Tt / processCopyList[i].Bt;

                    // 생성된 row를 데이터 테이블 dt에 삽입
                    if (isTable) { process_DS.Tables["Process_ResultTable"].Rows.Add(row); } // 이미 테이블이 있다면 교체
                    else
                    {
                        dt.Rows.Add(row);
                        process_DS.Tables.Add(dt);
                    }

                }

                processResultTable.DataSource = process_DS.Tables["Process_ResultTable"];

                foreach (DataGridViewRow oRow in processResultTable.Rows)
                {
                    oRow.HeaderCell.Value = oRow.Index.ToString();
                }
                processResultTable.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);


                //소비 전력 구하는 부분
                int processorNum1 = int.Parse(cmbProcessor.Text);
                int pCoreNum1 = int.Parse(cmbPcore.Text);


                DataTable watt_table = new DataTable();
               

                watt_table.Columns.Add(new DataColumn("Processor Name", typeof(string)));
                watt_table.Columns.Add(new DataColumn("Core Type", typeof(string)));
                watt_table.Columns.Add(new DataColumn("Using Watt", typeof(double)));
                

                for (int i = 0; i < processorArray.Length; i++)
                {
                    Console.WriteLine(processorArray[i].runningTime);
                    DataRow row = watt_table.NewRow();
                    row["Processor Name"] = processorArray[i].getName();
                    row["Core Type"] = processorArray[i].getType();
                    
                    if (i < pCoreNum1)
                    {
                        row["Using Watt"] = ((processorArray[i].runningTime) * 3) + ((time - (processorArray[i].runningTime)) * 0.1);
                       
                    }
                    else
                    {
                        row["Using Watt"] = ((processorArray[i].runningTime) * 1) + ((time - (processorArray[i].runningTime)) * 0.1);
                    }
                    watt_table.Rows.Add(row);
                }
                watt_dataGridView.DataSource = watt_table;
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
                if (processorArray[i].runningState())
                {
                    Label ps = new Label();
                    ps.Text = processorArray[i].getLastProcess().name;                    
                    int idx = processorArray[i].getLastProcess().index;
                    ps.BackColor = bgColor[idx];  // 간트차트에 색깔 삽입

                    tableLayouts[i].Controls.Add(ps);
                }

                else
                {
                    Label ps = new Label();
                    tableLayouts[i].Controls.Add(ps);
                }

                //List<Process> psList = processorArray[i].getRunningProcess();
                
                //tableLayouts[i].Controls.Clear();
                //for (int j = 0; j < psList.Count; j++)
                //{
                //    Label ps = new Label();
                //    ps.Text = psList[j].name;
                //    int idx = psList[j].index;

                //    tableLayouts[i].Controls.Add(ps);
                //    tableLayouts[i].Controls[j].BackColor = bgColor[idx];  // 간트차트에 색깔 삽입
                //}              
            }

            ++time;
        }

        private void timeTable_SelectedIndexChanged(object sender, EventArgs e)
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void processor1_Paint(object sender, PaintEventArgs e)
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        private void cmbPcore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        private void processResultTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void processName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
            
}
