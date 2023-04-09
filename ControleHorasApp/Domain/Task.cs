using System;
using ControleHorasApp.Infrastructure.Enums;

namespace ControleHorasApp.Domain
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string EstimatedTime { get; set; }
        public string CurrentTime { get; set; } = "00:00:00";
        public EnumTaskStatus Status { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
