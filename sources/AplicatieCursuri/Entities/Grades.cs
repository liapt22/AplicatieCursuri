using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCursuri.Core.Entities
{
   public class Grades
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid CourseId { get; set; }
        public Student student;
        public Course Course;
        public int score { get; set; }
        public int atendance { get; set; }
    }
}
