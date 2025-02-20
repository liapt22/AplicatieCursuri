using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCursuri.Shared.DataTrasferObjects
{
    class CourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
       // public ICollection<Student> Students { get; set; }
       // public Teacher Teacher { get; set; }
        public Guid TeacherId { get; set; }
    }
}
