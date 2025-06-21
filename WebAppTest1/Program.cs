using Microsoft.AspNetCore;
using Microsoft.Extensions.Configuration;
using WebAppTest1;
using Microsoft.EntityFrameworkCore;
using WebAppRepository;
using WebAppTest1Applayer.Interface;
using WebAppTest1Applayer.AppServices;
using WebAppAppServiceLayer.Interface;
using WebAppAppServiceLayer.Services;
using WebAppRepository.Interface;
using WebAppRepository.Repository;
using System.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using WebAppDomain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc();

//IConfigurationRoot configurationRoot = new ConfigurationBuilder()
//    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//    .Build();

builder.Services.AddScoped<IPaymentApp, PaymentApplication>();
builder.Services.AddSingleton<IPaymentApp, PaymentApplication>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddSingleton<IPaymentService, PaymentService>();

builder.Services.AddScoped<IUserApp,UserApplication>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddSingleton<IPaymentRepository, PaymentRepository>();

builder.Services.AddSingleton<ConfigClass>();

//builder.Services.AddDbContext<PaymentDBContext>(options => 
//options.UseSqlServer("server=.;Database=PTestingDB;Trusted_Connection=True;MultipleActiveResultSets=True;"));

builder.Services.AddResponseCaching();

builder.Services.AddApiVersioning(
    Options =>
    {
        Options.AssumeDefaultVersionWhenUnspecified = true;
        Options.DefaultApiVersion = new ApiVersion(1, 0);
        Options.ReportApiVersions = true;

        Options.ApiVersionReader = new HeaderApiVersionReader("X-API-Version");
    });

var app = builder.Build();

//IConfiguration configuration = app.Configuration;


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseResponseCaching();
   
}

app.UseCors(options =>
options.WithOrigins("http://localhost:4200")
.AllowAnyMethod()
.AllowAnyHeader()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
