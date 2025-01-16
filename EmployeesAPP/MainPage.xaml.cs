using EmployeesAPP.Helpers;
using EmployeesAPP.Views;

namespace EmployeesAPP
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            if (Settings.IsLoggedIn)
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                Navigation.PushAsync(new LoginPage());
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
