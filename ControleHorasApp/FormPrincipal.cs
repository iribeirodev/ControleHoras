using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ControleHorasApp.Domain;
using ControleHorasApp.Infrastructure.Enums;
using ControleHorasApp.InfraStructure;
using ControleHorasApp.Services;
using ControleHorasApp.Infrastructure.CrossCutting;
using System.Drawing;

namespace ControleHorasApp
{
    public partial class FormPrincipal : BaseForm
    {
        private readonly TaskService _taskService;
        private readonly IServiceProvider _serviceProvider;
        private List<Task> tasks = new List<Task>();

        private int lastRowIndex = -1;

        public FormPrincipal(TaskService taskService)
        {
            InitializeComponent();

            _taskService = taskService;
            _serviceProvider = Bootstrap.GetServiceProvider();
        }

        private void LoadTasks()
        {
            tasks = _taskService.GetTasks();

            dgvTarefas.DataSource = tasks;
            dgvTarefas.ClearSelection();

            btnStart.Enabled = false;
            btnStop.Enabled = false;
            btnDeleteTask.Enabled = false;
            lblTaskName.Text = "";
            lblCurrentTime.Text = "";
        }

        private void EnableButtons(bool enable)
        {
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
        }

        private void ChecarTempoTarefa()
        {
            var estimatedTime = TimeSpan.Parse(dgvTarefas.SelectedRows[0].Cells[3].Value.ToString());
            var currentTime = TimeSpan.Parse(lblCurrentTime.Text);
            if (currentTime >= estimatedTime)
                lblCurrentTime.ForeColor = Color.Red;
            else
                lblCurrentTime.ForeColor = Color.FromArgb(12, 109, 179);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            TituloForm = "Controle de Tarefas";

            dgvTarefas.AutoGenerateColumns = false;

            LoadTasks();
        }

        private void StopAllTasks(int exceptId)
        {
            for (int i = 0; i < dgvTarefas.Rows.Count; i++)
            {
                var id = (int)dgvTarefas.Rows[i].Cells[0].Value;
                if (id != exceptId)
                {
                    dgvTarefas.Rows[i].Cells[4].Value = "Stopped";
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EnableButtons(false);

            btnNewTask.Enabled = false;
            btnDeleteTask.Enabled = false;
            var taskName = dgvTarefas.SelectedRows[0].Cells[1].Value;

            dgvTarefas.SelectedRows[0].Cells[4].Value = "Started";
            StopAllTasks((int)dgvTarefas.SelectedRows[0].Cells[0].Value);

            LogService.Write("FormPrincipal::btnStart_Click", $"Iniciando tarefa {taskName}");
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            EnableButtons(true);

            btnNewTask.Enabled = true;
            btnDeleteTask.Enabled = true;
            var taskName = dgvTarefas.SelectedRows[0].Cells[1].Value;

            dgvTarefas.SelectedRows[0].Cells[4].Value = "Stopped";

            timer1.Enabled = false;

            _taskService.UpdateCurrentTime(
                (int)dgvTarefas.SelectedRows[0].Cells[0].Value,
                lblCurrentTime.Text
            );
            LogService.Write("FormPrincipal::btnStop_Click", $"Parando tarefa {taskName}, tempo decorrido: {lblCurrentTime.Text}");

            dgvTarefas.Rows[lastRowIndex].Cells[2].Value = lblCurrentTime.Text;
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            var formCriarTarefa = _serviceProvider.GetRequiredService<FormCriarTarefa>();
            formCriarTarefa.ShowDialog();

            LoadTasks();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (DefaultMessage.ShowQuestion(
                "Essa tarefa será permanentemente excluída. Continuar?")
                == EnumMessageAnswers.No)
                return;

            var taskId = (int)dgvTarefas.SelectedRows[0].Cells[0].Value;
            _taskService.RemoveTask(taskId);

            LoadTasks();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var tempoAtual = TimeSpan.Parse(lblCurrentTime.Text);

            tempoAtual += TimeSpan.FromSeconds(1);
            lblCurrentTime.Text = string.Format("{0:hh\\:mm\\:ss}", tempoAtual);

            ChecarTempoTarefa();
        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (timer1.Enabled)
            {
                MessageBox.Show("Pare a última tarefa iniciada primeiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvTarefas.ClearSelection();
                dgvTarefas.Rows[lastRowIndex].Selected = true;
                return;
            }

            btnDeleteTask.Enabled = true;

            var status = (EnumTaskStatus)dgvTarefas.SelectedRows[0].Cells[4].Value;
            if (status == EnumTaskStatus.Started)
            {
                EnableButtons(false);
            }
            else
                EnableButtons(true);

            lblTaskName.Text = dgvTarefas.SelectedRows[0].Cells[1].Value.ToString();
            lblCurrentTime.Text = dgvTarefas.SelectedRows[0].Cells[2].Value.ToString();
            lastRowIndex = e.RowIndex;

            ChecarTempoTarefa();
        }

        private void dgvTarefas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var taskId = (int)dgvTarefas.SelectedRows[0].Cells[0].Value;
            var taskToEdit = _taskService.GetTask(taskId);

            var formCriarTarefa = _serviceProvider.GetService<FormCriarTarefa>();
            formCriarTarefa.CurrentTask = taskToEdit;
            formCriarTarefa.ShowDialog();

            LoadTasks();
        }

        private void dgvTarefas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var currentTime = TimeSpan.Parse(dgvTarefas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                var estimatedTime = TimeSpan.Parse(dgvTarefas.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (currentTime >= estimatedTime)
                    e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvTarefas.SelectedRows.Count > 0)
            {
                var taskName = dgvTarefas.SelectedRows[0].Cells[1].Value;

                dgvTarefas.SelectedRows[0].Cells[4].Value = "Stopped";

                timer1.Enabled = false;

                _taskService.UpdateCurrentTime(
                    (int)dgvTarefas.SelectedRows[0].Cells[0].Value,
                    lblCurrentTime.Text
                );
                LogService.Write("FormPrincipal::Form_Closing", $"Parando tarefa {taskName}, tempo decorrido: {lblCurrentTime.Text}");
            }
        }
    }
}
