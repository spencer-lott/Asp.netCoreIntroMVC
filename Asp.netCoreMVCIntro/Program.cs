using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCIntro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Register DbContext
            var connectionString = builder.Configuration.GetConnectionString("TutorialDbConnection");
            builder.Services.AddDbContext<TutorialDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddScoped<ITutorialRepository, TutorialRepository>();
            builder.Services.AddScoped<IArticleRepository, ArticleRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
