using LojaVirtual.Infrastructure.Data.Common;
using LojaVirtual.Infrastructure.ExtensionMethods;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Loja_virtual_2._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddRepositories().AddServices();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddDbContext<RegisterContext>(options =>
                options.UseSqlServer("Data Source=DESKTOP-MMRT0DA;Initial Catalog=petcontrol;User ID=sa;Password=12345; TrustServerCertificate=true"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();
            app.UseCors(builder =>
               builder.WithOrigins("http://localhost:3000") // Especifique a origem permitida.
                      .AllowAnyHeader()
                      .AllowAnyMethod()
           );

            app.Run();
        }
    }
}