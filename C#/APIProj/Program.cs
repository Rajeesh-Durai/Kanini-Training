using APIProj.Authentication;
using APIProj.Models;
using APIProj.Repositories.Services.Booking_Detail_Services;
using APIProj.Repositories.Services.Movies_Services;
using APIProj.Repositories.Services.Seat_Services;
using APIProj.Repositories.Services.ShowTime_Services;
using APIProj.Repositories.Services.Theatre_Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProjectContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "SQLConnection")));
builder.Services.AddScoped<IBookingDetails, BookingDetails>();
builder.Services.AddScoped<IMoviesServices, MoviesServices>();
builder.Services.AddScoped<ISeatServices, SeatServices>();
builder.Services.AddScoped<IShowTimeServices, ShowTimeServices>();
builder.Services.AddScoped<ITheatreServices, TheatreServices>();
builder.Services.AddDbContext<AuthDBContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "JWT")));

ConfigurationManager configuration = builder.Configuration;

// For Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AuthDBContext>()
    .AddDefaultTokenProviders();

// Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
    };
});



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
