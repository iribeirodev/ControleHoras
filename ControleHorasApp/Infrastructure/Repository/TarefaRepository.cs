using System.Collections.Generic;
using System.Linq;
using Dapper;
using ControleHorasApp.Domain;

namespace ControleHorasApp.Repository
{
    public class TarefaRepository: BaseRepository
    {
        /// <summary>
        /// Obtém todas as tarefas
        /// </summary>
        public List<Task> GetTarefas()
        {
            using (var cnn = DbConnection())
            {
                var cmdText = @"SELECT t.Id
                                            , t.TaskName
                                            , t.Description
                                            , t.EstimatedTime
                                            , t.CurrentTime
                                            , STRFTIME('%d/%m/%Y %H:%M', t.DateCreated) AS DateCreated
                                      FROM Tasks t";
                return cnn.Query<Task>(cmdText).ToList();
            }
        }

        /// <summary>
        /// Obtém uma tarefa pelo id
        /// </summary>
        public Task GetTarefaById(int id)
        {
            using (var cnn = DbConnection())
            {
                var cmdText = @"SELECT t.Id
                                            , t.TaskName
                                            , t.Description
                                            , t.EstimatedTime
                                            , t.CurrentTime
                                            , STRFTIME('%d/%m/%Y %H:%M', t.DateCreated) AS DateCreated
                                   FROM Tasks t
                                  WHERE t.Id = @TaskId";
                return cnn.QuerySingle<Task>(cmdText, new { TaskId = id });
            }
        }

        /// <summary>
        /// Inclui uma nova tarefa
        /// </summary>
        public void Add(Task task)
        {
            using (var cnn = DbConnection())
            {
                var cmdText = @"INSERT INTO Tasks(TaskName, Description, EstimatedTime, CurrentTime, DateCreated) VALUES 
                                (@TaskName, @Description, @EstimatedTime, @CurrentTime, @DateCreated)";

                cnn.Execute(cmdText, task);
            }
        }

        /// <summary>
        /// Atualiza dados de uma tarefa
        /// </summary>
        public void Update(Task task)
        {
            using (var cnn = DbConnection())
            {
                var cmdText = @"UPDATE Tasks SET 
                                    TaskName = @TaskName
                                    , Description = @Description
                                    , EstimatedTime = @EstimatedTime
                                    , CurrentTime = @CurrentTime 
                                WHERE id = @Id";
                cnn.Execute(cmdText, task);
            }
        }

        /// <summary>
        /// Exclui uma tarefa pelo id
        /// </summary>
        public void Delete(int id)
        {
            using (var cnn = DbConnection())
            {
                var cmdText = "DELETE FROM Tasks WHERE id = @TaskId";
                cnn.Execute(cmdText, new { TaskId = id });
            }
        }
    }
}
