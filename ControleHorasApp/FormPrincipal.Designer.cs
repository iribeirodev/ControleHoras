
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnNovaTarefa = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.txtTempoDecorrido = new System.Windows.Forms.TextBox();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoDecorrido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciarContagem = new System.Windows.Forms.Button();
            this.btnPararContagem = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Controle de Horas";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Controle de Horas";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnNovaTarefa
            // 
            this.btnNovaTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaTarefa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNovaTarefa.Location = new System.Drawing.Point(18, 343);
            this.btnNovaTarefa.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaTarefa.Name = "btnNovaTarefa";
            this.btnNovaTarefa.Size = new System.Drawing.Size(120, 28);
            this.btnNovaTarefa.TabIndex = 1;
            this.btnNovaTarefa.Text = "Nova Tarefa";
            this.btnNovaTarefa.UseVisualStyleBackColor = true;
            this.btnNovaTarefa.Click += new System.EventHandler(this.btnNovaTarefa_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirTarefa.ForeColor = System.Drawing.Color.Maroon;
            this.btnExcluirTarefa.Location = new System.Drawing.Point(770, 343);
            this.btnExcluirTarefa.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(120, 28);
            this.btnExcluirTarefa.TabIndex = 2;
            this.btnExcluirTarefa.Text = "Excluir Tarefa";
            this.btnExcluirTarefa.UseVisualStyleBackColor = false;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarefa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Início:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo Decorrido:";
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeTarefa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtNomeTarefa.Location = new System.Drawing.Point(145, 31);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.ReadOnly = true;
            this.txtNomeTarefa.Size = new System.Drawing.Size(583, 22);
            this.txtNomeTarefa.TabIndex = 8;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.ForeColor = System.Drawing.Color.Black;
            this.txtDataInicio.Location = new System.Drawing.Point(144, 74);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.ReadOnly = true;
            this.txtDataInicio.Size = new System.Drawing.Size(167, 22);
            this.txtDataInicio.TabIndex = 9;
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTempoDecorrido
            // 
            this.txtTempoDecorrido.ForeColor = System.Drawing.Color.Black;
            this.txtTempoDecorrido.Location = new System.Drawing.Point(144, 115);
            this.txtTempoDecorrido.Name = "txtTempoDecorrido";
            this.txtTempoDecorrido.ReadOnly = true;
            this.txtTempoDecorrido.Size = new System.Drawing.Size(95, 22);
            this.txtTempoDecorrido.TabIndex = 10;
            this.txtTempoDecorrido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AllowUserToResizeColumns = false;
            this.dgvTarefas.AllowUserToResizeRows = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.DataInicio,
            this.TempoDecorrido,
            this.Status});
            this.dgvTarefas.Location = new System.Drawing.Point(19, 171);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.RowHeadersVisible = false;
            this.dgvTarefas.RowHeadersWidth = 51;
            this.dgvTarefas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTarefas.RowTemplate.Height = 24;
            this.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefas.Size = new System.Drawing.Size(871, 150);
            this.dgvTarefas.TabIndex = 11;
            this.dgvTarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 250;
            // 
            // DataInicio
            // 
            this.DataInicio.DataPropertyName = "DataInicio";
            this.DataInicio.HeaderText = "Data de Início";
            this.DataInicio.MinimumWidth = 6;
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.ReadOnly = true;
            this.DataInicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataInicio.Width = 150;
            // 
            // TempoDecorrido
            // 
            this.TempoDecorrido.DataPropertyName = "TempoDecorrido";
            this.TempoDecorrido.HeaderText = "Tempo Decorrido";
            this.TempoDecorrido.MinimumWidth = 6;
            this.TempoDecorrido.Name = "TempoDecorrido";
            this.TempoDecorrido.ReadOnly = true;
            this.TempoDecorrido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TempoDecorrido.Width = 120;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // btnIniciarContagem
            // 
            this.btnIniciarContagem.Enabled = false;
            this.btnIniciarContagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarContagem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnIniciarContagem.Location = new System.Drawing.Point(203, 343);
            this.btnIniciarContagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarContagem.Name = "btnIniciarContagem";
            this.btnIniciarContagem.Size = new System.Drawing.Size(120, 28);
            this.btnIniciarContagem.TabIndex = 12;
            this.btnIniciarContagem.Text = "Iniciar/Retomar";
            this.btnIniciarContagem.UseVisualStyleBackColor = true;
            this.btnIniciarContagem.Click += new System.EventHandler(this.btnIniciarContagem_Click);
            // 
            // btnPararContagem
            // 
            this.btnPararContagem.Enabled = false;
            this.btnPararContagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPararContagem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPararContagem.Location = new System.Drawing.Point(331, 343);
            this.btnPararContagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnPararContagem.Name = "btnPararContagem";
            this.btnPararContagem.Size = new System.Drawing.Size(120, 28);
            this.btnPararContagem.TabIndex = 13;
            this.btnPararContagem.Text = "Parar";
            this.btnPararContagem.UseVisualStyleBackColor = true;
            this.btnPararContagem.Click += new System.EventHandler(this.btnPararContagem_Click);
            // 
            // btnLog
            // 
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLog.Location = new System.Drawing.Point(509, 343);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(120, 28);
            this.btnLog.TabIndex = 14;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 394);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPararContagem);
            this.Controls.Add(this.btnIniciarContagem);
            this.Controls.Add(this.dgvTarefas);
            this.Controls.Add(this.txtTempoDecorrido);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.txtNomeTarefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirTarefa);
            this.Controls.Add(this.btnNovaTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Horas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Resize += new System.EventHandler(this.FormPrincipal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnNovaTarefa;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeTarefa;
        private System.Windows.Forms.TextBox txtDataInicio;
        private System.Windows.Forms.TextBox txtTempoDecorrido;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button btnIniciarContagem;
        private System.Windows.Forms.Button btnPararContagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoDecorrido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnLog;
    }
}

