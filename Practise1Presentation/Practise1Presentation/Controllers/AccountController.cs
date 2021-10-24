using Microsoft.AspNetCore.Mvc;
using Practise1BL.Logics;
using Practise1DA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise1Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountBL _accountBL;

        public AccountController(AccountBL accountBL)
        {
            this._accountBL = accountBL;
        } 

        public IActionResult Register()
        {
            return View();
        } 

        //[HttpPost]
        //public async Task<IActionResult> Register([FromBody]Register register)
        //{
        //    ErrorResponse<bool> result = new(); 

        //    if(ModelState.IsValid)
        //    {
        //        var resultDetails = await _accountBL.CreatingUser(register);
        //        return Ok(resultDetails);
        //    }
        //    else
        //    {
        //        result.Succeeded = false;
        //        result.Status = 400;
        //        result.Message = "Error has occured!";
        //        return BadRequest(result);
        //    }
            
        //}
    }
}
