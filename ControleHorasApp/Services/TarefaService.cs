using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ControleHorasApp.DAL;
using ControleHorasApp.DTO;

namespace ControleHorasApp.Services
{
    public class TarefaService
    {
        #region constructor
        private readonly DalTarefas _dalHelper;

        public TarefaService(DalTarefas dalHelper)
        {
            _dalHelper = dalHelper;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Inclui uma tarefa
        /// </summary>
        /// <param name="tarefa"></param>
        public void IncluirTarefa(Tarefa tarefa)
        {
            try
            {
                _dalHelper.Add(tarefa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtém todas as tarefas
        /// </summary>
        /// <returns></returns>
        public List<Tarefa> GetTarefas()
        {
            try
            {
                var dt = _dalHelper.GetTarefas();
                var lista = (from DataRow row in dt.Rows
                 select new Tarefa
                 {
                     Id = int.Parse(row["Id"].ToString()),
                     Nome = row["Nome"].ToString(),
                     DataInicio = DateTime.Parse(row["DataInicio"].ToString()),
                     TempoDecorrido = row["TempoDecorrido"].ToString(),
                     Status = row["Status"].ToString()
                 }).ToList();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtém uma tarefa pelo id
        /// </summary>
        public Tarefa GetTarefa(int id)
        {
            try
            {
                return _dalHelper.GetTarefaById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Atualiza o nome da tarefa pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novoNome"></param>
        public void AtualizarNome(int id, string novoNome, string descricao = "")
        {
            try
            {
                _dalHelper.Update(id, novoNome: novoNome, descricao: descricao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Atualiza o status da tarefa pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novoStatus"></param>
        public void AtualizarStatus(int id, string novoStatus)
        {
            try
            {
                _dalHelper.Update(id, status: novoStatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Atualiza a contagem de tempo e o status pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tempoDecorrido"></param>
        /// <param name="novoStatus"></param>
        public void SetarContagem(int id, string tempoDecorrido, string novoStatus)
        {
            try
            {
                _dalHelper.Update(id, status: novoStatus, tempoDecorrido: tempoDecorrido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Exclui uma tarefa pelo id
        /// </summary>
        /// <param name="id"></param>
        public void ExcluirTarefa(int id)
        {
            try
            {
                _dalHelper.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
