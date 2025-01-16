using EmployeesAPP.ViewModels;
namespace EmployeesAPP.Views;

public partial class LoginPage : ContentPage
{

	private LoginPageViewModel vm;
    public LoginPage()
	{
		InitializeComponent();
        BindingContext = vm = new LoginPageViewModel();
    }
}