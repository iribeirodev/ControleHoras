using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Extensions.DependencyInjection;
using ControleHorasApp.Services;

namespace ControleHorasApp
{
    public partial class FormPrincipal : Form
    {
        #region Construtor
        private readonly TarefaService _tarefaService;

        public FormPrincipal(TarefaService tarefaService) 
        {
            _tarefaService = tarefaService;

            InitializeComponent();
        }
        
        #endregion

        #region Métodos Privados

        /// <summary>
        /// Carrega os dados persistidos de tarefas
        /// </summary>
        /// <param name="limparSelecao">Após carregar tirar seleção da linha</param>
        private void CarregarDados(bool limparSelecao = true)
        {
            try
            {
                var tarefas = _tarefaService.GetTarefas();
                dgvTarefas.DataSource = tarefas;
                if (limparSelecao)
                    dgvTarefas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        /// <summary>
        /// Carrega os textboxes a partir do dado selecionado da grid.
        /// </summary>
        /// <param name="index"></param>
        private void MostrarItens(int index = -1)
        {
            DataGridViewRow selectedRow;

            if (index == -1)
                selectedRow = dgvTarefas.SelectedRows[0];
            else
                selectedRow = dgvTarefas.Rows[index];

            txtNomeTarefa.Text = selectedRow.Cells[1].Value.ToString();
            txtDataInicio.Text = selectedRow.Cells[2].Value.ToString();
            txtTempoDecorrido.Text = selectedRow.Cells[3].Value.ToString();

            string status = selectedRow.Cells[4].Value.ToString();

            var statusTarefa = (EnumStatusTarefa) Enum.Parse(typeof(EnumStatusTarefa), status);
            HabilitarBotoesPorStatus(statusTarefa);

            //HabilitarBotoesPorStatus(status);
        }

        /// <summary>
        /// Habilita/Desabilita botões por status da tarefa
        /// </summary>
        /// <param name="status">status selecionado</param>
        private void HabilitarBotoesPorStatus(EnumStatusTarefa statusTarefa)
        {
            if (statusTarefa == EnumStatusTarefa.Stopped)
            {
                btnIniciarContagem.Enabled = true;
                btnPararContagem.Enabled = false;
            }
            else
            {
                btnIniciarContagem.Enabled = false;
                btnPararContagem.Enabled = true;
            }
        }

        /// <summary>
        /// Retorna a diferença de tempo no formato hh:mm:ss entre a data atual
        /// e a data de criação da tarefa
        /// </summary>
        private string ObterDiferencaHoras(DateTime dataTarefa) => (DateTime.Now - dataTarefa).ToString(@"hh\:mm\:ss");

        /// <summary>
        /// Obtém qualquer valor da linha selecionada por índice de coluna
        /// </summary>
        private string ObterValorSelecionado(int index) => dgvTarefas.SelectedRows[0].Cells[index].Value.ToString();

        /// <summary>
        /// Obtém o id de tarefa da linha selecionada
        /// </summary>
        private int ObterId() => int.Parse(dgvTarefas.SelectedRows[0].Cells[0].Value.ToString());

        /// <summary>
        /// Exibe uma janela para edição do título da tarefa
        /// </summary>
        private void Editar()
        {
            if (dgvTarefas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma tarefa primeiro.", "Atenção");
                return;
            }

            using (var formCriarTarefa = Program.ServiceProvider.GetRequiredService<FormCriarTarefa>())
            {
                formCriarTarefa.Edicao = true;

                var tarefaSelecionada = _tarefaService.GetTarefa(ObterId());

                formCriarTarefa.Id = tarefaSelecionada.Id;
                formCriarTarefa.NomeAtual = tarefaSelecionada.Nome;
                formCriarTarefa.Descricao = tarefaSelecionada.Descricao;

                formCriarTarefa.ShowDialog();
                CarregarDados();

                if (formCriarTarefa.Atualizada)
                {
                    txtNomeTarefa.Text = "";
                    txtDataInicio.Text = "";
                    txtTempoDecorrido.Text = "";
                }
            }
        }

        /// <summary>
        /// Exclui a tarefa selecionada
        /// </summary>
        private void ExcluirTarefa()
        {
            if (dgvTarefas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma tarefa primeiro.", "Atenção");
                return;
            }
            if (MessageBox.Show("Vai excluir a tarefa selecionada. Continua?", "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogService.Write("Excluir Tarefa", $"Excluindo tarefa {ObterValorSelecionado(1)} ");

                _tarefaService.ExcluirTarefa(ObterId());
                CarregarDados(limparSelecao: true);

                txtNomeTarefa.Text = "";
                txtDataInicio.Text = "";
                txtTempoDecorrido.Text = "";
            }
        }

        /// <summary>
        /// Inicia a contagem de tempo de uma tarefa marcando com status started.
        /// </summary>
        private void IniciarContagem()
        {
            if (dgvTarefas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma tarefa primeiro.", "Atenção");
                return;
            }

            var tempoDecorrido = ObterDiferencaHoras(DateTime.Parse(ObterValorSelecionado(2)));

            _tarefaService.SetarContagem(ObterId(), tempoDecorrido, EnumStatusTarefa.Started);

            LogService.Write("Iniciar Tarefa", ObterValorSelecionado(1));

            InterromperOutrasTarefas(ObterId());
            CarregarDados(limparSelecao: false);

            var statusTarefa = (EnumStatusTarefa)Enum.Parse(typeof(EnumStatusTarefa), "Started");
            HabilitarBotoesPorStatus(statusTarefa);
        }

        /// <summary>
        /// Interrompe a contagem de tempo de uma tarefa marcando com status stopped.
        /// </summary>
        private void PararContagem()
        {
            if (dgvTarefas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma tarefa primeiro.", "Atenção");
                return;
            }

            var tempoDecorrido = ObterDiferencaHoras(DateTime.Parse(ObterValorSelecionado(2)));

            _tarefaService.SetarContagem(ObterId(), tempoDecorrido, EnumStatusTarefa.Stopped);

            LogService.Write("Parar Tarefa", ObterValorSelecionado(1));

            CarregarDados(limparSelecao: false);
            MostrarItens();

            var statusTarefa = (EnumStatusTarefa)Enum.Parse(typeof(EnumStatusTarefa), "Stopped");
            HabilitarBotoesPorStatus(statusTarefa);
        }

        /// <summary>
        /// Interrompe as outras tarefas com exceção da tarefa idTarefa.
        /// </summary>
        /// <param name="idTarefa"></param>
        private void InterromperOutrasTarefas(int idTarefa)
        {
            foreach (DataGridViewRow row in dgvTarefas.Rows)
            {
                var currentId = int.Parse(row.Cells[0].Value.ToString());
                if (currentId != idTarefa)
                {
                    _tarefaService.AtualizarStatus(currentId, EnumStatusTarefa.Stopped);
                    LogService.Write("Interrompendo Tarefa", row.Cells[1].Value.ToString());
                }
            }
            CarregarDados();
        }

        /// <summary>
        /// Interrompe todas as tarefas marcando com status stopped.
        /// </summary>
        private void InterromperTarefas()
        {
            foreach (DataGridViewRow row in dgvTarefas.Rows)
            {
                var currentId = int.Parse(row.Cells[0].Value.ToString());
                _tarefaService.AtualizarStatus(currentId, EnumStatusTarefa.Stopped);
            }
            LogService.Write("InterromperTarefas", "Fechando app");
        }

        #endregion

        #region Eventos
        private void btnNovaTarefa_Click(object sender, EventArgs e)
        {
            using (var formCriarTarefa = Program.ServiceProvider.GetRequiredService<FormCriarTarefa>())
            {
                formCriarTarefa.ShowDialog();
            }
                
            CarregarDados();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dgvTarefas.AutoGenerateColumns = false;
            CarregarDados();

            btnIniciarContagem.BackgroundImageLayout = ImageLayout.Center;
            btnIniciarContagem.BackgroundImage = Image.FromFile("Images/play.png");

            btnPararContagem.BackgroundImageLayout = ImageLayout.Center;
            btnPararContagem.BackgroundImage = Image.FromFile("Images/stop.png");

            btnIniciarContagem.ImageAlign = ContentAlignment.MiddleCenter;
            btnPararContagem.ImageAlign = ContentAlignment.MiddleCenter;

            dgvTarefas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTarefas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTarefas.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e) => MostrarItens(e.RowIndex);

        private void btnIniciarContagem_Click(object sender, EventArgs e) => IniciarContagem();

        private void btnPararContagem_Click(object sender, EventArgs e) => PararContagem();

        private void btnEditar_Click(object sender, EventArgs e) => Editar();

        private void btnExcluirTarefa_Click(object sender, EventArgs e) => ExcluirTarefa();

        private void btnLog_Click(object sender, EventArgs e)
        {
            var frmLog = new FormLog();
            frmLog.ShowDialog();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e) => InterromperTarefas();

        private void lblClose_Click(object sender, EventArgs e) => Close();

        private void lblMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        #endregion

    }
}
