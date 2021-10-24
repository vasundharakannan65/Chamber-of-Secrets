
using Practise1DA.Repositories;
using Practise1DA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1BL.Logics
{
    public class AccountBL
    {
        private readonly UserRepository _userRepository;

        public AccountBL(UserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        //public async Task<ErrorResponse<User>> CreatingUser(Register register)
        //{
        //    return await _userRepository.RegisterUser(register);
        //}
        //public async Task<ErrorResponse<User>> LoggingInUser(Login login)
        //{
        //    return await _userRepository.LoginUser(login);
        //}
    }
}
