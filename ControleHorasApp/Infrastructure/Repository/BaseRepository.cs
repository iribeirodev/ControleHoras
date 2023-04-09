using System.Configuration;
using System.Data.SQLite;

namespace ControleHorasApp.Repository
{
    public class BaseRepository
    {
        /// <summary>
        /// Obtém o caminho do arquivo SQLite
        /// </summary>
        /// <returns></returns>
        private string GetDataPath() => ConfigurationManager.AppSettings["DataPath"];

        /// <summary>
        /// Obtém uma instância aberta de DBConnection
        /// </summary>
        protected SQLiteConnection DbConnection()
        {
            var connection = new SQLiteConnection($"Data Source={GetDataPath()}");
            connection.Open();
            return connection;
        }
    }
}
