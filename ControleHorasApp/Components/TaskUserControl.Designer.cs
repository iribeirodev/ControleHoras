namespace ControleHorasApp.Components
{
    partial class TaskUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgbTask = new System.Windows.Forms.ProgressBar();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.timerTask = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgbTask
            // 
            this.pgbTask.Location = new System.Drawing.Point(18, 32);
            this.pgbTask.Name = "pgbTask";
            this.pgbTask.Size = new System.Drawing.Size(434, 22);
            this.pgbTask.TabIndex = 0;
            // 
            // lblTaskName
            // 
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(18, 12);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(434, 16);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "label1";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(18, 57);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(56, 19);
            this.lblCurrentTime.TabIndex = 2;
            this.lblCurrentTime.Text = "label1";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedTime.Location = new System.Drawing.Point(396, 57);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(56, 17);
            this.lblEstimatedTime.TabIndex = 3;
            this.lblEstimatedTime.Text = "label1";
            this.lblEstimatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTask
            // 
            this.timerTask.Interval = 1000;
            this.timerTask.Tick += new System.EventHandler(this.timerTask_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(458, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 26);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(532, 30);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(68, 26);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(606, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 26);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // TaskUserControl
            // 
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEstimatedTime);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.pgbTask);
            this.Name = "TaskUserControl";
            this.Size = new System.Drawing.Size(687, 95);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TaskUserControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerTask;
        public System.Windows.Forms.Label lblTaskName;
        public System.Windows.Forms.Label lblCurrentTime;
        public System.Windows.Forms.Label lblEstimatedTime;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ProgressBar pgbTask;
    }
}
