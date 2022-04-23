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
        public static Form1 form1 = new Form1();
        public static string running;

        static int pnum;
        public static int time = 0;
        static int LBLidx = 0;

        private Label[] LBL = new Label[15];    // Label 배열

        static List<string> pname = new List<string>();
        static List<int> arrival = new List<int>();
        static List<int> burst = new List<int>();

        public Form1()
        {
            InitializeComponent();

            form1 = this;

            for (int i = 0; i < 15; i++)
            {
                LBL[i] = new Label();
                LBL[i].Location = new System.Drawing.Point(3 + 36*i, 3);
                LBL[i].Size = new System.Drawing.Size(29, 43);
                LBL[i].Name = "label" + i;
                tableLayoutPanel1.Controls.Add(LBL[i]);
            }

            
        }

        //string p_name, bt, at;
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

        private void addListView(string p_name,string at,string bt)
        {
            ListViewItem process = new ListViewItem(new string[] { p_name, at, bt });
            
            // 리스트에 추가하는 코드
            pname.Add(p_name);
            arrival.Add(int.Parse(at));
            burst.Add(int.Parse(bt));

            timeTable.Items.Add(process);
            process.BackColor = bgColor[timeTable.Items.Count - 1];
            processName.Text = "";
            arrivalTime.Text = "";
            burstTime.Text = "";
        }

        private void cmbPcore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void timeTable_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            /*
            p_name = processName.Text;
            at = arrivalTime.Text;
            bt = burstTime.Text;
            */
            if (burstTime.Text == "" || arrivalTime.Text == "" || processName.Text == "")
            {
                MessageBox.Show("입력하지 않은 값이 있습니다.");
            }
            else if(timeTable.Items.Count >= 15)
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
            HRRN hrrn = new HRRN(pname, arrival, burst);

            time = 0;
            timer.Start();
            if (cmbAlgorithm.SelectedItem.ToString() == "HRRN")
                hrrn.startHRRN();

            pnum = pname.Count();
        }

        public void stopTimer(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timerTick(object sender, EventArgs e)
        {
            label1.Text = running;
            LBLTime.Text = time.ToString();
            
            LBLidx = 0;

            for (int i = 0; i < pnum; i++)
                LBL[i].Text = "";

            for (int i = 0; i < arrival.Count(); i++)
            {
                if(arrival[i] <= time)
                {
                    LBL[LBLidx].Text = pname[i];
                    LBLidx++;
                }
            }

            ++time;
            if (arrival.Count == 0)
                timer.Stop();
        }

    }
}
