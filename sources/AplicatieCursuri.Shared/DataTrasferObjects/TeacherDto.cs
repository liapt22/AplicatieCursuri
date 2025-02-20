using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCursuri.Shared.DataTrasferObjects
{
    class TeacherDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        //public ICollection<Course> Courses { get; set; }
        //public ApplicationUser User { get; set; }
    }
}
