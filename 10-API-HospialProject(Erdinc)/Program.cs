using _10_API_HospialProject_Erdinc_.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _10_API_HospialProject_Erdinc_
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

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            //II.Y�ntem
            //builder.Services.AddCors(options => options.AddPolicy("AllowOrigin", opt => opt.AllowAnyOrigin()));

            //III.Y�ntem
            builder.Services.AddCors(options => options.AddPolicy("myClient", opt => opt.WithOrigins("https://localhost:7014", "https://localhost:7094")
                .SetIsOriginAllowedToAllowWildcardSubdomains().AllowAnyHeader().AllowAnyMethod()));
                

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //I.Y�ntem
            //app.UseCors(options =>
            //{
            //    options.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
            //});

            //II.Y�ntem
            //app.UseCors(options => options.AllowAnyOrigin());

            //III.Y�ntem
            app.UseCors("myClient");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}