using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FilmLibrary.Data.Models;   // пространство имен моделей
using Microsoft.EntityFrameworkCore; // пространство имен EntityFramework
using FilmLibrary.Data.Interfaces;
using FilmLibrary.Data.Repository;
using FilmLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;




namespace FilmLibrary
{
    public class Startup
    {
       
        private IConfigurationRoot _confstring;
        public Startup(IWebHostEnvironment hosting)
        {
            _confstring = new ConfigurationBuilder().SetBasePath(hosting.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<FilmContext>(options => options.UseLazyLoadingProxies().UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();

            services.AddTransient<IActor, ActorRepository>();
            services.AddTransient<IFilms, FilmRepository>();
            services.AddTransient<IGenre, GenreRepository>();
/*            services.AddTransient<IUser, UserRepository>();*/

            services.AddIdentity<User, IdentityRole>(opts => {
                opts.Password.RequiredLength = 5;   // минимальная длина
                opts.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
                opts.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
                opts.Password.RequireUppercase = false; // требуются ли символы в верхнем регистре
                opts.Password.RequireDigit = false; // требуются ли цифры
            }).AddEntityFrameworkStores<FilmContext>();

            services.AddControllersWithViews();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseStatusCodePages();

            app.UseRouting();

            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Film}/{action=Index}/{id?}");
            });
            using (var scope = app.ApplicationServices.CreateScope())
            {
                FilmContext content = scope.ServiceProvider.GetRequiredService<FilmContext>();
                DBObjects.Initial(content);
            }    
        } 
    }
}