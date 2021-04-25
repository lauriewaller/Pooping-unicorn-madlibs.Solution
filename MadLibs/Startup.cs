using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MadLibs
{
  public class Startup
  {
    public Startup(IWebHostEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }
    public IConfigurationRoot Configuration { get; }
    public void ConfigureServices(IServiceCollection services) // required built-in method used to set up an application's server.
    {
      services.AddMvc();
    }
    public void Configure(IApplicationBuilder app) //built-in and required in all ASP.NET Core apps. ASP.NET calls Configure() when the app launches. It's responsible for telling our app how to handle requests to the server.
    {
      app.UseDeveloperExceptionPage();
      
      app.UseRouting();

      app.UseEndpoints(routes =>
      {
        routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) => // not actually required to successfully launch our project. However, it will allow us to test that our Configure() method is working properly. 
      {
        await context.Response.WriteAsync("Hello World!");
      });
    }
  }
}