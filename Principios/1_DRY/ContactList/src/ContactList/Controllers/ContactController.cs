using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactList.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactList.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var contactList = new List<ContactGridItemViewModel> {new ContactGridItemViewModel("Daniel", "Mazzini", "daniel.mazzini@gmail.com", "Palacios 773", "Buenos Aires", "Argentina")};

            return View(contactList);
        }

        public IActionResult GetContactFromCsv()
        {
            var contactList = new List<ContactGridItemViewModel> { new ContactGridItemViewModel("Daniel", "Mazzini", "daniel.mazzini@csv.com", "Palacios 773", "Buenos Aires", "Argentina") };

            return View("Index",contactList);
        }

        public IActionResult GetContactFromService()
        {
            var contactList = new List<ContactGridItemViewModel> { new ContactGridItemViewModel("Daniel", "Mazzini", "daniel.mazzini@Service.com", "Palacios 773", "Buenos Aires", "Argentina") };

            return View("Index", contactList);
        }



    }
}
