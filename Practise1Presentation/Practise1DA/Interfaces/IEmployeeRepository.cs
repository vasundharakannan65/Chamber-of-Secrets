using Practise1DA.models;
using Practise1DA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1DA.Interfaces
{
    public interface IEmployeeRepository
    {
        ErrorResponse<Designation> CreateDesignation(Designation designation);
    }
}
