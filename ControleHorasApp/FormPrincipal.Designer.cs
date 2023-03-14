
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btnNovaTarefa.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNovaTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaTarefa.ForeColor = System.Drawing.Color.White;
            this.btnNovaTarefa.Location = new System.Drawing.Point(20, 29);
            this.btnNovaTarefa.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaTarefa.Name = "btnNovaTarefa";
            this.btnNovaTarefa.Size = new System.Drawing.Size(136, 31);
            this.btnNovaTarefa.TabIndex = 0;
            this.btnNovaTarefa.Text = "Nova Tarefa";
            this.btnNovaTarefa.UseVisualStyleBackColor = false;
            this.btnNovaTarefa.Click += new System.EventHandler(this.btnNovaTarefa_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluirTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTarefa.ForeColor = System.Drawing.Color.White;
            this.btnExcluirTarefa.Location = new System.Drawing.Point(755, 29);
            this.btnExcluirTarefa.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(136, 31);
            this.btnExcluirTarefa.TabIndex = 4;
            this.btnExcluirTarefa.Text = "Excluir Tarefa";
            this.btnExcluirTarefa.UseVisualStyleBackColor = false;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarefa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Início:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo Decorrido:";
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.BackColor = System.Drawing.Color.White;
            this.txtNomeTarefa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeTarefa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTarefa.ForeColor = System.Drawing.Color.Black;
            this.txtNomeTarefa.Location = new System.Drawing.Point(205, 30);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.ReadOnly = true;
            this.txtNomeTarefa.Size = new System.Drawing.Size(583, 30);
            this.txtNomeTarefa.TabIndex = 8;
            this.txtNomeTarefa.TabStop = false;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.BackColor = System.Drawing.Color.White;
            this.txtDataInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicio.ForeColor = System.Drawing.Color.Black;
            this.txtDataInicio.Location = new System.Drawing.Point(204, 73);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.ReadOnly = true;
            this.txtDataInicio.Size = new System.Drawing.Size(167, 30);
            this.txtDataInicio.TabIndex = 9;
            this.txtDataInicio.TabStop = false;
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTempoDecorrido
            // 
            this.txtTempoDecorrido.BackColor = System.Drawing.Color.White;
            this.txtTempoDecorrido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempoDecorrido.ForeColor = System.Drawing.Color.Black;
            this.txtTempoDecorrido.Location = new System.Drawing.Point(204, 114);
            this.txtTempoDecorrido.Name = "txtTempoDecorrido";
            this.txtTempoDecorrido.ReadOnly = true;
            this.txtTempoDecorrido.Size = new System.Drawing.Size(95, 30);
            this.txtTempoDecorrido.TabIndex = 10;
            this.txtTempoDecorrido.TabStop = false;
            this.txtTempoDecorrido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AllowUserToResizeColumns = false;
            this.dgvTarefas.AllowUserToResizeRows = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.DataInicio,
            this.TempoDecorrido,
            this.Status});
            this.dgvTarefas.Location = new System.Drawing.Point(18, 160);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.RowHeadersVisible = false;
            this.dgvTarefas.RowHeadersWidth = 51;
            this.dgvTarefas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTarefas.RowTemplate.Height = 24;
            this.dgvTarefas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefas.Size = new System.Drawing.Size(871, 238);
            this.dgvTarefas.TabIndex = 11;
            this.dgvTarefas.TabStop = false;
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
            this.btnIniciarContagem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIniciarContagem.Enabled = false;
            this.btnIniciarContagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarContagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarContagem.ForeColor = System.Drawing.Color.White;
            this.btnIniciarContagem.Location = new System.Drawing.Point(234, 29);
            this.btnIniciarContagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarContagem.Name = "btnIniciarContagem";
            this.btnIniciarContagem.Size = new System.Drawing.Size(136, 31);
            this.btnIniciarContagem.TabIndex = 1;
            this.btnIniciarContagem.Text = "Iniciar/Retomar";
            this.btnIniciarContagem.UseVisualStyleBackColor = false;
            this.btnIniciarContagem.Click += new System.EventHandler(this.btnIniciarContagem_Click);
            // 
            // btnPararContagem
            // 
            this.btnPararContagem.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPararContagem.Enabled = false;
            this.btnPararContagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPararContagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararContagem.ForeColor = System.Drawing.Color.White;
            this.btnPararContagem.Location = new System.Drawing.Point(378, 29);
            this.btnPararContagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnPararContagem.Name = "btnPararContagem";
            this.btnPararContagem.Size = new System.Drawing.Size(136, 31);
            this.btnPararContagem.TabIndex = 2;
            this.btnPararContagem.Text = "Parar";
            this.btnPararContagem.UseVisualStyleBackColor = false;
            this.btnPararContagem.Click += new System.EventHandler(this.btnPararContagem_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(522, 29);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(136, 31);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnNovaTarefa);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnPararContagem);
            this.panel1.Controls.Add(this.btnIniciarContagem);
            this.panel1.Controls.Add(this.btnExcluirTarefa);
            this.panel1.Location = new System.Drawing.Point(-2, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 84);
            this.panel1.TabIndex = 15;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(794, 29);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 31);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(907, 497);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTarefas);
            this.Controls.Add(this.txtTempoDecorrido);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.txtNomeTarefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
    }
}

