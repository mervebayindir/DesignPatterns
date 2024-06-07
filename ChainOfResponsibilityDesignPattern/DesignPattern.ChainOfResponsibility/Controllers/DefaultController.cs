using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel modal)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee araeDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(araeDirector);
            treasurer.ProcessRequest(modal);
            return View();
        }
    }
}
