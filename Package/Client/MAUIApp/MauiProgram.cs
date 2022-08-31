
using Core.ViewModels;
using MAUIApp.OS;
using MAUIApp.ViewModels;
using System.Net.Http.Json;
using System.Text.Json;

namespace MAUIApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri("http.//demoapi.com") });

            //using var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            string json = "@{'WebAPIUrl': 'https://localhost:44328/'}";
            //var obj = JsonSerializer.Deserialize<SettingsStorage.Values>(json);
            //SettingsStorage.CurrentValues = obj;
            
            //using Sysne.Core.OS.DependencyService.Register<SettingsStorage, ISettingsStorage>();
            //using Sysne.Core.OS.DependencyService.Register<NavigationService, INavigationService>(DependencyService.ServiceLifetime.Singleton);
            builder.Services.AddScoped<MainPage>();
            builder.Services.AddScoped<LoginViewModel>();
            builder.Services.AddScoped<MainViewModel>();


            return builder.Build();
        }
    }
}