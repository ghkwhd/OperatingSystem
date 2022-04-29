
namespace OperatingSystem
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBLalgorithm = new System.Windows.Forms.Label();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.cmbProcessor = new System.Windows.Forms.ComboBox();
            this.LBLproceorNum = new System.Windows.Forms.Label();
            this.cmbPcore = new System.Windows.Forms.ComboBox();
            this.LBLPcore = new System.Windows.Forms.Label();
            this.LBLProcess = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.TextBox();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.LBLArrival = new System.Windows.Forms.Label();
            this.burstTime = new System.Windows.Forms.TextBox();
            this.LBLBurst = new System.Windows.Forms.Label();
            this.timeQuantunm = new System.Windows.Forms.TextBox();
            this.LBLTimequantum = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.LBLTimeTable = new System.Windows.Forms.Label();
            this.timeTable = new System.Windows.Forms.ListView();
            this.column_Process_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Arrival_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Burst_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBLQueue = new System.Windows.Forms.Label();
            this.LBLProcessor1 = new System.Windows.Forms.Label();
            this.LBLProcessor2 = new System.Windows.Forms.Label();
            this.LBLProcessor3 = new System.Windows.Forms.Label();
            this.LBLProcessor4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.LBLTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processor1 = new System.Windows.Forms.TableLayoutPanel();
            this.processor2 = new System.Windows.Forms.TableLayoutPanel();
            this.processor3 = new System.Windows.Forms.TableLayoutPanel();
            this.processor4 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // LBLalgorithm
            // 
            this.LBLalgorithm.AutoSize = true;
            this.LBLalgorithm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLalgorithm.Location = new System.Drawing.Point(12, 9);
            this.LBLalgorithm.Name = "LBLalgorithm";
            this.LBLalgorithm.Size = new System.Drawing.Size(111, 20);
            this.LBLalgorithm.TabIndex = 0;
            this.LBLalgorithm.Text = "Algorithm List";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(14, 38);
            this.cmbAlgorithm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(143, 28);
            this.cmbAlgorithm.TabIndex = 1;
            // 
            // cmbProcessor
            // 
            this.cmbProcessor.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbProcessor.FormattingEnabled = true;
            this.cmbProcessor.Location = new System.Drawing.Point(14, 90);
            this.cmbProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(143, 28);
            this.cmbProcessor.TabIndex = 3;
            // 
            // LBLproceorNum
            // 
            this.LBLproceorNum.AutoSize = true;
            this.LBLproceorNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLproceorNum.Location = new System.Drawing.Point(17, 68);
            this.LBLproceorNum.Name = "LBLproceorNum";
            this.LBLproceorNum.Size = new System.Drawing.Size(141, 20);
            this.LBLproceorNum.TabIndex = 2;
            this.LBLproceorNum.Text = "num of Processors";
            // 
            // cmbPcore
            // 
            this.cmbPcore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbPcore.FormattingEnabled = true;
            this.cmbPcore.Location = new System.Drawing.Point(14, 142);
            this.cmbPcore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPcore.Name = "cmbPcore";
            this.cmbPcore.Size = new System.Drawing.Size(143, 28);
            this.cmbPcore.TabIndex = 5;
            // 
            // LBLPcore
            // 
            this.LBLPcore.AutoSize = true;
            this.LBLPcore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLPcore.Location = new System.Drawing.Point(10, 120);
            this.LBLPcore.Name = "LBLPcore";
            this.LBLPcore.Size = new System.Drawing.Size(105, 20);
            this.LBLPcore.TabIndex = 4;
            this.LBLPcore.Text = "num of Pcore";
            // 
            // LBLProcess
            // 
            this.LBLProcess.AutoSize = true;
            this.LBLProcess.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcess.Location = new System.Drawing.Point(10, 173);
            this.LBLProcess.Name = "LBLProcess";
            this.LBLProcess.Size = new System.Drawing.Size(109, 20);
            this.LBLProcess.TabIndex = 6;
            this.LBLProcess.Text = "Process Name";
            // 
            // processName
            // 
            this.processName.Location = new System.Drawing.Point(14, 195);
            this.processName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(143, 25);
            this.processName.TabIndex = 7;
            this.processName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(14, 247);
            this.arrivalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(143, 25);
            this.arrivalTime.TabIndex = 9;
            this.arrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.arrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // LBLArrival
            // 
            this.LBLArrival.AutoSize = true;
            this.LBLArrival.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLArrival.Location = new System.Drawing.Point(10, 222);
            this.LBLArrival.Name = "LBLArrival";
            this.LBLArrival.Size = new System.Drawing.Size(96, 20);
            this.LBLArrival.TabIndex = 8;
            this.LBLArrival.Text = "Arrival Time";
            // 
            // burstTime
            // 
            this.burstTime.Location = new System.Drawing.Point(14, 299);
            this.burstTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.burstTime.Name = "burstTime";
            this.burstTime.Size = new System.Drawing.Size(143, 25);
            this.burstTime.TabIndex = 11;
            this.burstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burstTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // LBLBurst
            // 
            this.LBLBurst.AutoSize = true;
            this.LBLBurst.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLBurst.Location = new System.Drawing.Point(10, 277);
            this.LBLBurst.Name = "LBLBurst";
            this.LBLBurst.Size = new System.Drawing.Size(87, 20);
            this.LBLBurst.TabIndex = 10;
            this.LBLBurst.Text = "Burst Time";
            // 
            // timeQuantunm
            // 
            this.timeQuantunm.Location = new System.Drawing.Point(14, 352);
            this.timeQuantunm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeQuantunm.Name = "timeQuantunm";
            this.timeQuantunm.Size = new System.Drawing.Size(143, 25);
            this.timeQuantunm.TabIndex = 13;
            this.timeQuantunm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeQuantunm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // LBLTimequantum
            // 
            this.LBLTimequantum.AutoSize = true;
            this.LBLTimequantum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimequantum.Location = new System.Drawing.Point(10, 326);
            this.LBLTimequantum.Name = "LBLTimequantum";
            this.LBLTimequantum.Size = new System.Drawing.Size(147, 20);
            this.LBLTimequantum.TabIndex = 12;
            this.LBLTimequantum.Text = "RR Time quantunm";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(14, 387);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 32);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(88, 387);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 32);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(14, 430);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 34);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // LBLTimeTable
            // 
            this.LBLTimeTable.AutoSize = true;
            this.LBLTimeTable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimeTable.Location = new System.Drawing.Point(166, 9);
            this.LBLTimeTable.Name = "LBLTimeTable";
            this.LBLTimeTable.Size = new System.Drawing.Size(87, 20);
            this.LBLTimeTable.TabIndex = 17;
            this.LBLTimeTable.Text = "Time Tabel";
            // 
            // timeTable
            // 
            this.timeTable.BackColor = System.Drawing.Color.White;
            this.timeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Process_Name,
            this.column_Arrival_Time,
            this.column_Burst_Time});
            this.timeTable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeTable.GridLines = true;
            this.timeTable.HideSelection = false;
            this.timeTable.Location = new System.Drawing.Point(170, 43);
            this.timeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(442, 410);
            this.timeTable.TabIndex = 18;
            this.timeTable.UseCompatibleStateImageBehavior = false;
            this.timeTable.View = System.Windows.Forms.View.Details;
            this.timeTable.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.timeTable_ColumnWidthChanging);
            this.timeTable.Resize += new System.EventHandler(this.timeTable_Resize);
            // 
            // column_Process_Name
            // 
            this.column_Process_Name.Text = "Process Name";
            this.column_Process_Name.Width = 155;
            // 
            // column_Arrival_Time
            // 
            this.column_Arrival_Time.Text = "Arrival Time";
            this.column_Arrival_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Arrival_Time.Width = 107;
            // 
            // column_Burst_Time
            // 
            this.column_Burst_Time.Text = "Burst Time";
            this.column_Burst_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Burst_Time.Width = 173;
            // 
            // LBLQueue
            // 
            this.LBLQueue.AutoSize = true;
            this.LBLQueue.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLQueue.Location = new System.Drawing.Point(618, 9);
            this.LBLQueue.Name = "LBLQueue";
            this.LBLQueue.Size = new System.Drawing.Size(103, 20);
            this.LBLQueue.TabIndex = 19;
            this.LBLQueue.Text = "Ready Queue";
            // 
            // LBLProcessor1
            // 
            this.LBLProcessor1.AutoSize = true;
            this.LBLProcessor1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor1.Location = new System.Drawing.Point(618, 134);
            this.LBLProcessor1.Name = "LBLProcessor1";
            this.LBLProcessor1.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor1.TabIndex = 21;
            this.LBLProcessor1.Text = "Processor1";
            this.LBLProcessor1.Visible = false;
            // 
            // LBLProcessor2
            // 
            this.LBLProcessor2.AutoSize = true;
            this.LBLProcessor2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor2.Location = new System.Drawing.Point(618, 215);
            this.LBLProcessor2.Name = "LBLProcessor2";
            this.LBLProcessor2.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor2.TabIndex = 22;
            this.LBLProcessor2.Text = "Processor2";
            this.LBLProcessor2.Visible = false;
            // 
            // LBLProcessor3
            // 
            this.LBLProcessor3.AutoSize = true;
            this.LBLProcessor3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor3.Location = new System.Drawing.Point(618, 304);
            this.LBLProcessor3.Name = "LBLProcessor3";
            this.LBLProcessor3.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor3.TabIndex = 23;
            this.LBLProcessor3.Text = "Processor3";
            this.LBLProcessor3.Visible = false;
            // 
            // LBLProcessor4
            // 
            this.LBLProcessor4.AutoSize = true;
            this.LBLProcessor4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor4.Location = new System.Drawing.Point(618, 387);
            this.LBLProcessor4.Name = "LBLProcessor4";
            this.LBLProcessor4.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor4.TabIndex = 24;
            this.LBLProcessor4.Text = "Processor4";
            this.LBLProcessor4.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(88, 430);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(69, 34);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.stopTimer);
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTime.Location = new System.Drawing.Point(534, 9);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(44, 20);
            this.LBLTime.TabIndex = 26;
            this.LBLTime.Text = "Time";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 15;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(622, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 49);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // processor1
            // 
            this.processor1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.processor1.ColumnCount = 15;
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.processor1.Location = new System.Drawing.Point(622, 159);
            this.processor1.Name = "processor1";
            this.processor1.RowCount = 1;
            this.processor1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor1.Size = new System.Drawing.Size(517, 43);
            this.processor1.TabIndex = 29;
            this.processor1.Visible = false;
            // 
            // processor2
            // 
            this.processor2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.processor2.ColumnCount = 15;
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.processor2.Location = new System.Drawing.Point(622, 238);
            this.processor2.Name = "processor2";
            this.processor2.RowCount = 1;
            this.processor2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor2.Size = new System.Drawing.Size(517, 43);
            this.processor2.TabIndex = 30;
            this.processor2.Visible = false;
            // 
            // processor3
            // 
            this.processor3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.processor3.ColumnCount = 15;
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.processor3.Location = new System.Drawing.Point(622, 327);
            this.processor3.Name = "processor3";
            this.processor3.RowCount = 1;
            this.processor3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor3.Size = new System.Drawing.Size(517, 45);
            this.processor3.TabIndex = 31;
            this.processor3.Visible = false;
            // 
            // processor4
            // 
            this.processor4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.processor4.ColumnCount = 15;
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.processor4.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.processor4.Location = new System.Drawing.Point(622, 410);
            this.processor4.Name = "processor4";
            this.processor4.RowCount = 1;
            this.processor4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor4.Size = new System.Drawing.Size(517, 43);
            this.processor4.TabIndex = 32;
            this.processor4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 485);
            this.Controls.Add(this.processor4);
            this.Controls.Add(this.processor3);
            this.Controls.Add(this.processor2);
            this.Controls.Add(this.processor1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LBLTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.LBLProcessor4);
            this.Controls.Add(this.LBLProcessor3);
            this.Controls.Add(this.LBLProcessor2);
            this.Controls.Add(this.LBLProcessor1);
            this.Controls.Add(this.LBLQueue);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.LBLTimeTable);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.timeQuantunm);
            this.Controls.Add(this.LBLTimequantum);
            this.Controls.Add(this.burstTime);
            this.Controls.Add(this.LBLBurst);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.LBLArrival);
            this.Controls.Add(this.processName);
            this.Controls.Add(this.LBLProcess);
            this.Controls.Add(this.cmbPcore);
            this.Controls.Add(this.LBLPcore);
            this.Controls.Add(this.cmbProcessor);
            this.Controls.Add(this.LBLproceorNum);
            this.Controls.Add(this.cmbAlgorithm);
            this.Controls.Add(this.LBLalgorithm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Process Scheduling Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLalgorithm;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.ComboBox cmbProcessor;
        private System.Windows.Forms.Label LBLproceorNum;
        private System.Windows.Forms.ComboBox cmbPcore;
        private System.Windows.Forms.Label LBLPcore;
        private System.Windows.Forms.Label LBLProcess;
        private System.Windows.Forms.TextBox processName;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.Label LBLArrival;
        private System.Windows.Forms.Label LBLBurst;
        private System.Windows.Forms.TextBox timeQuantunm;
        private System.Windows.Forms.Label LBLTimequantum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label LBLTimeTable;
        private System.Windows.Forms.ListView timeTable;
        private System.Windows.Forms.ColumnHeader column_Process_Name;
        private System.Windows.Forms.ColumnHeader column_Arrival_Time;
        private System.Windows.Forms.ColumnHeader column_Burst_Time;
        private System.Windows.Forms.Label LBLQueue;
        private System.Windows.Forms.Label LBLProcessor1;
        private System.Windows.Forms.Label LBLProcessor2;
        private System.Windows.Forms.Label LBLProcessor3;
        private System.Windows.Forms.Label LBLProcessor4;
        private System.Windows.Forms.TextBox burstTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label LBLTime;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel processor1;
        private System.Windows.Forms.TableLayoutPanel processor2;
        private System.Windows.Forms.TableLayoutPanel processor3;
        private System.Windows.Forms.TableLayoutPanel processor4;
    }
}

