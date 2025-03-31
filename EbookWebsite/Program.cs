using EbookWebsite.Components;

namespace EbookWebsite
{
    // https://www.udemy.com/course/bootstrap-from-scratch/learn/lecture/38476346#overview

    // Prepare starter settings:
    // assuming webcompiler was already added to the VS extensions WebCompiler 2022+ Jason Moore
    // optionally get the dark mode javascript in

    // bootstrap -> delete bootstrap directory
    // add bootstrap -> client side library
    // - add script tag for bundle min js below blazor js
    // - add bootstrap directory to gitignore

    // fontawesome -> copy into wwwroot including scss files
    // - copy webfonts directory one up into wwwroot
    // - add fontawesome directory to gitignore

    // add Styles directory and create two scss files
    // import relevant scss files from source to each
    // @import '../wwwroot/bootstrap/scss/bootstrap.scss';
    // @import '../wwwroot/fontawesome-free-6.7.2-web/scss/fontawesome.scss';
    // @import '../wwwroot/fontawesome-free-6.7.2-web/scss/brands.scss';
    // @import '../wwwroot/fontawesome-free-6.7.2-web/scss/solid.scss';

    // add them both to the webcompiler
    // change the compilerconfig.json to use proper output paths
    // change the compilerdefaults
    // allow webcompiler to catch up

    // - adjust stylesheet in app.razor to use both min bundles

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
