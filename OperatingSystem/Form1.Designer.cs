
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.watt_dataGridView = new System.Windows.Forms.DataGridView();
            this.processResultTable = new System.Windows.Forms.DataGridView();
            this.LBLProcessor4 = new System.Windows.Forms.Label();
            this.LBLProcessor3 = new System.Windows.Forms.Label();
            this.LBLProcessor2 = new System.Windows.Forms.Label();
            this.LBLProcessor1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBLTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.LBLQueue = new System.Windows.Forms.Label();
            this.timeTable = new System.Windows.Forms.ListView();
            this.column_Process_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Arrival_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Burst_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDeadLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBLTimeTable = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.timeQuantunm = new System.Windows.Forms.TextBox();
            this.LBLTimequantum = new System.Windows.Forms.Label();
            this.burstTime = new System.Windows.Forms.TextBox();
            this.LBLBurst = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.LBLArrival = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.TextBox();
            this.LBLProcess = new System.Windows.Forms.Label();
            this.cmbPcore = new System.Windows.Forms.ComboBox();
            this.LBLPcore = new System.Windows.Forms.Label();
            this.cmbProcessor = new System.Windows.Forms.ComboBox();
            this.LBLproceorNum = new System.Windows.Forms.Label();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.LBLalgorithm = new System.Windows.Forms.Label();
            this.DeadLine = new System.Windows.Forms.TextBox();
            this.LBLDeadLine = new System.Windows.Forms.Label();
            this.DeadQueuePanel = new System.Windows.Forms.TableLayoutPanel();
            this.LBLDeadQueue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watt_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 633);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1262, 290);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ResultTable";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63819F));
            this.tableLayoutPanel2.Controls.Add(this.watt_dataGridView, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.processResultTable, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1256, 260);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // watt_dataGridView
            // 
            this.watt_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watt_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watt_dataGridView.Location = new System.Drawing.Point(911, 4);
            this.watt_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.watt_dataGridView.Name = "watt_dataGridView";
            this.watt_dataGridView.RowHeadersWidth = 51;
            this.watt_dataGridView.RowTemplate.Height = 23;
            this.watt_dataGridView.Size = new System.Drawing.Size(342, 252);
            this.watt_dataGridView.TabIndex = 42;
            // 
            // processResultTable
            // 
            this.processResultTable.AllowUserToAddRows = false;
            this.processResultTable.AllowUserToDeleteRows = false;
            this.processResultTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.processResultTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.processResultTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.processResultTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processResultTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.processResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processResultTable.DefaultCellStyle = dataGridViewCellStyle14;
            this.processResultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processResultTable.GridColor = System.Drawing.SystemColors.Control;
            this.processResultTable.Location = new System.Drawing.Point(3, 4);
            this.processResultTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processResultTable.Name = "processResultTable";
            this.processResultTable.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.processResultTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.processResultTable.RowTemplate.Height = 23;
            this.processResultTable.Size = new System.Drawing.Size(902, 252);
            this.processResultTable.TabIndex = 0;
            this.processResultTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.processResultTable_CellFormatting);
            // 
            // LBLProcessor4
            // 
            this.LBLProcessor4.AutoSize = true;
            this.LBLProcessor4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor4.Location = new System.Drawing.Point(651, 517);
            this.LBLProcessor4.Name = "LBLProcessor4";
            this.LBLProcessor4.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor4.TabIndex = 68;
            this.LBLProcessor4.Text = "Processor4";
            this.LBLProcessor4.Visible = false;
            // 
            // LBLProcessor3
            // 
            this.LBLProcessor3.AutoSize = true;
            this.LBLProcessor3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor3.Location = new System.Drawing.Point(651, 407);
            this.LBLProcessor3.Name = "LBLProcessor3";
            this.LBLProcessor3.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor3.TabIndex = 67;
            this.LBLProcessor3.Text = "Processor3";
            this.LBLProcessor3.Visible = false;
            // 
            // LBLProcessor2
            // 
            this.LBLProcessor2.AutoSize = true;
            this.LBLProcessor2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor2.Location = new System.Drawing.Point(651, 297);
            this.LBLProcessor2.Name = "LBLProcessor2";
            this.LBLProcessor2.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor2.TabIndex = 66;
            this.LBLProcessor2.Text = "Processor2";
            this.LBLProcessor2.Visible = false;
            // 
            // LBLProcessor1
            // 
            this.LBLProcessor1.AutoSize = true;
            this.LBLProcessor1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor1.Location = new System.Drawing.Point(651, 187);
            this.LBLProcessor1.Name = "LBLProcessor1";
            this.LBLProcessor1.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor1.TabIndex = 65;
            this.LBLProcessor1.Text = "Processor1";
            this.LBLProcessor1.Visible = false;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(655, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 49);
            this.tableLayoutPanel1.TabIndex = 64;
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTime.Location = new System.Drawing.Point(534, 5);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(44, 20);
            this.LBLTime.TabIndex = 63;
            this.LBLTime.Text = "Time";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(88, 483);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(69, 34);
            this.btnStop.TabIndex = 62;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.stopTimer);
            // 
            // LBLQueue
            // 
            this.LBLQueue.AutoSize = true;
            this.LBLQueue.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLQueue.Location = new System.Drawing.Point(651, 5);
            this.LBLQueue.Name = "LBLQueue";
            this.LBLQueue.Size = new System.Drawing.Size(103, 20);
            this.LBLQueue.TabIndex = 61;
            this.LBLQueue.Text = "Ready Queue";
            // 
            // timeTable
            // 
            this.timeTable.BackColor = System.Drawing.Color.White;
            this.timeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Process_Name,
            this.column_Arrival_Time,
            this.column_Burst_Time,
            this.columnDeadLine});
            this.timeTable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeTable.GridLines = true;
            this.timeTable.Location = new System.Drawing.Point(170, 38);
            this.timeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(475, 479);
            this.timeTable.TabIndex = 60;
            this.timeTable.UseCompatibleStateImageBehavior = false;
            this.timeTable.View = System.Windows.Forms.View.Details;
            this.timeTable.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.timeTable_ColumnWidthChanging);
            this.timeTable.Resize += new System.EventHandler(this.timeTable_Resize);
            // 
            // column_Process_Name
            // 
            this.column_Process_Name.Text = "Process Name";
            this.column_Process_Name.Width = 110;
            // 
            // column_Arrival_Time
            // 
            this.column_Arrival_Time.Text = "Arrival Time";
            this.column_Arrival_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Arrival_Time.Width = 110;
            // 
            // column_Burst_Time
            // 
            this.column_Burst_Time.Text = "Burst Time";
            this.column_Burst_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Burst_Time.Width = 110;
            // 
            // columnDeadLine
            // 
            this.columnDeadLine.Text = "DeadLine";
            this.columnDeadLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDeadLine.Width = 110;
            // 
            // LBLTimeTable
            // 
            this.LBLTimeTable.AutoSize = true;
            this.LBLTimeTable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimeTable.Location = new System.Drawing.Point(166, 5);
            this.LBLTimeTable.Name = "LBLTimeTable";
            this.LBLTimeTable.Size = new System.Drawing.Size(87, 20);
            this.LBLTimeTable.TabIndex = 59;
            this.LBLTimeTable.Text = "Time Tabel";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(14, 483);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 34);
            this.btnStart.TabIndex = 58;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(88, 441);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 32);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(14, 441);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 32);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // timeQuantunm
            // 
            this.timeQuantunm.Location = new System.Drawing.Point(14, 405);
            this.timeQuantunm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeQuantunm.Name = "timeQuantunm";
            this.timeQuantunm.Size = new System.Drawing.Size(143, 25);
            this.timeQuantunm.TabIndex = 55;
            this.timeQuantunm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeQuantunm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // LBLTimequantum
            // 
            this.LBLTimequantum.AutoSize = true;
            this.LBLTimequantum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimequantum.Location = new System.Drawing.Point(10, 379);
            this.LBLTimequantum.Name = "LBLTimequantum";
            this.LBLTimequantum.Size = new System.Drawing.Size(147, 20);
            this.LBLTimequantum.TabIndex = 54;
            this.LBLTimequantum.Text = "RR Time quantunm";
            // 
            // burstTime
            // 
            this.burstTime.Location = new System.Drawing.Point(14, 295);
            this.burstTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.burstTime.Name = "burstTime";
            this.burstTime.Size = new System.Drawing.Size(143, 25);
            this.burstTime.TabIndex = 53;
            this.burstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burstTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // LBLBurst
            // 
            this.LBLBurst.AutoSize = true;
            this.LBLBurst.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLBurst.Location = new System.Drawing.Point(10, 274);
            this.LBLBurst.Name = "LBLBurst";
            this.LBLBurst.Size = new System.Drawing.Size(87, 20);
            this.LBLBurst.TabIndex = 52;
            this.LBLBurst.Text = "Burst Time";
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(14, 244);
            this.arrivalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(143, 25);
            this.arrivalTime.TabIndex = 51;
            this.arrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.arrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // LBLArrival
            // 
            this.LBLArrival.AutoSize = true;
            this.LBLArrival.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLArrival.Location = new System.Drawing.Point(10, 218);
            this.LBLArrival.Name = "LBLArrival";
            this.LBLArrival.Size = new System.Drawing.Size(96, 20);
            this.LBLArrival.TabIndex = 50;
            this.LBLArrival.Text = "Arrival Time";
            // 
            // processName
            // 
            this.processName.Location = new System.Drawing.Point(14, 191);
            this.processName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(143, 25);
            this.processName.TabIndex = 49;
            this.processName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LBLProcess
            // 
            this.LBLProcess.AutoSize = true;
            this.LBLProcess.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcess.Location = new System.Drawing.Point(10, 168);
            this.LBLProcess.Name = "LBLProcess";
            this.LBLProcess.Size = new System.Drawing.Size(109, 20);
            this.LBLProcess.TabIndex = 48;
            this.LBLProcess.Text = "Process Name";
            // 
            // cmbPcore
            // 
            this.cmbPcore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbPcore.FormattingEnabled = true;
            this.cmbPcore.Location = new System.Drawing.Point(14, 138);
            this.cmbPcore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPcore.Name = "cmbPcore";
            this.cmbPcore.Size = new System.Drawing.Size(143, 28);
            this.cmbPcore.TabIndex = 47;
            // 
            // LBLPcore
            // 
            this.LBLPcore.AutoSize = true;
            this.LBLPcore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLPcore.Location = new System.Drawing.Point(10, 116);
            this.LBLPcore.Name = "LBLPcore";
            this.LBLPcore.Size = new System.Drawing.Size(105, 20);
            this.LBLPcore.TabIndex = 46;
            this.LBLPcore.Text = "num of Pcore";
            // 
            // cmbProcessor
            // 
            this.cmbProcessor.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbProcessor.FormattingEnabled = true;
            this.cmbProcessor.Location = new System.Drawing.Point(14, 86);
            this.cmbProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(143, 28);
            this.cmbProcessor.TabIndex = 45;
            // 
            // LBLproceorNum
            // 
            this.LBLproceorNum.AutoSize = true;
            this.LBLproceorNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLproceorNum.Location = new System.Drawing.Point(17, 64);
            this.LBLproceorNum.Name = "LBLproceorNum";
            this.LBLproceorNum.Size = new System.Drawing.Size(141, 20);
            this.LBLproceorNum.TabIndex = 44;
            this.LBLproceorNum.Text = "num of Processors";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(14, 34);
            this.cmbAlgorithm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(143, 28);
            this.cmbAlgorithm.TabIndex = 43;
            // 
            // LBLalgorithm
            // 
            this.LBLalgorithm.AutoSize = true;
            this.LBLalgorithm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLalgorithm.Location = new System.Drawing.Point(11, 5);
            this.LBLalgorithm.Name = "LBLalgorithm";
            this.LBLalgorithm.Size = new System.Drawing.Size(111, 20);
            this.LBLalgorithm.TabIndex = 42;
            this.LBLalgorithm.Text = "Algorithm List";
            // 
            // DeadLine
            // 
            this.DeadLine.Location = new System.Drawing.Point(15, 349);
            this.DeadLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.Size = new System.Drawing.Size(143, 25);
            this.DeadLine.TabIndex = 54;
            this.DeadLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeadLine.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.DeadLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeadLine_KeyPress);
            // 
            // LBLDeadLine
            // 
            this.LBLDeadLine.AutoSize = true;
            this.LBLDeadLine.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLDeadLine.Location = new System.Drawing.Point(11, 328);
            this.LBLDeadLine.Name = "LBLDeadLine";
            this.LBLDeadLine.Size = new System.Drawing.Size(74, 20);
            this.LBLDeadLine.TabIndex = 70;
            this.LBLDeadLine.Text = "DeadLine";
            // 
            // DeadQueuePanel
            // 
            this.DeadQueuePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DeadQueuePanel.ColumnCount = 15;
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.DeadQueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.DeadQueuePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.DeadQueuePanel.Location = new System.Drawing.Point(655, 127);
            this.DeadQueuePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeadQueuePanel.Name = "DeadQueuePanel";
            this.DeadQueuePanel.RowCount = 1;
            this.DeadQueuePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DeadQueuePanel.Size = new System.Drawing.Size(517, 49);
            this.DeadQueuePanel.TabIndex = 72;
            this.DeadQueuePanel.Visible = false;
            // 
            // LBLDeadQueue
            // 
            this.LBLDeadQueue.AutoSize = true;
            this.LBLDeadQueue.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLDeadQueue.Location = new System.Drawing.Point(651, 94);
            this.LBLDeadQueue.Name = "LBLDeadQueue";
            this.LBLDeadQueue.Size = new System.Drawing.Size(96, 20);
            this.LBLDeadQueue.TabIndex = 71;
            this.LBLDeadQueue.Text = "Dead Queue";
            this.LBLDeadQueue.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1262, 923);
            this.Controls.Add(this.DeadQueuePanel);
            this.Controls.Add(this.LBLDeadQueue);
            this.Controls.Add(this.DeadLine);
            this.Controls.Add(this.LBLDeadLine);
            this.Controls.Add(this.groupBox1);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watt_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView processResultTable;
        private System.Windows.Forms.DataGridView watt_dataGridView;
        private System.Windows.Forms.Label LBLProcessor4;
        private System.Windows.Forms.Label LBLProcessor3;
        private System.Windows.Forms.Label LBLProcessor2;
        private System.Windows.Forms.Label LBLProcessor1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBLTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label LBLQueue;
        private System.Windows.Forms.ListView timeTable;
        private System.Windows.Forms.ColumnHeader column_Process_Name;
        private System.Windows.Forms.ColumnHeader column_Arrival_Time;
        private System.Windows.Forms.ColumnHeader column_Burst_Time;
        private System.Windows.Forms.Label LBLTimeTable;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox timeQuantunm;
        private System.Windows.Forms.Label LBLTimequantum;
        private System.Windows.Forms.TextBox burstTime;
        private System.Windows.Forms.Label LBLBurst;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.Label LBLArrival;
        private System.Windows.Forms.TextBox processName;
        private System.Windows.Forms.Label LBLProcess;
        private System.Windows.Forms.ComboBox cmbPcore;
        private System.Windows.Forms.Label LBLPcore;
        private System.Windows.Forms.ComboBox cmbProcessor;
        private System.Windows.Forms.Label LBLproceorNum;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Label LBLalgorithm;
        private System.Windows.Forms.TextBox DeadLine;
        private System.Windows.Forms.Label LBLDeadLine;
        private System.Windows.Forms.ColumnHeader columnDeadLine;
        private System.Windows.Forms.TableLayoutPanel DeadQueuePanel;
        private System.Windows.Forms.Label LBLDeadQueue;
    }
}

