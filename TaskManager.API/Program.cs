
using TaskManager.Application;
using TaskManager.Infrastructure;

namespace TaskManager.API
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

            builder.Services.AddScoped<ITaskManagerRepository, TaskManagerRepository>();
            builder.Services.AddScoped<ITaskManagerService, TaskManagerService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();       // начало действия авторизации маршруты формируются относительно
            app.MapControllers();    // авторизации (внутри авторизации, "матрёшка")
            app.Run();
        }
    }
}
