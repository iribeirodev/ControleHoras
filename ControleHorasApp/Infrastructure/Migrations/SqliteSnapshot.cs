using System;
using System.Configuration;
using System.Data.SQLite;
using System.IO;

namespace ControleHorasApp.InfraStructure.Migrations
{
    public class SqliteSnapshot
    {
        public static void RunMigration()
        {
            var cmdText = @"CREATE TABLE IF NOT EXISTS Tasks(
                                Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                TaskName VARCHAR(50), 
                                Description VARCHAR(500), 
                                EstimatedTime VARCHAR(10), 
                                CurrentTime VARCHAR(10),
                                DateCreated VARCHAR(20)
                            )";
            var dataPath = ConfigurationManager.AppSettings["DataPath"];

            if (string.IsNullOrEmpty(dataPath))
                throw new Exception("Caminho do arquivo de dados desconhecido.");

            if (!File.Exists(dataPath))
            {
                // Cria o arquivo sqlite e executa a criação das tabelas
                using (var connection = new SQLiteConnection($"Data Source={dataPath}"))
                {
                    connection.Open();

                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = cmdText;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
