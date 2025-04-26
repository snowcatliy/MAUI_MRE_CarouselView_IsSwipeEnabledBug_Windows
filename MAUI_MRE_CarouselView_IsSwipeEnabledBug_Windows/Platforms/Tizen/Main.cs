using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MAUI_MRE_CarouselView_IsSwipeEnabledBug_Windows
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
