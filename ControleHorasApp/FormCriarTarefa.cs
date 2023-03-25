using System;
using System.Windows.Forms;
using ControleHorasApp.DTO;
using ControleHorasApp.Services;

namespace ControleHorasApp
{
    public partial class FormCriarTarefa : Form
    {
        private readonly TarefaService _tarefaService;

        public bool Edicao { get; set; } = false;
        public int Id { get; set; }
        public string NomeAtual { get; set; }
        public string Descricao { get; set; }
        public bool Atualizada { get; set; } = false;

        public FormCriarTarefa(TarefaService tarefaService) 
        {
            _tarefaService = tarefaService;
            InitializeComponent();
        } 

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
                var tarefa = new Tarefa
                {
                    Nome = txtNovaTarefa.Text,
                    Descricao = txtDescricao.Text,
                    DataInicio = DateTime.Now,
                    TempoDecorrido = "00:00:00",
                    Status = "stopped"
                };

                _tarefaService.IncluirTarefa(tarefa);

                LogService.Write("Criar Tarefa", tarefa.Nome);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void AtualizarTarefa()
        {
            try
            {
                _tarefaService.AtualizarNome(this.Id, txtNovaTarefa.Text, txtDescricao.Text);
                LogService.Write("Atualizar Tarefa", "Atualizando Tarefa " + NomeAtual + " com novo nome " + txtNovaTarefa.Text);
                Atualizada = true;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
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
                txtDescricao.Text = Descricao;
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
