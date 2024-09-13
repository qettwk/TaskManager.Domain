using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain
{
    public class Task
    {
        public int Id { get; set; }
        public Guid Id2 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WorkerId { get; set; }
        public Guid WorkerId2 {  get; set; }
        public Worker Worker { get; set; }


        // public Worker Worker { get; set; }

    }
}
