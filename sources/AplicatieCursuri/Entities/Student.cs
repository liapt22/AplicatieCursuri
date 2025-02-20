﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCursuri.Core.Entities
{
   public class Student
    {
        public string UserId { get; set; }
        public Guid Id { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public Student student;
    }
}
