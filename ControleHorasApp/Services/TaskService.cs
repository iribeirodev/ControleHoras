using System.Collections.Generic;
using ControleHorasApp.Domain;
using ControleHorasApp.Repository;

namespace ControleHorasApp.Services
{
    public class TaskService
    {
        #region constructor
        private readonly TarefaRepository _tarefaRepository;

        public TaskService(TarefaRepository tarefaRepository) => _tarefaRepository = tarefaRepository;

        #endregion

        #region Public Methods
        /// <summary>
        /// Inclui uma tarefa
        /// </summary>
        /// <param name="tarefa"></param>
        public void AddTask(Task task) => _tarefaRepository.Add(task);

        /// <summary>
        /// Obtém todas as tarefas
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks() => _tarefaRepository.GetTarefas();

        /// <summary>
        /// Obtém uma tarefa pelo id
        /// </summary>
        public Task GetTask(int id) => _tarefaRepository.GetTarefaById(id);

        /// <summary>
        /// Atualiza o nome da tarefa pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novoNome"></param>
        public void UpdateInfo(int id, string novoNome, string estimatedTime, string newDescription = "")
        {
            var taskToUpdate = _tarefaRepository.GetTarefaById(id);
            taskToUpdate.TaskName = novoNome;
            taskToUpdate.EstimatedTime = estimatedTime;

            if (!string.IsNullOrEmpty(newDescription)) taskToUpdate.Description = newDescription;

            _tarefaRepository.Update(taskToUpdate);
        }

        /// <summary>
        /// Atualiza a contagem de tempo e o status pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tempoDecorrido"></param>
        /// <param name="novoStatus"></param>
        public void UpdateCurrentTime(int id, string currentTime)
        {
            var taskToUpdate = _tarefaRepository.GetTarefaById(id);
            taskToUpdate.CurrentTime = currentTime;
            _tarefaRepository.Update(taskToUpdate);
        }

        /// <summary>
        /// Exclui uma tarefa pelo id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveTask(int id) => _tarefaRepository.Delete(id);

        #endregion
    }
}
