using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application
{
    public interface ITaskManagerService
    {
        List<Domain.Task> GetAllTasks();
        List<Domain.Worker> GetAllWorkers();
        void EditWorker(int id, Domain.Worker worker);
        void EditTask(int id, Domain.Task task);
        void AddTask(Domain.Task task);
        void AddWorker(Domain.Worker worker);

        void DeleteTask(int taskId);
        void DeleteWorker(int workerId);
    }
}
