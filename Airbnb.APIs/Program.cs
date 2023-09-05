
using Airbnb.BL.Managers.Amenities;
using Airbnb.BL.Managers.Images;
using Airbnb.BL.Managers.properties;
using Airbnb.BL.Managers.Users;
using Airbnb.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Airbnb.APIs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var ConString = builder.Configuration.GetConnectionString("RentSystem");
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
            }).AddEntityFrameworkStores<RentContext>();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "default";
                options.DefaultChallengeScheme = "default";
            }).
                AddJwtBearer("default", options =>
                {
                    var secretKey = builder.Configuration.GetValue<string>("SecretKey");
                    var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKey);
                    var key = new SymmetricSecurityKey(secretKeyInBytes);
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        IssuerSigningKey = key
                    };
                });
            
            builder.Services.AddDbContext<RentContext>(options=>options.UseSqlServer(ConString));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IUserManager, UserManager>();
            builder.Services.AddScoped<IPropertyRepo, PropertyRepo>();
            builder.Services.AddScoped<IAmenityRepo, AmenityRepo>();
            builder.Services.AddScoped<IImageRepo, ImageRepo>();
            builder.Services.AddScoped<IReservationRepo, ReservationRepo>();
            builder.Services.AddScoped<IReviewRepo, ReviewRepo>();
            builder.Services.AddScoped<IRuleRepo, RuleRepo>();

            builder.Services.AddScoped<IPropertyManager, PropertyManager>();
            builder.Services.AddScoped<IAmenityManager, AmenityManager>();
            builder.Services.AddScoped<IImagesManager, ImagesManager>();
           // builder.Services.AddScoped<IReservationsManager, ReservationsManager>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}