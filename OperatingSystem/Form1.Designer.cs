
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.LBLTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processor4 = new System.Windows.Forms.TableLayoutPanel();
            this.processor3 = new System.Windows.Forms.TableLayoutPanel();
            this.processor2 = new System.Windows.Forms.TableLayoutPanel();
            this.processor1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBLProcessor4 = new System.Windows.Forms.Label();
            this.LBLProcessor3 = new System.Windows.Forms.Label();
            this.LBLProcessor2 = new System.Windows.Forms.Label();
            this.LBLProcessor1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.processResultTable = new System.Windows.Forms.DataGridView();
            this.processorResultTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processResultTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLalgorithm
            // 
            this.LBLalgorithm.AutoSize = true;
            this.LBLalgorithm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLalgorithm.Location = new System.Drawing.Point(10, 7);
            this.LBLalgorithm.Name = "LBLalgorithm";
            this.LBLalgorithm.Size = new System.Drawing.Size(88, 15);
            this.LBLalgorithm.TabIndex = 0;
            this.LBLalgorithm.Text = "Algorithm List";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(12, 30);
            this.cmbAlgorithm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(126, 23);
            this.cmbAlgorithm.TabIndex = 1;
            // 
            // cmbProcessor
            // 
            this.cmbProcessor.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbProcessor.FormattingEnabled = true;
            this.cmbProcessor.Location = new System.Drawing.Point(12, 72);
            this.cmbProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(126, 23);
            this.cmbProcessor.TabIndex = 3;
            // 
            // LBLproceorNum
            // 
            this.LBLproceorNum.AutoSize = true;
            this.LBLproceorNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLproceorNum.Location = new System.Drawing.Point(15, 54);
            this.LBLproceorNum.Name = "LBLproceorNum";
            this.LBLproceorNum.Size = new System.Drawing.Size(113, 15);
            this.LBLproceorNum.TabIndex = 2;
            this.LBLproceorNum.Text = "num of Processors";
            // 
            // cmbPcore
            // 
            this.cmbPcore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbPcore.FormattingEnabled = true;
            this.cmbPcore.Location = new System.Drawing.Point(12, 114);
            this.cmbPcore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPcore.Name = "cmbPcore";
            this.cmbPcore.Size = new System.Drawing.Size(126, 23);
            this.cmbPcore.TabIndex = 5;
            this.cmbPcore.SelectedIndexChanged += new System.EventHandler(this.cmbPcore_SelectedIndexChanged);
            // 
            // LBLPcore
            // 
            this.LBLPcore.AutoSize = true;
            this.LBLPcore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLPcore.Location = new System.Drawing.Point(9, 96);
            this.LBLPcore.Name = "LBLPcore";
            this.LBLPcore.Size = new System.Drawing.Size(83, 15);
            this.LBLPcore.TabIndex = 4;
            this.LBLPcore.Text = "num of Pcore";
            // 
            // LBLProcess
            // 
            this.LBLProcess.AutoSize = true;
            this.LBLProcess.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcess.Location = new System.Drawing.Point(9, 138);
            this.LBLProcess.Name = "LBLProcess";
            this.LBLProcess.Size = new System.Drawing.Size(90, 15);
            this.LBLProcess.TabIndex = 6;
            this.LBLProcess.Text = "Process Name";
            // 
            // processName
            // 
            this.processName.Location = new System.Drawing.Point(12, 156);
            this.processName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(126, 21);
            this.processName.TabIndex = 7;
            this.processName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.processName.TextChanged += new System.EventHandler(this.processName_TextChanged);
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(12, 198);
            this.arrivalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(126, 21);
            this.arrivalTime.TabIndex = 9;
            this.arrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.arrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // LBLArrival
            // 
            this.LBLArrival.AutoSize = true;
            this.LBLArrival.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLArrival.Location = new System.Drawing.Point(9, 178);
            this.LBLArrival.Name = "LBLArrival";
            this.LBLArrival.Size = new System.Drawing.Size(76, 15);
            this.LBLArrival.TabIndex = 8;
            this.LBLArrival.Text = "Arrival Time";
            // 
            // burstTime
            // 
            this.burstTime.Location = new System.Drawing.Point(12, 239);
            this.burstTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.burstTime.Name = "burstTime";
            this.burstTime.Size = new System.Drawing.Size(126, 21);
            this.burstTime.TabIndex = 11;
            this.burstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burstTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // LBLBurst
            // 
            this.LBLBurst.AutoSize = true;
            this.LBLBurst.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLBurst.Location = new System.Drawing.Point(9, 222);
            this.LBLBurst.Name = "LBLBurst";
            this.LBLBurst.Size = new System.Drawing.Size(70, 15);
            this.LBLBurst.TabIndex = 10;
            this.LBLBurst.Text = "Burst Time";
            // 
            // timeQuantunm
            // 
            this.timeQuantunm.Location = new System.Drawing.Point(12, 282);
            this.timeQuantunm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeQuantunm.Name = "timeQuantunm";
            this.timeQuantunm.Size = new System.Drawing.Size(126, 21);
            this.timeQuantunm.TabIndex = 13;
            this.timeQuantunm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeQuantunm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // LBLTimequantum
            // 
            this.LBLTimequantum.AutoSize = true;
            this.LBLTimequantum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimequantum.Location = new System.Drawing.Point(9, 261);
            this.LBLTimequantum.Name = "LBLTimequantum";
            this.LBLTimequantum.Size = new System.Drawing.Size(118, 15);
            this.LBLTimequantum.TabIndex = 12;
            this.LBLTimequantum.Text = "RR Time quantunm";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(12, 310);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 26);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(77, 310);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 26);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(12, 344);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 27);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // LBLTimeTable
            // 
            this.LBLTimeTable.AutoSize = true;
            this.LBLTimeTable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimeTable.Location = new System.Drawing.Point(145, 7);
            this.LBLTimeTable.Name = "LBLTimeTable";
            this.LBLTimeTable.Size = new System.Drawing.Size(71, 15);
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
            this.timeTable.Location = new System.Drawing.Point(149, 34);
            this.timeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(387, 329);
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
            this.LBLQueue.Location = new System.Drawing.Point(541, 7);
            this.LBLQueue.Name = "LBLQueue";
            this.LBLQueue.Size = new System.Drawing.Size(84, 15);
            this.LBLQueue.TabIndex = 19;
            this.LBLQueue.Text = "Ready Queue";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(77, 344);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 27);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.stopTimer);
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTime.Location = new System.Drawing.Point(467, 7);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(35, 15);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(544, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 39);
            this.tableLayoutPanel1.TabIndex = 28;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.processor4.Location = new System.Drawing.Point(544, 327);
            this.processor4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processor4.Name = "processor4";
            this.processor4.RowCount = 1;
            this.processor4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor4.Size = new System.Drawing.Size(452, 34);
            this.processor4.TabIndex = 40;
            this.processor4.Visible = false;
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
            this.processor3.Location = new System.Drawing.Point(544, 262);
            this.processor3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processor3.Name = "processor3";
            this.processor3.RowCount = 1;
            this.processor3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor3.Size = new System.Drawing.Size(452, 36);
            this.processor3.TabIndex = 39;
            this.processor3.Visible = false;
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
            this.processor2.Location = new System.Drawing.Point(544, 190);
            this.processor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processor2.Name = "processor2";
            this.processor2.RowCount = 1;
            this.processor2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor2.Size = new System.Drawing.Size(452, 34);
            this.processor2.TabIndex = 38;
            this.processor2.Visible = false;
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
            this.processor1.Location = new System.Drawing.Point(544, 106);
            this.processor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processor1.Name = "processor1";
            this.processor1.RowCount = 1;
            this.processor1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processor1.Size = new System.Drawing.Size(452, 38);
            this.processor1.TabIndex = 37;
            this.processor1.Visible = false;
            // 
            // LBLProcessor4
            // 
            this.LBLProcessor4.AutoSize = true;
            this.LBLProcessor4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor4.Location = new System.Drawing.Point(541, 310);
            this.LBLProcessor4.Name = "LBLProcessor4";
            this.LBLProcessor4.Size = new System.Drawing.Size(70, 15);
            this.LBLProcessor4.TabIndex = 36;
            this.LBLProcessor4.Text = "Processor4";
            this.LBLProcessor4.Visible = false;
            // 
            // LBLProcessor3
            // 
            this.LBLProcessor3.AutoSize = true;
            this.LBLProcessor3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor3.Location = new System.Drawing.Point(541, 242);
            this.LBLProcessor3.Name = "LBLProcessor3";
            this.LBLProcessor3.Size = new System.Drawing.Size(70, 15);
            this.LBLProcessor3.TabIndex = 35;
            this.LBLProcessor3.Text = "Processor3";
            this.LBLProcessor3.Visible = false;
            // 
            // LBLProcessor2
            // 
            this.LBLProcessor2.AutoSize = true;
            this.LBLProcessor2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor2.Location = new System.Drawing.Point(541, 171);
            this.LBLProcessor2.Name = "LBLProcessor2";
            this.LBLProcessor2.Size = new System.Drawing.Size(70, 15);
            this.LBLProcessor2.TabIndex = 34;
            this.LBLProcessor2.Text = "Processor2";
            this.LBLProcessor2.Visible = false;
            // 
            // LBLProcessor1
            // 
            this.LBLProcessor1.AutoSize = true;
            this.LBLProcessor1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor1.Location = new System.Drawing.Point(541, 86);
            this.LBLProcessor1.Name = "LBLProcessor1";
            this.LBLProcessor1.Size = new System.Drawing.Size(70, 15);
            this.LBLProcessor1.TabIndex = 33;
            this.LBLProcessor1.Text = "Processor1";
            this.LBLProcessor1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 291);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ResultTable";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.processResultTable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.processorResultTable, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 11);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 277);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // processResultTable
            // 
            this.processResultTable.AllowUserToAddRows = false;
            this.processResultTable.AllowUserToDeleteRows = false;
            this.processResultTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.processResultTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.processResultTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.processResultTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processResultTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.processResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processResultTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.processResultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processResultTable.GridColor = System.Drawing.SystemColors.Control;
            this.processResultTable.Location = new System.Drawing.Point(3, 3);
            this.processResultTable.Name = "processResultTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.processResultTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.processResultTable.RowTemplate.Height = 23;
            this.processResultTable.Size = new System.Drawing.Size(500, 271);
            this.processResultTable.TabIndex = 0;
            this.processResultTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processResultTable_CellContentClick);
            // 
            // processorResultTable
            // 
            this.processorResultTable.AllowUserToAddRows = false;
            this.processorResultTable.AllowUserToDeleteRows = false;
            this.processorResultTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.processorResultTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processorResultTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processorResultTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.processorResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processorResultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processorResultTable.GridColor = System.Drawing.SystemColors.Control;
            this.processorResultTable.Location = new System.Drawing.Point(509, 3);
            this.processorResultTable.Name = "processorResultTable";
            this.processorResultTable.RowHeadersVisible = false;
            this.processorResultTable.RowTemplate.Height = 23;
            this.processorResultTable.Size = new System.Drawing.Size(500, 271);
            this.processorResultTable.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.processor4);
            this.Controls.Add(this.processor3);
            this.Controls.Add(this.processor2);
            this.Controls.Add(this.processor1);
            this.Controls.Add(this.LBLProcessor4);
            this.Controls.Add(this.LBLProcessor3);
            this.Controls.Add(this.LBLProcessor2);
            this.Controls.Add(this.LBLProcessor1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LBLTime);
            this.Controls.Add(this.btnStop);
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
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processResultTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorResultTable)).EndInit();
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
        private System.Windows.Forms.TextBox burstTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label LBLTime;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel processor4;
        private System.Windows.Forms.TableLayoutPanel processor3;
        private System.Windows.Forms.TableLayoutPanel processor2;
        private System.Windows.Forms.TableLayoutPanel processor1;
        private System.Windows.Forms.Label LBLProcessor4;
        private System.Windows.Forms.Label LBLProcessor3;
        private System.Windows.Forms.Label LBLProcessor2;
        private System.Windows.Forms.Label LBLProcessor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView processResultTable;
        private System.Windows.Forms.DataGridView processorResultTable;
    }
}

