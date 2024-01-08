using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;
using Hejner_Balint_DartStat.Viewmodels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Hejner_Balint_DartStat.Views;

namespace Hejner_Balint_DartStat
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureMauiHandlers(handlers => { })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<GameMode>();
            builder.Services.AddSingleton<GameModeViewModel>();
            builder.Services.AddSingleton<Toplist>();
            builder.Services.AddSingleton<TopListViewModel>();
            builder.Services.AddSingleton<Statistics>();
            builder.Services.AddSingleton<GameMenuViewModel>();
            builder.Services.AddSingleton<GameMenu>();


            return builder.Build();
        }
    }
}