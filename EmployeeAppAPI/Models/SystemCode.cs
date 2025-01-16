using System.ComponentModel.DataAnnotations;
using EmployeeAppAPI.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppAPI.Models
{
    public class SystemCode: UserActivity
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
