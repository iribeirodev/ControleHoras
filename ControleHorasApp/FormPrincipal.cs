using ControleHorasApp.Domain;
using ControleHorasApp.Infrastructure.Enums;
using ControleHorasApp.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControleHorasApp
{
    public partial class FormPrincipal : BaseForm
    {
        private readonly TaskService _taskService;
        private List<Task> tasks = new List<Task>();
        private int lastRowIndex = -1;
        private const int EDITMODE_HEIGHT = 690;
        private const int REGULARSIZE_HEIGHT = 510;
        private bool _editMode = false;

        public FormPrincipal(TaskService taskService)
        {
            InitializeComponent();
            Height = REGULARSIZE_HEIGHT;
            _taskService = taskService;
        }

        private void EnableTaskEditing(bool enable = true)
        {
            if (!enable)
            {
                pnlFields.Visible = false; Height = REGULARSIZE_HEIGHT;
                btnStart.Enabled = true;
                btnNewTask.Enabled = true; btnDeleteTask.Enabled = true;
                return;
            }

            btnStart.Enabled = false; btnStop.Enabled = false;
            btnNewTask.Enabled = false; btnDeleteTask.Enabled = false;  

            pnlFields.Visible = true;
            Height = EDITMODE_HEIGHT;
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            TituloForm = "Controle de Tarefas";

            dgvTarefas.AutoGenerateColumns = false;

            tasks = _taskService.GetTasks();

            dgvTarefas.DataSource = tasks;
            dgvTarefas.ClearSelection();
        }

        private void EnableButtons(bool enable)
        {
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
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

            var status = (EnumTaskStatus) dgvTarefas.SelectedRows[0].Cells[4].Value;
            if (status == EnumTaskStatus.Started)
            {
                EnableButtons(false);
            }   
            else
                EnableButtons(true);

            lblTaskName.Text = dgvTarefas.SelectedRows[0].Cells[1].Value.ToString();
            lblCurrentTime.Text = dgvTarefas.SelectedRows[0].Cells[2].Value.ToString();
            lastRowIndex = e.RowIndex;
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

            dgvTarefas.SelectedRows[0].Cells[4].Value = "Started";
            StopAllTasks((int)dgvTarefas.SelectedRows[0].Cells[0].Value);

            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            EnableButtons(true);

            btnNewTask.Enabled = true;
            btnDeleteTask.Enabled = true;

            dgvTarefas.SelectedRows[0].Cells[4].Value = "Stopped";

            timer1.Enabled = false;

            _taskService.UpdateCurrentTime(
                (int)dgvTarefas.SelectedRows[0].Cells[0].Value,
                lblCurrentTime.Text
            );

            dgvTarefas.Rows[lastRowIndex].Cells[2].Value = lblCurrentTime.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var tempoAtual = TimeSpan.Parse(lblCurrentTime.Text);

            tempoAtual += TimeSpan.FromSeconds(1);
            lblCurrentTime.Text = string.Format("{0:hh\\:mm\\:ss}", tempoAtual);
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            dgvTarefas.ClearSelection();
            lblTaskName.Text = ""; lblCurrentTime.Text = "";

            txtTaskName.Text = "";
            mskEstimatedTime.Text = "";
            txtDescription.Text = "";

            EnableTaskEditing();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableTaskEditing(false);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text))
            {
                MessageBox.Show("A tarefa não tem um nome definido.");
                return;
            }

            mskEstimatedTime.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrEmpty(mskEstimatedTime.Text) || 
                mskEstimatedTime.Text == "00:00:00")
            {
                MessageBox.Show("A tarefa não tem um tempo estimado.");
                mskEstimatedTime.TextMaskFormat = MaskFormat.IncludeLiterals;
                return;
            }

            mskEstimatedTime.TextMaskFormat = MaskFormat.IncludeLiterals;

            if (_editMode)
                _taskService.UpdateInfo(
                    (int)dgvTarefas.SelectedRows[0].Cells[0].Value,
                    txtTaskName.Text, 
                    mskEstimatedTime.Text, 
                    txtDescription.Text);
            else
                _taskService.AddTask(
                    new Task { 
                        TaskName = txtTaskName.Text,
                        Description = txtDescription.Text,
                        EstimatedTime = mskEstimatedTime.Text
                    });

            EnableTaskEditing(false);

            tasks = _taskService.GetTasks();
            dgvTarefas.DataSource = tasks;
        }

        private void pnlFields_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlFields.ClientRectangle, Color.FromArgb(12, 109, 255), ButtonBorderStyle.Solid);
        }

        private void dgvTarefas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var taskId = (int)dgvTarefas.SelectedRows[0].Cells[0].Value;
            var taskToEdit = _taskService.GetTask(taskId);

            txtTaskName.Text = taskToEdit.TaskName;
            mskEstimatedTime.Text = taskToEdit.EstimatedTime;
            txtDescription.Text = taskToEdit.Description;

            _editMode = true;

            EnableTaskEditing();
        }
    }
}
