using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain;

namespace TaskManager.Application
{
    public interface ITaskManagerRepository
    {
        List<Domain.Task> GetAllTasks();     
        List<Domain.Worker> GetAllWorkers();
        
        void EditTask(int id, Domain.Task task);
        void EditWorker(int workerId,Domain.Worker worker);
        void AddTask(Domain.Task task);
        void AddWorker(Domain.Worker worker);

        void DeleteTask(int taskId);
        void DeleteWorker(int workerId);
        // get задачи конкретного работника
    }
}
