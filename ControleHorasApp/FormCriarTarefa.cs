using System;
using System.Windows.Forms;
using ControleHorasApp.DAL;
using ControleHorasApp.DTO;

namespace ControleHorasApp
{
    public partial class FormCriarTarefa : Form
    {
        public FormCriarTarefa() => InitializeComponent();

        private void btnAplicar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNovaTarefa.Text))
            {
                MessageBox.Show("Nenhum nome para a tarefa foi definido.", "Atenção");
                return;
            }

            try
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = txtNovaTarefa.Text;
                tarefa.DataInicio = DateTime.Now;
                tarefa.TempoDecorrido = "00:00";
                tarefa.Status = "stopped";

                DalHelper.Add(tarefa);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
    }
}
