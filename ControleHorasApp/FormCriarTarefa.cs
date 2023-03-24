using System;
using System.Windows.Forms;
using ControleHorasApp.DAL;
using ControleHorasApp.DTO;
using ControleHorasApp.Services;

namespace ControleHorasApp
{
    public partial class FormCriarTarefa : Form
    {
        public bool Edicao { get; set; } = false;
        public int Id { get; set; }
        public string NomeAtual { get; set; }
        public bool Atualizada { get; set; } = false;

        public FormCriarTarefa() => InitializeComponent();

        #region Métodos Privados
        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtNovaTarefa.Text))
            {
                MessageBox.Show("Nenhum nome para a tarefa foi definido.", "Atenção");
                return false;
            }

            return true;
        }

        private void CriarTarefa()
        {
            try
            {
                var tarefa = new Tarefa();
                tarefa.Nome = txtNovaTarefa.Text;
                tarefa.DataInicio = DateTime.Now;
                tarefa.TempoDecorrido = "00:00:00";
                tarefa.Status = "stopped";

                DalHelper.Add(tarefa);
                LogService.Write("Criar Tarefa", tarefa.Nome);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void AtualizarTarefa()
        {
            try
            {
                DalHelper.AtualizarNome(this.Id, txtNovaTarefa.Text);
                LogService.Write("Atualizar Tarefa", "Atualizando Tarefa " + NomeAtual + " com novo nome " + txtNovaTarefa.Text);
                Atualizada = true;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Aplicar()
        {
            if (!Validar()) return;

            if (Edicao)
                AtualizarTarefa();
            else
                CriarTarefa();
        }

        #endregion

        #region Eventos
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Aplicar();
        }

        private void FormCriarTarefa_Load(object sender, EventArgs e)
        {
            if (Edicao)
            {
                Text = "Editar Tarefa";
                txtNovaTarefa.Text = NomeAtual;
            }
        }

        private void txtNovaTarefa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Aplicar();
            }
        }
        #endregion

    }
}
