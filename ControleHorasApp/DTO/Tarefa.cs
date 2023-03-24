using System;

namespace ControleHorasApp.DTO
{
    public class Tarefa
    {
        public int Id { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Descricao { get; set; } = "";
        public DateTime DataInicio { get; set; }
        public string TempoDecorrido { get; set; } = "00:00";
        public string Status { get; set; } = "stopped";
    }
}
