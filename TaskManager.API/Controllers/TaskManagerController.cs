using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManager.Application;
using TaskManager.Domain;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        private readonly ITaskManagerService taskManagerService;

        public TaskManagerController(ITaskManagerService taskManagerService)
        {
            this.taskManagerService = taskManagerService;
        }

        [HttpGet]
        public ActionResult<List<Domain.Task>> GetAllTasks1()
        {
            return Ok(this.taskManagerService.GetAllTasks());
        }

        [HttpGet]
        public ActionResult<List<Domain.Task>> GetAllWorkers1()
        {
            return Ok(this.taskManagerService.GetAllWorkers());
        }

        [HttpPost]
        public ActionResult CreateWorker1(Worker worker)
        {
            this.taskManagerService.AddWorker(worker);
            return Ok();
        }

        [HttpPost]
        public ActionResult CreateTask1(Domain.Task task)
        {
            this.taskManagerService.AddTask(task);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult EditTask1(int id, [FromBody] Domain.Task task)
        {
            this.taskManagerService.EditTask(id, task);
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult EditWorker1(int id, [FromBody] Domain.Worker worker)
        {
            this.taskManagerService.EditWorker(id, worker);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTask1(int id)
        {
            this.taskManagerService.DeleteTask(id);
            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteWorker1(int id)
        {
            this.taskManagerService.DeleteWorker(id);
            return Ok();
        }

    }
}