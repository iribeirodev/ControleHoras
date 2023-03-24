using System;
using System.Configuration;
using System.IO;

namespace ControleHorasApp.Services
{
    public class LogService
    {
        /// <summary>
        /// Escreve no arquivo de log
        /// </summary>
        /// <param name="funcao">Função ou método de origem</param>
        /// <param name="message">Mensagem da linha de log</param>
        public static void Write(string funcao, string message)
        {
            string logPath = ConfigurationManager.AppSettings["LogPath"];

            if (!File.Exists(logPath))
            {
                var sw = File.CreateText(logPath);
                sw.Close();
            }

            string content = $"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")} - {funcao}: {message}\n";

            File.AppendAllText(logPath, content);
        }


        /// <summary>
        /// Obtém o conteúdo do arquivo de log
        /// </summary>
        public static string ObterLog()
        {
            string logPath = ConfigurationManager.AppSettings["LogPath"];
            if (!File.Exists(logPath))
                return "";

            return File.ReadAllText(logPath);
        }
    }
}
