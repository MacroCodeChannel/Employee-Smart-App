using EmployeesAPP.ViewModels;
using EmployeesAPP.Views;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;

namespace EmployeesAPP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .ConfigureSyncfusionToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //Views
            builder.Services.AddSingleton<LoginPage>();



            //View Models
            builder.Services.AddSingleton<LoginPageViewModel>();


            return builder.Build();
        }
    }
}
