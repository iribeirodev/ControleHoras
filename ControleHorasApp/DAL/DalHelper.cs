using ControleHorasApp.DTO;
using ControleHorasApp.Services;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace ControleHorasApp.DAL
{
    public class DalHelper
    {
        private static SQLiteConnection sqliteConnection;
        private static string createTableCmdText = "CREATE TABLE IF NOT EXISTS Tarefas" +
            "(id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "Nome Varchar(50), " +
            "DataInicio VarChar(20), " +
            "TempoDecorrido VarChar(20), " +
            "Status VarChar(20))";

        public DalHelper(){ }

        private static string GetDataPath()
        {
            return ConfigurationManager.AppSettings["DataPath"];
        }

        private static SQLiteConnection DbConnection()
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

        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(GetDataPath());
            }
            catch
            {
                throw;
            }
        }

        public static void CriarTabelaSQlite()
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

        public static DataTable GetTarefas()
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

        public static void Add(Tarefa tarefa)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarStatus(int id, string status)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "UPDATE Tarefas SET Status=@status WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetarContagem(int id, string status, string tempoDecorrido)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "UPDATE Tarefas SET Status=@status, TempoDecorrido=@tempoDecorrido WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@tempoDecorrido", tempoDecorrido);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Tarefas Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
