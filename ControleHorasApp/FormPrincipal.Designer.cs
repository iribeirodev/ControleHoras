
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnNovaTarefa = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.txtTempoDecorrido = new System.Windows.Forms.TextBox();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.btnLog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoDecorrido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciarContagem = new System.Windows.Forms.Button();
            this.btnPararContagem = new System.Windows.Forms.Button();
            this.timerTarefa = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovaTarefa
            // 
            this.btnNovaTarefa.BackColor = System.Drawing.Color.SlateGray;
            this.btnNovaTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaTarefa.ForeColor = System.Drawing.Color.White;
            this.btnNovaTarefa.Location = new System.Drawing.Point(227, 24);
            this.btnNovaTarefa.Name = "btnNovaTarefa";
            this.btnNovaTarefa.Size = new System.Drawing.Size(102, 25);
            this.btnNovaTarefa.TabIndex = 0;
            this.btnNovaTarefa.Text = "Nova Tarefa";
            this.btnNovaTarefa.UseVisualStyleBackColor = false;
            this.btnNovaTarefa.Click += new System.EventHandler(this.btnNovaTarefa_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluirTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTarefa.ForeColor = System.Drawing.Color.White;
            this.btnExcluirTarefa.Location = new System.Drawing.Point(476, 24);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(102, 25);
            this.btnExcluirTarefa.TabIndex = 4;
            this.btnExcluirTarefa.Text = "Excluir Tarefa";
            this.btnExcluirTarefa.UseVisualStyleBackColor = false;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarefa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Início:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo Decorrido:";
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.BackColor = System.Drawing.Color.White;
            this.txtNomeTarefa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeTarefa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeTarefa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTarefa.ForeColor = System.Drawing.Color.Black;
            this.txtNomeTarefa.Location = new System.Drawing.Point(282, 141);
            this.txtNomeTarefa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.ReadOnly = true;
            this.txtNomeTarefa.Size = new System.Drawing.Size(438, 19);
            this.txtNomeTarefa.TabIndex = 8;
            this.txtNomeTarefa.TabStop = false;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.BackColor = System.Drawing.Color.White;
            this.txtDataInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicio.ForeColor = System.Drawing.Color.Black;
            this.txtDataInicio.Location = new System.Drawing.Point(281, 176);
            this.txtDataInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.ReadOnly = true;
            this.txtDataInicio.Size = new System.Drawing.Size(151, 19);
            this.txtDataInicio.TabIndex = 9;
            this.txtDataInicio.TabStop = false;
            // 
            // txtTempoDecorrido
            // 
            this.txtTempoDecorrido.BackColor = System.Drawing.Color.White;
            this.txtTempoDecorrido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempoDecorrido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempoDecorrido.ForeColor = System.Drawing.Color.Black;
            this.txtTempoDecorrido.Location = new System.Drawing.Point(281, 210);
            this.txtTempoDecorrido.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempoDecorrido.Name = "txtTempoDecorrido";
            this.txtTempoDecorrido.ReadOnly = true;
            this.txtTempoDecorrido.Size = new System.Drawing.Size(151, 19);
            this.txtTempoDecorrido.TabIndex = 10;
            this.txtTempoDecorrido.TabStop = false;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AllowUserToResizeColumns = false;
            this.dgvTarefas.AllowUserToResizeRows = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarefas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTarefas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.DataInicio,
            this.TempoDecorrido,
            this.Status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarefas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTarefas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTarefas.Location = new System.Drawing.Point(35, 255);
            this.dgvTarefas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarefas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTarefas.RowHeadersVisible = false;
            this.dgvTarefas.RowHeadersWidth = 51;
            this.dgvTarefas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTarefas.RowTemplate.Height = 24;
            this.dgvTarefas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefas.Size = new System.Drawing.Size(857, 307);
            this.dgvTarefas.TabIndex = 11;
            this.dgvTarefas.TabStop = false;
            this.dgvTarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellClick);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.SlateGray;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(600, 24);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(102, 25);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnNovaTarefa);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnExcluirTarefa);
            this.panel1.Location = new System.Drawing.Point(-2, 585);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 68);
            this.panel1.TabIndex = 15;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(351, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 25);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.SlateBlue;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.lblTitulo);
            this.panelPrincipal.Controls.Add(this.lblClose);
            this.panelPrincipal.Controls.Add(this.lblMinimize);
            this.panelPrincipal.ForeColor = System.Drawing.Color.White;
            this.panelPrincipal.Location = new System.Drawing.Point(1, 1);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(925, 100);
            this.panelPrincipal.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(326, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 37);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Controle de Horas";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(891, 7);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 25);
            this.lblClose.TabIndex = 19;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(865, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(25, 32);
            this.lblMinimize.TabIndex = 18;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
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
            this.Nome.Width = 480;
            // 
            // DataInicio
            // 
            this.DataInicio.DataPropertyName = "DataInicio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataInicio.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.TempoDecorrido.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnIniciarContagem
            // 
            this.btnIniciarContagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciarContagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarContagem.Enabled = false;
            this.btnIniciarContagem.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnIniciarContagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnIniciarContagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarContagem.Location = new System.Drawing.Point(446, 199);
            this.btnIniciarContagem.Name = "btnIniciarContagem";
            this.btnIniciarContagem.Size = new System.Drawing.Size(40, 32);
            this.btnIniciarContagem.TabIndex = 18;
            this.btnIniciarContagem.UseVisualStyleBackColor = false;
            this.btnIniciarContagem.Click += new System.EventHandler(this.btnIniciarContagem_Click);
            // 
            // btnPararContagem
            // 
            this.btnPararContagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPararContagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPararContagem.Enabled = false;
            this.btnPararContagem.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPararContagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnPararContagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPararContagem.Location = new System.Drawing.Point(492, 199);
            this.btnPararContagem.Name = "btnPararContagem";
            this.btnPararContagem.Size = new System.Drawing.Size(40, 32);
            this.btnPararContagem.TabIndex = 19;
            this.btnPararContagem.UseVisualStyleBackColor = false;
            this.btnPararContagem.Click += new System.EventHandler(this.btnPararContagem_Click);
            // 
            // timerTarefa
            // 
            this.timerTarefa.Interval = 1000;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btnPararContagem);
            this.Controls.Add(this.btnIniciarContagem);
            this.Controls.Add(this.panelPrincipal);
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
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovaTarefa;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeTarefa;
        private System.Windows.Forms.TextBox txtDataInicio;
        private System.Windows.Forms.TextBox txtTempoDecorrido;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoDecorrido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnIniciarContagem;
        private System.Windows.Forms.Button btnPararContagem;
        private System.Windows.Forms.Timer timerTarefa;
    }
}

