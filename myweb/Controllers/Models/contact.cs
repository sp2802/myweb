using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Controllers.Models
{
    public class contact
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;
    }
}
