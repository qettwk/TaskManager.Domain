﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain
{
    public class Group
    {
        public Guid id {  get; set; }
        public string Name { get; set; }
        public List<Worker> Workers { get; set; }

    }
}
