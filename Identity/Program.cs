
using DataAccess.EF;
using DataAccess.EF.Repositories;
using Microsoft.AspNetCore.Identity;
using Models.Core;
using Models.Core.Models;
using Models.Core.Repositories;

namespace Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConntection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
                }
            );
            builder.Services.AddScoped(typeof(IUnitOFWork), typeof(UnitOfWork));
            
            //builder.Services.AddTransient<IUnitOFWork, UnitOfWork>();
            builder.Services
                .AddIdentityApiEndpoints<AppUser>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            

            //builder.Services
            //    .AddIdentityCore<User>()
            //    .AddEntityFrameworkStores<AppDbContext>()
            //    .AddApiEndpoints();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            //app.Map("/logout", async(SignInManager < AppUser > signInManager) =>
            //{
            //    await signInManager.SignOutAsync().ConfigureAwait(false);
            //}).RequireAuthorization();
            app.MapCustomIdentityApi<AppUser>();
            //app.MapIdentityApi<AppUser>();

            app.MapControllers();

            app.Run();
        }
    }
}
