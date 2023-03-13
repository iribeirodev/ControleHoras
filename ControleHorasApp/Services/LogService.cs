using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleHorasApp.Services
{
    public class LogService
    {
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

        public static string ObterLog()
        {
            string logPath = ConfigurationManager.AppSettings["LogPath"];
            if (!File.Exists(logPath))
                return "";

            return File.ReadAllText(logPath);
        }
    }
}
