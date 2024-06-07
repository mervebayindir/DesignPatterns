using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var values1 = _customerService.TGetByID(model.SenderID);
            var values2 = _customerService.TGetByID(model.RecevierID);

            values1.CustomerBalance -= model.Amount;
            values2.CustomerBalance += model.Amount;
            List<Customer> modifiedCustomers = new List<Customer>()
            {
                values1,
                values2
            };
            _customerService.TMultiUpdate(modifiedCustomers);
            return View();
        }
    }
}
