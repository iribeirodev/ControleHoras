using System;
using System.Threading.Tasks;
using ControleHorasApp.Services;

namespace ControleHorasApp.InfraStructure.CrossCutting
{
    public class ExceptionHandler
    {
        public async Task HandleExceptionAsync(Exception exception)
        {
            LogService.Write("ExceptionHandler",$"Ocorreu um erro: {exception.Message}");
        }
    }
}
