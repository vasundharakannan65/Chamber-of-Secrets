using Microsoft.AspNetCore.Mvc;
using Practise1BL.Logics;
using Practise1DA.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise1Presentation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeBL _employeeBL;

        public EmployeeController(EmployeeBL employeeBL)
        {
            this._employeeBL = employeeBL;
        }

        public IActionResult Index()
        {
            return View();
        } 

        [HttpGet]
        public IActionResult AddDesignation()
        {
            return View();
        }

        //POST: /Employee/AddDesignation
        [HttpPost]
        public IActionResult AddDesignation(Designation designation)
        {
            try
            {
                var res = _employeeBL.AddDesignation(designation);
                if(res.Succeeded == true)
                {
                    ViewBag.Msg = "Designation has been successfully added!";
                    RedirectToAction("Index", "Home");
                } 
                else
                {
                    throw new Exception(res.Message);
                }
            }
            catch(Exception e)
            {
                ViewBag.Msg = e.Message;
            }

            return View(designation);

        }
    }
}
