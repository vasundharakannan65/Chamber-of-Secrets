using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Practise1DA.Interfaces;
using Practise1DA.models;
using Practise1DA.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1DA.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _configuration;

        public EmployeeRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public ErrorResponse<Designation> CreateDesignation(Designation designation)
        {
            ErrorResponse<Designation> data = new();

            using IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            string sp = "[dbo].[sp_adddesignation]";

            DynamicParameters parameters = new();

            parameters.Add("Name", designation.Name);


            try
            {
                SqlMapper.Execute(dbConnection, sp, commandType: CommandType.StoredProcedure, param: parameters);
            } 
            catch(Exception e)
            {
                data.Status = 400;
                data.Message = e.Message;
                data.Succeeded = false;
                data.Data = designation;
            }

            return data;
        }
    }
}
