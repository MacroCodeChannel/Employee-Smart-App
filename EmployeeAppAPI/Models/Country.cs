using EmployeeAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace EmployeeAppAPI.Models
{
    public class Country : UserActivity
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}




