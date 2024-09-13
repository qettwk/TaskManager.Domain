using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain
{
    public class Worker
    {
        public int Id { get; set; }
        public Guid Id2 { get; set; }
        public string Name { get; set; }
        
        public List<int> TasksId { get; set; }
        public List<Task> Tasks { get; set; }
        public Group Group { get; set; }
        public Guid GroupId { get; set; }

    }
}
