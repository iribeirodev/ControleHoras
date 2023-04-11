using ControleHorasApp.Domain;
using ControleHorasApp.Infrastructure.CrossCutting;
using ControleHorasApp.Services;

namespace ControleHorasApp
{
    public partial class FormCriarTarefa : BaseForm
    {
        private readonly TaskService _taskService;
        public Task CurrentTask { get; set; }

        public FormCriarTarefa(TaskService taskService)
        {
            InitializeComponent();

            _taskService = taskService;
            mskEstimatedTime.ValidatingType = typeof(System.DateTime);
        }

        private void Aplicar()
        {
            if (string.IsNullOrEmpty(txtTaskName.Text))
            {
                DefaultMessage.ShowAlert("Um nome de tarefa deve ser informado");
                return;
            }

            if (mskEstimatedTime.Text == "00:00:00")
            {
                DefaultMessage.ShowAlert("As horas estimadas para a tarefa devem ser informadas.");
                return;
            }

            if (CurrentTask == null)
            {
                _taskService.AddTask(new Task
                {
                    TaskName = txtTaskName.Text,
                    Description = txtDescription.Text,
                    EstimatedTime = mskEstimatedTime.Text
                });
                LogService.Write("FormCriarTarefa::Aplicar", $"Tarefa criada: {txtTaskName.Text}, Tempo estimado: {mskEstimatedTime.Text}");
            }
            else
            {
                _taskService.UpdateInfo(
                    CurrentTask.Id,
                    txtTaskName.Text,
                    mskEstimatedTime.Text,
                    txtDescription.Text);
                LogService.Write("FormCriarTarefa::Aplicar", $"Tarefa atualizada: ${txtTaskName.Text}, Tempo estimado: ${mskEstimatedTime.Text}");
            }

            Close();
        }

        private void FormCriarTarefa_Load(object sender, System.EventArgs e)
        {
            if (CurrentTask == null)
            {
                TituloForm = "New Task";
                mskEstimatedTime.Text = "00:00:00";
            }
            else
            {
                TituloForm = "Edit Task";
                txtTaskName.Text = CurrentTask.TaskName;
                txtDescription.Text = CurrentTask.Description;
                mskEstimatedTime.Text = CurrentTask.EstimatedTime;
            }
        }

        private void mskEstimatedTime_Leave(object sender, System.EventArgs e)
        {
            mskEstimatedTime.Text = mskEstimatedTime.Text.Replace("_", "0");
        }

        private void btnApply_Click(object sender, System.EventArgs e) => Aplicar();

        private void btnCancel_Click(object sender, System.EventArgs e) => Close();

    }
}
