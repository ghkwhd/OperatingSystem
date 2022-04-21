
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
            this.PBQueue = new System.Windows.Forms.ProgressBar();
            this.LBLProcessor1 = new System.Windows.Forms.Label();
            this.LBLProcessor2 = new System.Windows.Forms.Label();
            this.LBLProcessor3 = new System.Windows.Forms.Label();
            this.LBLProcessor4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLalgorithm
            // 
            this.LBLalgorithm.AutoSize = true;
            this.LBLalgorithm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLalgorithm.Location = new System.Drawing.Point(3, 7);
            this.LBLalgorithm.Name = "LBLalgorithm";
            this.LBLalgorithm.Size = new System.Drawing.Size(111, 20);
            this.LBLalgorithm.TabIndex = 0;
            this.LBLalgorithm.Text = "Algorithm List";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(7, 31);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(144, 23);
            this.cmbAlgorithm.TabIndex = 1;
            // 
            // cmbProcessor
            // 
            this.cmbProcessor.FormattingEnabled = true;
            this.cmbProcessor.Location = new System.Drawing.Point(7, 81);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(144, 23);
            this.cmbProcessor.TabIndex = 3;
            // 
            // LBLproceorNum
            // 
            this.LBLproceorNum.AutoSize = true;
            this.LBLproceorNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLproceorNum.Location = new System.Drawing.Point(3, 57);
            this.LBLproceorNum.Name = "LBLproceorNum";
            this.LBLproceorNum.Size = new System.Drawing.Size(141, 20);
            this.LBLproceorNum.TabIndex = 2;
            this.LBLproceorNum.Text = "num of Processors";
            // 
            // cmbPcore
            // 
            this.cmbPcore.FormattingEnabled = true;
            this.cmbPcore.Location = new System.Drawing.Point(7, 131);
            this.cmbPcore.Name = "cmbPcore";
            this.cmbPcore.Size = new System.Drawing.Size(144, 23);
            this.cmbPcore.TabIndex = 5;
            this.cmbPcore.SelectedIndexChanged += new System.EventHandler(this.cmbPcore_SelectedIndexChanged);
            // 
            // LBLPcore
            // 
            this.LBLPcore.AutoSize = true;
            this.LBLPcore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLPcore.Location = new System.Drawing.Point(3, 107);
            this.LBLPcore.Name = "LBLPcore";
            this.LBLPcore.Size = new System.Drawing.Size(105, 20);
            this.LBLPcore.TabIndex = 4;
            this.LBLPcore.Text = "num of Pcore";
            // 
            // LBLProcess
            // 
            this.LBLProcess.AutoSize = true;
            this.LBLProcess.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcess.Location = new System.Drawing.Point(3, 157);
            this.LBLProcess.Name = "LBLProcess";
            this.LBLProcess.Size = new System.Drawing.Size(109, 20);
            this.LBLProcess.TabIndex = 6;
            this.LBLProcess.Text = "Process Name";
            // 
            // processName
            // 
            this.processName.Location = new System.Drawing.Point(7, 181);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(144, 25);
            this.processName.TabIndex = 7;
            this.processName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(7, 233);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(144, 25);
            this.arrivalTime.TabIndex = 9;
            this.arrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.arrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // LBLArrival
            // 
            this.LBLArrival.AutoSize = true;
            this.LBLArrival.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLArrival.Location = new System.Drawing.Point(3, 209);
            this.LBLArrival.Name = "LBLArrival";
            this.LBLArrival.Size = new System.Drawing.Size(96, 20);
            this.LBLArrival.TabIndex = 8;
            this.LBLArrival.Text = "Arrival Time";
            // 
            // burstTime
            // 
            this.burstTime.Location = new System.Drawing.Point(7, 285);
            this.burstTime.Name = "burstTime";
            this.burstTime.Size = new System.Drawing.Size(144, 25);
            this.burstTime.TabIndex = 11;
            this.burstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burstTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // LBLBurst
            // 
            this.LBLBurst.AutoSize = true;
            this.LBLBurst.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLBurst.Location = new System.Drawing.Point(3, 261);
            this.LBLBurst.Name = "LBLBurst";
            this.LBLBurst.Size = new System.Drawing.Size(87, 20);
            this.LBLBurst.TabIndex = 10;
            this.LBLBurst.Text = "Burst Time";
            // 
            // timeQuantunm
            // 
            this.timeQuantunm.Location = new System.Drawing.Point(7, 337);
            this.timeQuantunm.Name = "timeQuantunm";
            this.timeQuantunm.Size = new System.Drawing.Size(144, 25);
            this.timeQuantunm.TabIndex = 13;
            this.timeQuantunm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeQuantunm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // LBLTimequantum
            // 
            this.LBLTimequantum.AutoSize = true;
            this.LBLTimequantum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimequantum.Location = new System.Drawing.Point(3, 313);
            this.LBLTimequantum.Name = "LBLTimequantum";
            this.LBLTimequantum.Size = new System.Drawing.Size(148, 20);
            this.LBLTimequantum.TabIndex = 12;
            this.LBLTimequantum.Text = "RR TIme quantunm";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(7, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(83, 382);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 33);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(7, 422);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 34);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // LBLTimeTable
            // 
            this.LBLTimeTable.AutoSize = true;
            this.LBLTimeTable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLTimeTable.Location = new System.Drawing.Point(171, 4);
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
            this.timeTable.Location = new System.Drawing.Point(166, 31);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(427, 425);
            this.timeTable.TabIndex = 18;
            this.timeTable.UseCompatibleStateImageBehavior = false;
            this.timeTable.View = System.Windows.Forms.View.Details;
            this.timeTable.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.timeTable_ColumnWidthChanging);
            this.timeTable.SelectedIndexChanged += new System.EventHandler(this.timeTable_SelectedIndexChanged);
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
            this.LBLQueue.Location = new System.Drawing.Point(599, -1);
            this.LBLQueue.Name = "LBLQueue";
            this.LBLQueue.Size = new System.Drawing.Size(103, 20);
            this.LBLQueue.TabIndex = 19;
            this.LBLQueue.Text = "Ready Queue";
            // 
            // PBQueue
            // 
            this.PBQueue.Location = new System.Drawing.Point(603, 22);
            this.PBQueue.Name = "PBQueue";
            this.PBQueue.Size = new System.Drawing.Size(536, 62);
            this.PBQueue.TabIndex = 20;
            // 
            // LBLProcessor1
            // 
            this.LBLProcessor1.AutoSize = true;
            this.LBLProcessor1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor1.Location = new System.Drawing.Point(599, 98);
            this.LBLProcessor1.Name = "LBLProcessor1";
            this.LBLProcessor1.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor1.TabIndex = 21;
            this.LBLProcessor1.Text = "Processor1";
            // 
            // LBLProcessor2
            // 
            this.LBLProcessor2.AutoSize = true;
            this.LBLProcessor2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor2.Location = new System.Drawing.Point(923, 98);
            this.LBLProcessor2.Name = "LBLProcessor2";
            this.LBLProcessor2.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor2.TabIndex = 22;
            this.LBLProcessor2.Text = "Processor2";
            // 
            // LBLProcessor3
            // 
            this.LBLProcessor3.AutoSize = true;
            this.LBLProcessor3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor3.Location = new System.Drawing.Point(599, 281);
            this.LBLProcessor3.Name = "LBLProcessor3";
            this.LBLProcessor3.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor3.TabIndex = 23;
            this.LBLProcessor3.Text = "Processor3";
            // 
            // LBLProcessor4
            // 
            this.LBLProcessor4.AutoSize = true;
            this.LBLProcessor4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBLProcessor4.Location = new System.Drawing.Point(923, 281);
            this.LBLProcessor4.Name = "LBLProcessor4";
            this.LBLProcessor4.Size = new System.Drawing.Size(86, 20);
            this.LBLProcessor4.TabIndex = 24;
            this.LBLProcessor4.Text = "Processor4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 477);
            this.Controls.Add(this.LBLProcessor4);
            this.Controls.Add(this.LBLProcessor3);
            this.Controls.Add(this.LBLProcessor2);
            this.Controls.Add(this.LBLProcessor1);
            this.Controls.Add(this.PBQueue);
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
        private System.Windows.Forms.ProgressBar PBQueue;
        private System.Windows.Forms.Label LBLProcessor1;
        private System.Windows.Forms.Label LBLProcessor2;
        private System.Windows.Forms.Label LBLProcessor3;
        private System.Windows.Forms.Label LBLProcessor4;
        private System.Windows.Forms.TextBox burstTime;
    }
}

