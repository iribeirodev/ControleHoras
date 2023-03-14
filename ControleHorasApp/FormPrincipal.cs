using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ControleHorasApp.DAL;
using ControleHorasApp.Services;

namespace ControleHorasApp
{


    [FlagsAttribute]
    public enum EXECUTION_STATE : uint
    {
        ES_AWAYMODE_REQUIRED = 0x00000040,
        ES_CONTINUOUS = 0x80000000,
        ES_DISPLAY_REQUIRED = 0x00000002,
        ES_SYSTEM_REQUIRED = 0x00000001
        // Legacy flag, should not be used.
        // ES_USER_PRESENT = 0x00000004
    }

    public partial class FormPrincipal : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);


        public FormPrincipal()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
            InitializeComponent();
        }

        #region Métodos Privados

        private void ExibirDados(bool limparSelecao = true)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetTarefas();
                dgvTarefas.DataSource = dt;
                if (limparSelecao)
                    dgvTarefas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

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

        private string ObterDiferencaHoras(DateTime inicio)
        {
            var agora = DateTime.Now;
            var tempoDecorrido = (agora - inicio).ToString(@"hh\:mm\:ss");
            return tempoDecorrido;
        }

        private int ObterId()
        {
            var rowSelected = dgvTarefas.SelectedRows[0];
            return int.Parse(rowSelected.Cells[0].Value.ToString());
        }

        private void ExcluirTarefa()
        {
            var rowSelected = dgvTarefas.SelectedRows[0];
            LogService.Write("Excluir Tarefa", "Excluindo tarefa " + rowSelected.Cells[1].Value.ToString());

            DalHelper.Delete(ObterId());
            ExibirDados(limparSelecao: true);

            txtNomeTarefa.Text = "";
            txtDataInicio.Text = "";
            txtTempoDecorrido.Text = "";
        }

        /// <summary>
        /// Interrompe as outras tarefas com exceção da tarefa idTarefa.
        /// </summary>
        /// <param name="idTarefa"></param>
        private void InterromperOutrasTarefas(int idTarefa)
        {
            foreach (DataGridViewRow row in dgvTarefas.Rows)
            {
                int currentId = int.Parse(row.Cells[0].Value.ToString());
                if (currentId != idTarefa)
                {
                    var tempoDecorrido = ObterDiferencaHoras(DateTime.Parse(row.Cells[2].Value.ToString()));
                    DalHelper.AtualizarStatus(currentId, "stopped");

                    LogService.Write("Interrompendo Tarefa", row.Cells[1].Value.ToString());
                }
            }

            ExibirDados();
        }

        #endregion

        #region Eventos
        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(100);
                ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void btnNovaTarefa_Click(object sender, EventArgs e)
        {
            var formCriarTarefa = new FormCriarTarefa();
            formCriarTarefa.ShowDialog();
            ExibirDados();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dgvTarefas.AutoGenerateColumns = false;
            ExibirDados();
        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e) => MostrarItens(e.RowIndex);

        private void btnIniciarContagem_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvTarefas.SelectedRows[0];
            var tempoDecorrido = ObterDiferencaHoras(DateTime.Parse(rowSelected.Cells[2].Value.ToString()));

            DalHelper.SetarContagem(ObterId(), "started", tempoDecorrido);

            LogService.Write("Iniciar Tarefa", rowSelected.Cells[1].Value.ToString());

            InterromperOutrasTarefas(ObterId());

            ExibirDados(limparSelecao: false);

            MostrarItens();

            btnIniciarContagem.Enabled = false;
            btnPararContagem.Enabled = true;
        }

        private void btnPararContagem_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvTarefas.SelectedRows[0];
            var tempoDecorrido = ObterDiferencaHoras(DateTime.Parse(rowSelected.Cells[2].Value.ToString()));

            DalHelper.SetarContagem(ObterId(), "stopped", tempoDecorrido);

            LogService.Write("Parar Tarefa", rowSelected.Cells[1].Value.ToString());

            ExibirDados(limparSelecao: false);

            MostrarItens();

            btnIniciarContagem.Enabled = true;
            btnPararContagem.Enabled = false;
        }

        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vai excluir a tarefa selecionada. Continua?", "Atenção",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                ExcluirTarefa();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var frmLog = new FormLog();
            frmLog.ShowDialog();
        }

        #endregion


    }
}
