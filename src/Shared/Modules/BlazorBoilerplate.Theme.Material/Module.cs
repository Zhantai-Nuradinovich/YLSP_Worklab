using BlazorBoilerplate.Shared.Interfaces;
using BlazorBoilerplate.Theme.Material.TagHelpers;
using MatBlazor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Radzen;

namespace BlazorBoilerplate.Theme.Material
{
    public class Module : IModule, ITheme
    {
        public Module()
        {
            RootComponentMapping = new RootComponentMapping(typeof(App), "app");
        }

        public RootComponentMapping RootComponentMapping { get; }

        public string Name => "MatBlazor default theme";

        public string Description => "MatBlazor default theme";

        public int Order => 1;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITagHelperComponent, ThemeTagHelperComponent>();
            services.AddTransient<ITagHelperComponent, AppTagHelperComponent>();

            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });

            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();
            services.AddScoped<TooltipService>();
            services.AddScoped<ContextMenuService>();
        }

        public void ConfigureWebAssemblyServices(IServiceCollection services)
        {
            services.AddLoadingBar();
            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });

            var sp = services.BuildServiceProvider();
            
            sp.GetRequiredService<HttpClient>().EnableIntercept(sp);

            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();
            services.AddScoped<TooltipService>();
            services.AddScoped<ContextMenuService>();
        }

        public void ConfigureWebAssemblyHost(WebAssemblyHost webAssemblyHost)
        {
            webAssemblyHost.UseLoadingBar();
        }
    }
}
