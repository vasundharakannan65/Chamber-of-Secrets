using Practise1DA.Interfaces;
using Practise1DA.models;
using Practise1DA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1BL.Logics
{
    public class EmployeeBL
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeBL(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public ErrorResponse<Designation> AddDesignation(Designation designation)
        {
            
            var result = _employeeRepository.CreateDesignation(designation);
            return result;
        }
    }
}
