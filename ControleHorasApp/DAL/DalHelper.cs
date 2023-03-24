using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using ControleHorasApp.DTO;

namespace ControleHorasApp.DAL
{
    public class DalHelper
    {
        private SQLiteConnection sqliteConnection;
        private string createTableCmdText = "CREATE TABLE IF NOT EXISTS Tarefas" +
            "(id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "Nome VARCHAR(100), " +
            "DataInicio VARCHAR(20), " +
            "TempoDecorrido VARCHAR(20), " +
            "Status VARCHAR(20))";

        #region Private Methods
        /// <summary>
        /// Obtém o caminho do arquivo sqlite
        /// </summary>
        private string GetDataPath() => ConfigurationManager.AppSettings["DataPath"];

        /// <summary>
        /// Obtém uma instância aberta de DBConnection
        /// </summary>
        private SQLiteConnection DbConnection()
        {
            if (!File.Exists(GetDataPath()))
            {
                CriarBancoSQLite();
                CriarTabelaSQlite();
            }

            sqliteConnection = new SQLiteConnection("Data Source=" + GetDataPath() + "; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        /// <summary>
        /// Executa a criação de um novo arquivo sqlite
        /// </summary>
        private void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(GetDataPath());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Executa a criação da tabela no arquivo sqlite
        /// </summary>
        private void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = createTableCmdText;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Obtém todas as tarefas
        /// </summary>
        public DataTable GetTarefas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT t.id, t.Nome, STRFTIME('%d/%m/%Y %H:%M', t.DataInicio) AS DataInicio, t.TempoDecorrido, t.Status FROM Tarefas t";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inclui uma nova tarefa
        /// </summary>
        public void Add(Tarefa tarefa)
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Tarefas(Nome, DataInicio, TempoDecorrido, Status) values (@nome, @datainicio, @tempodecorrido, @status)";
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@datainicio", tarefa.DataInicio);
                cmd.Parameters.AddWithValue("@tempodecorrido", tarefa.TempoDecorrido);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Atualiza dados de uma tarefa
        /// </summary>
        public void Update(int id, string novoNome="", string status="", string tempoDecorrido="")
        {
            using (var cmd = new SQLiteCommand(DbConnection()))
            {
                var cmdText = new System.Text.StringBuilder();
                cmdText.Append("UPDATE Tarefas SET ");

                var fields = new List<string>();
                
                if (!string.IsNullOrEmpty(novoNome))
                {
                    fields.Add("Nome=@nome");
                    cmd.Parameters.AddWithValue("@nome", novoNome);
                }

                if (!string.IsNullOrEmpty(status))
                {
                    fields.Add("Status=@status");
                    cmd.Parameters.AddWithValue("@status", status);
                }

                if (!string.IsNullOrEmpty(tempoDecorrido))
                {
                    fields.Add("TempoDecorrido = @tempoDecorrido");
                    cmd.Parameters.AddWithValue("@tempoDecorrido", tempoDecorrido);
                }

                cmdText.Append(string.Join(",", fields));

                cmdText.Append(" WHERE id=@id");
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = cmdText.ToString();

                cmd.ExecuteNonQuery();
            }
        }
        
        /// <summary>
        /// Exclui uma tarefa pelo id
        /// </summary>
        public void Delete(int Id)
        {
            using (var cmd = new SQLiteCommand(DbConnection()))
            {
                cmd.CommandText = "DELETE FROM Tarefas Where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

    }
}
