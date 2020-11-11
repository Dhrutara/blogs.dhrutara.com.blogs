using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace blogs.dhrutara.com.aspnetreactfileupload
{
    public class Startup {
		public Startup(IConfiguration configuration) {
			this.Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			_ = services.AddControllersWithViews();
			services.AddSpaStaticFiles(configuration => configuration.RootPath = "ClientApp/build");
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if(env.IsDevelopment()) {
				_ = app.UseDeveloperExceptionPage();
			} else {
				_ = app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				_ = app.UseHsts();
			}

			_ = app.UseHttpsRedirection();
			_ = app.UseStaticFiles();
			app.UseSpaStaticFiles();

			_ = app.UseRouting();

			_ = app.UseEndpoints(endpoints => _ = endpoints.MapControllerRoute(
					name: "default",
					pattern: "api/{controller}/{action=Index}/{id?}"));

			app.UseSpa(spa => {
				spa.Options.SourcePath = "ClientApp";

				if(env.IsDevelopment()) {
					spa.UseReactDevelopmentServer(npmScript: "start");
				}
			});
		}
	}
}
