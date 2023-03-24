﻿using System;
using System.Windows.Forms;
using ControleHorasApp.Services;
using Microsoft.Extensions.DependencyInjection;

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
                MessageBox.Show("Erro : " + ex.Message);
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
            HabilitarBotoesPorStatus(status);
        }

        /// <summary>
        /// Habilita/Desabilita botões por status da tarefa
        /// </summary>
        /// <param name="status">status selecionado</param>
        private void HabilitarBotoesPorStatus(string status)
        {
            if (status == "stopped")
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
                MessageBox.Show("Selecione uma tarefa primeiro.");
                return;
            }

            using (var formCriarTarefa = Program.ServiceProvider.GetRequiredService<FormCriarTarefa>())
            {
                formCriarTarefa.Edicao = true;
                formCriarTarefa.Id = ObterId();
                formCriarTarefa.NomeAtual = ObterValorSelecionado(1);

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
            var tempoDecorrido = ObterDiferencaHoras(DateTime.Parse(ObterValorSelecionado(2)));
            var ultimaLinhaSelecionada = dgvTarefas.CurrentCell.RowIndex;

            _tarefaService.SetarContagem(ObterId(), tempoDecorrido, "started");

            LogService.Write("Iniciar Tarefa", ObterValorSelecionado(1));

            InterromperOutrasTarefas(ObterId());

            CarregarDados(limparSelecao: true);
            txtNomeTarefa.Text = "";
            txtDataInicio.Text = "";
            txtTempoDecorrido.Text = "";

            HabilitarBotoesPorStatus("started");
        }

        /// <summary>
        /// Interrompe a contagem de tempo de uma tarefa marcando com status stopped.
        /// </summary>
        private void PararContagem()
        {
            var tempoDecorrido = ObterDiferencaHoras(DateTime.Parse(ObterValorSelecionado(2)));

            _tarefaService.SetarContagem(ObterId(), tempoDecorrido, "stopped");

            LogService.Write("Parar Tarefa", ObterValorSelecionado(1));

            CarregarDados(limparSelecao: false);
            MostrarItens();
            HabilitarBotoesPorStatus("stopped");
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
                    _tarefaService.AtualizarStatus(currentId, "stopped");
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
                _tarefaService.AtualizarStatus(currentId, "stopped");
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
        #endregion

    }
}
