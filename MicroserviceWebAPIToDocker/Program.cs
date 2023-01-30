/*
                                                   Задача

● Завантажте приклад і запустіть його контейнером, щоб зрозуміти, як це працює. Пройти інструкцію з Readme.

● Створіть своє рішення із болванкою під catalog MSS:
    ○ для навчання давайте, зробимо 1 метод GET, який поверне нам список товарів вашого каталогу
        (ніякий БД не потрібно, дані брати з масиву в контролері)
● Додайте nginx новим розділом у файл docker-compose

 */

namespace MicroserviceWebAPIToDocker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}