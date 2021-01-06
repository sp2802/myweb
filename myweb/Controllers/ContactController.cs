using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myweb.Controllers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private List<Contact> contacts = new List<Contact>{

            new Contact{ Id = 1,FirstName="Shailja"},
            new Contact{ Id=2,FirstName="Neha"}
        };

        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return contacts;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if(contact==null)
            {
                return NotFound(new { Message = "Contact has not been Found." });
            }
            return Ok(contact);
        }

        // POST api/<ContactController>
        [HttpPost]
        public ActionResult<IEnumerable<Contact>> Post(Contact newContact)
        {
            contacts.Add(newContact);
            return contacts;
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Contact>> Put(int id, Contact updatedContact)
        {
            Contact contact=contacts.FirstOrDefault(c=>c.Id==id);
            if (contact == null) 
            {
                return NotFound();
            }
            contact.FirstName = updatedContact.FirstName;
            return contacts;
        }
       

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Contact>> Delete(int id)
        {

            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }


            contacts.Remove(contact);
            return contacts;
        }
    }
}
