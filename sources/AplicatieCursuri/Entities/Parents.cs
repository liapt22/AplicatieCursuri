using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicatieCursuri.Shared;
namespace AplicatieCursuri.Core.Entities
{
  public  class Parents
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
