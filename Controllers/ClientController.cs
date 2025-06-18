using Microsoft.AspNetCore.Mvc;


using ClientsDirectory.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClientsDirectory.Controllers
{
    [Route("[controller]/[action]")]
    public class ClientController : Controller
    {
        private static List<ClientInfo> clientList = new List<ClientInfo>();

        [HttpGet("/")]
        public IActionResult ShowAllClientDetails()
        {
            return View(clientList);
        }

        [HttpGet("{id}")]
        public IActionResult GetDetailsByClientId(int id)
        {
            var client = clientList.FirstOrDefault(c => c.ClientId == id);
            return View("ClientDetails", client);
        }

        [HttpGet("{name}")]
        public IActionResult GetDetailsByCompanyName(string name)
        {
            var client = clientList.FirstOrDefault(c => c.CompanyName.ToLower() == name.ToLower());
            return View("ClientDetails", client);
        }

        [HttpGet("{email}")]
        public IActionResult GetDetailsByEmail(string email)
        {
            var client = clientList.FirstOrDefault(c => c.Email.ToLower() == email.ToLower());
            return View("ClientDetails", client);
        }

        [HttpGet("{category}")]
        public IActionResult GetDetailsByCategory(string category)
        {
            var filteredClients = clientList.Where(c => c.Category.ToLower() == category.ToLower()).ToList();
            return View("ShowAllClientDetails", filteredClients);
        }

        [HttpGet("{standard}")]
        public IActionResult GetDetailsByStandard(string standard)
        {
            var filteredClients = clientList.Where(c => c.Standard.ToLower() == standard.ToLower()).ToList();
            return View("ShowAllClientDetails", filteredClients);
        }

        [HttpGet]
        public IActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddClient(ClientInfo clientInfo)
        {
            clientList.Add(clientInfo);
            return RedirectToAction("ShowAllClientDetails");
        }
    }
}
