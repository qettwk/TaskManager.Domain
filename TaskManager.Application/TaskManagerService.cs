using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain;

namespace TaskManager.Application
{
    public class TaskManagerService : ITaskManagerService
    {
        private readonly ITaskManagerRepository taskManagerRepository;
        public TaskManagerService(ITaskManagerRepository taskManagerRepository)
        {
            this.taskManagerRepository = taskManagerRepository;
        }
        List<Domain.Task> ITaskManagerService.GetAllTasks()
        {
            return this.taskManagerRepository.GetAllTasks();
        }

        List<Domain.Worker> ITaskManagerService.GetAllWorkers()
        {
            return this.taskManagerRepository.GetAllWorkers();
        }

        void ITaskManagerService.AddTask(TaskManager.Domain.Task task)
        {
            this.taskManagerRepository.AddTask(task);
        }

        void ITaskManagerService.AddWorker(TaskManager.Domain.Worker worker)
        {
            this.taskManagerRepository.AddWorker(worker);
        }

        public void EditWorker(int id, Worker worker)
        {
            this.taskManagerRepository.EditWorker(id, worker);
        }

        public void EditTask(int id, Domain.Task task)
        {
            this.taskManagerRepository.EditTask(id, task);
        }

        public void DeleteWorker(int workerId)
        {
            this.taskManagerRepository.DeleteWorker(workerId);
        }

        public void DeleteTask(int taskId)
        {
            this.taskManagerRepository.DeleteTask(taskId);
        }
    }
}
