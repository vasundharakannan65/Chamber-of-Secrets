
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Practise1DA.Interfaces;
using Practise1DA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1DA.Repositories
{
    public class UserRepository : IUserRepository
    {
        //private readonly SignInManager<User> _signInManager;
        //private readonly UserManager<User> _userManager;
        //private readonly RoleManager<Role> _roleManager;

        //public UserRepository(SignInManager<User> signInManager, UserManager<User> userManager,RoleManager<Role> roleManager)
        //{
        //    this._signInManager = signInManager;
        //    this._userManager = userManager;
        //    this._roleManager = roleManager;
        //}

        //public async Task<ErrorResponse<User>> RegisterUser([FromBody] Register register)
        //{

        //    var userExist = await _userManager.FindByEmailAsync(register.EmailId);

        //    var user = new User
        //    {
        //        EmailId = register.EmailId,
        //        Password = register.Password
        //    };


        //    if (userExist == null)
        //    {

        //        var registeredUser = await _userManager.CreateAsync(user, register.Password);

        //        if (!await _roleManager.RoleExistsAsync("Administrator"))
        //        {
        //            await _roleManager.CreateAsync(new Role { RoleName = "Administrator" });
        //        }

        //        if (!await _roleManager.RoleExistsAsync("Employee"))
        //        {
        //            await _roleManager.CreateAsync(new Role { RoleName = "Employee" });
        //        }

        //        if (registeredUser.Succeeded && register.Administrator == true)
        //        {
        //            if (await _roleManager.RoleExistsAsync("Administrator"))
        //            {
        //                await _userManager.AddToRoleAsync(user, "Administrator");
        //            }
        //        } 
        //        else
        //        {
        //            if (await _roleManager.RoleExistsAsync("Employee"))
        //            {
        //                await _userManager.AddToRoleAsync(user, "Employee");
        //            }
        //        }

        //        var result = new ErrorResponse<User>
        //        {
        //            Status = 200,
        //            Message = "User has been successfully registered!",
        //            Succeeded = true,
        //            Data = user
        //        };

        //        return result;

        //    }
        //    else
        //    {

        //        var result = new ErrorResponse<User>
        //        {
        //            Status = 400,
        //            Message = "User has been already registered!",
        //            Succeeded = false,
        //            Data = user
        //        };

        //        return result;
        //    }

        //} 

        //public async Task<ErrorResponse<User>> LoginUser(Login login)
        //{
        //    var user = await _userManager.FindByEmailAsync(login.EmailID);

        //    var userDetails = new User
        //    {
        //        EmailId = login.EmailID,
        //        Password = login.Password
        //    };


        //    if (user != null)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(
        //         user.EmailId, login.Password, login.RememberMe, false);

        //        var error = new ErrorResponse<User>
        //        {
        //            Status = 200,
        //            Message = "You have been successfully logged In!",
        //            Succeeded = false,
        //            Data = userDetails
        //        };

        //        return error;
        //    }
        //    else
        //    {

        //        var result = new ErrorResponse<User>
        //        {
        //            Status = 400,
        //            Message = "Error has occurred - Please try to register the user!",
        //            Succeeded = false,
        //            Data = userDetails
        //        };

        //        return result;
        //    }
        //}

    }
}
