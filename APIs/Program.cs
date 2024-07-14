using APIs.Model;
using APIs.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace APIs
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

            builder.Services.AddDbContext<UserContext>( 
                //option =>{
               // option.UseSqlServer("Data Source=DESKTOP-FT8D139//MSSQLSERVER2;Initial Catalog=test2;Integrated Security=True");
                //} 
        );




            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder
                        .WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });



            builder.Services.AddScoped<IUserRepo, UserRepository>();

            builder.Services.AddScoped<IGovernateAndCityRepo, GovernateAndCityRepo>();

            builder.Services.AddScoped<IspRepo, spRepo>();
           builder.Services.AddSingleton<JWToptions>();



            var jwtoptions = builder.Configuration.GetSection("JWT").Get<JWToptions>();

            builder.Services.AddAuthentication(options =>
            {


                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                //options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;


            })
             .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
             {
                 options.SaveToken = true;
                 options.TokenValidationParameters = new TokenValidationParameters()
                 {

                     ValidateIssuer = true,
                     ValidIssuer = jwtoptions.issuer,

                     //builder.Configuration["JWT."],
                     ValidateAudience = true,
                     ValidAudience = jwtoptions.audience,
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtoptions.signinkey)),



                 };
             });











            builder.Services.AddAuthorization();
            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowSpecificOrigin");
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}