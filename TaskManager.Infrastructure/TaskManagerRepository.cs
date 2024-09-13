using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application;
using TaskManager.Domain;

namespace TaskManager.Infrastructure
{
    public class TaskManagerRepository : ITaskManagerRepository
    {
        public static List<Domain.Task> lstTasks = new List<Domain.Task>()
        {
            new Domain.Task{ Id = 1, Name = "Paint", Description = "Painting.", WorkerId = 1 },
            new Domain.Task{ Id = 2, Name = "Build", Description = "Builing.", WorkerId = 2 },
            new Domain.Task{ Id = 3, Name = "Delivery", Description = "Delivering.", WorkerId = 2 }
        };

        public static List<Domain.Worker> lstWorkers = new List<Domain.Worker>()
        {
            new Domain.Worker{ Id = 1, Name = "John", TasksId = new List<int>{1 } },
            new Domain.Worker{ Id = 2, Name = "Boris",TasksId = new List<int>{ 2,3 } }
        };

        public void AddTask(Domain.Task task)
        {
            lstTasks.Add(new Domain.Task
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                WorkerId = task.WorkerId
            });
        }

        public void AddWorker(Worker worker)
        {
            lstWorkers.Add(new Domain.Worker
            {
                Id = worker.Id,
                Name = worker.Name,
                TasksId = new List<int>(worker.TasksId)
            });
        }

        public List<Domain.Worker> GetAllWorkers()
        {
            return lstWorkers;
        }

        public List<Domain.Task> GetAllTasks()
        {
            return lstTasks;
        }

        public void EditTask(int id, Domain.Task task)
        {
            var changedTask = lstTasks.Where(t => t.Id == id).FirstOrDefault();
            changedTask.Name = task.Name;
            changedTask.WorkerId = task.WorkerId;
        }

        public void EditWorker(int id, Domain.Worker worker)
        {
            var changedWorker = lstWorkers.Where(w => w.Id == id).FirstOrDefault();
            changedWorker.Name = worker.Name;
            changedWorker.TasksId = new List<int>(worker.TasksId);
        }

        public void DeleteWorker(int id)
        {
            var deletedWorker = lstWorkers.Single(w => w.Id == id);
            lstWorkers.Remove(deletedWorker);
        }

        public void DeleteTask(int id)
        {
            var deletedTask = lstTasks.Single(t => t.Id == id);
            lstTasks.Remove(deletedTask);
        }
    }
}
