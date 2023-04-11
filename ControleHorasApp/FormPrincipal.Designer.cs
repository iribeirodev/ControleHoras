namespace ControleHorasApp
{
    partial class FormPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.pnlFunctions = new System.Windows.Forms.Panel();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.pnlFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(793, 12);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(834, 12);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Time:";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.BackColor = System.Drawing.Color.White;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.lblCurrentTime.Location = new System.Drawing.Point(727, 433);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentTime.TabIndex = 4;
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.pnlDataGrid.Controls.Add(this.dgvTarefas);
            this.pnlDataGrid.Location = new System.Drawing.Point(98, 105);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(1);
            this.pnlDataGrid.Size = new System.Drawing.Size(730, 312);
            this.pnlDataGrid.TabIndex = 5;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AllowUserToResizeColumns = false;
            this.dgvTarefas.AllowUserToResizeRows = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TaskName,
            this.CurrentTime,
            this.EstimatedTime,
            this.Status,
            this.DateCreated});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarefas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefas.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTarefas.Location = new System.Drawing.Point(1, 1);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.RowHeadersVisible = false;
            this.dgvTarefas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTarefas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefas.Size = new System.Drawing.Size(728, 310);
            this.dgvTarefas.TabIndex = 1;
            this.dgvTarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellClick);
            this.dgvTarefas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TaskName.Width = 250;
            // 
            // CurrentTime
            // 
            this.CurrentTime.DataPropertyName = "CurrentTime";
            this.CurrentTime.HeaderText = "Total Time";
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.ReadOnly = true;
            this.CurrentTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CurrentTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EstimatedTime
            // 
            this.EstimatedTime.DataPropertyName = "EstimatedTime";
            this.EstimatedTime.HeaderText = "Estimated Time";
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.ReadOnly = true;
            this.EstimatedTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EstimatedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EstimatedTime.Width = 120;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateCreated
            // 
            this.DateCreated.DataPropertyName = "DateCreated";
            this.DateCreated.HeaderText = "Date Created";
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            this.DateCreated.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateCreated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Task:";
            // 
            // lblTaskName
            // 
            this.lblTaskName.BackColor = System.Drawing.Color.White;
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.lblTaskName.Location = new System.Drawing.Point(194, 433);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(417, 23);
            this.lblTaskName.TabIndex = 7;
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFunctions
            // 
            this.pnlFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFunctions.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFunctions.Controls.Add(this.btnDeleteTask);
            this.pnlFunctions.Controls.Add(this.btnNewTask);
            this.pnlFunctions.Controls.Add(this.btnStop);
            this.pnlFunctions.Controls.Add(this.btnStart);
            this.pnlFunctions.Location = new System.Drawing.Point(-1, 485);
            this.pnlFunctions.Name = "pnlFunctions";
            this.pnlFunctions.Size = new System.Drawing.Size(898, 50);
            this.pnlFunctions.TabIndex = 10;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.White;
            this.btnDeleteTask.Enabled = false;
            this.btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnDeleteTask.Location = new System.Drawing.Point(734, 10);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(95, 30);
            this.btnDeleteTask.TabIndex = 13;
            this.btnDeleteTask.Text = "Remove Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnNewTask
            // 
            this.btnNewTask.BackColor = System.Drawing.Color.White;
            this.btnNewTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnNewTask.Location = new System.Drawing.Point(633, 10);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(95, 30);
            this.btnNewTask.TabIndex = 12;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.UseVisualStyleBackColor = false;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnStop.Location = new System.Drawing.Point(198, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 30);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(179)))));
            this.btnStart.Location = new System.Drawing.Point(97, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 30);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 535);
            this.Controls.Add(this.pnlFunctions);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblCurrentTime, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.pnlDataGrid, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblTaskName, 0);
            this.Controls.SetChildIndex(this.pnlFunctions, 0);
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.pnlFunctions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Panel pnlFunctions;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
    }
}