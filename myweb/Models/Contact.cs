using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Controllers.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

        // public int MyProperty { get; set; }
       

    }
}
