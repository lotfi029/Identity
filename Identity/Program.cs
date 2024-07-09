
using DataAccess.EF;
using Microsoft.AspNetCore.Identity;
using Models.Core.Models;

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

            builder.Services.AddDbContext<AppDbContext>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConntection"))
            );
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
            app.Map("/logout", async(SignInManager < AppUser > signInManager) =>
            {
                await signInManager.SignOutAsync().ConfigureAwait(false);
            }).RequireAuthorization();
            app.MapCustomIdentityApi<AppUser>();


            app.MapControllers();

            app.Run();
        }
    }
}
