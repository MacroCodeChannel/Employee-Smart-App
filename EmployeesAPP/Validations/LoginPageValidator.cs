using EmployeesAPP.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPP.Validations
{
    public class LoginPageValidator :AbstractValidator<LoginPageViewModel>
    {

        public static string UserNameProperty =>nameof(LoginPageViewModel.UserName);
        public static string PasswordProperty => nameof(LoginPageViewModel.Password);
        public static string GlobalProperty => "Global";
        public LoginPageValidator()
        {
            
            RuleFor(x=>x.UserName).NotEmpty()
                .WithMessage("UserName is required")
                .MinimumLength(3).WithMessage("UserName must be at least 3 characters");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
        }

    }
}
