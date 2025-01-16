using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeesAPP.MVVM;
using EmployeesAPP.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPP.ViewModels
{
    public partial class LoginPageViewModel :ObservableObject
    {
        public LoginPageViewModel()
        {
            
        }

        [ObservableProperty]
        private string userName;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        public bool isBusy;

        [ObservableProperty]
        private ValidationResult _validationResult = new ValidationResult();


        [RelayCommand]
        public async Task Login()
        {
            try
            {
                //Authentication
                if (IsBusy)
                    return;

                var validator = new LoginPageValidator();

                //validate all the properties
                this.ValidationResult = await validator.ValidateAsync(this);


                //if there are errors ,do not continue
                if (!this.ValidationResult.IsValid)
                {
                    IEnumerable<string> errormessages = ValidationResult.Errors.Select(e => e.ErrorMessage);

                    //Retun all the errors in single string
                    var allerros = string.Join(Environment.NewLine, errormessages);

                     App.Current.MainPage.DisplayAlert("Error", allerros, "Ok");

                    return;
                }

                IsBusy = true;

                var login = new LoginVm
                {
                    UserName = UserName,
                    Password = Password
                };
                IsBusy = false;
            }
            catch(Exception ex)
            {

            }

        }

    }
}
