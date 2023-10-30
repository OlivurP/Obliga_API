using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Obliga_API.Data;

namespace Obliga_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Obliga_APIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Obliga_APIContext") ?? throw new InvalidOperationException("Connection string 'Obliga_APIContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}