
using Microsoft.Extensions.Options;
using Vending_machine.Business.Implementations.MapperProfiles;
using Vending_machine.DI;
using Vending_machine.Domain.Settings;

namespace Vending_machine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddRepositories();
            builder.Services.AddAutoMapper(typeof(DefaultProfile));
            builder.Services.AddServices();

            builder.Services.Configure<DbSettings>(builder.Configuration.GetSection("DbSettings"));
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}