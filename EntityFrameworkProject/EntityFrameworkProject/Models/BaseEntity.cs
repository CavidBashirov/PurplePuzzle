using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
