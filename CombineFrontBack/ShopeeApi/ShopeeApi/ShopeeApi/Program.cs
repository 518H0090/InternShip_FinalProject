using LoggerService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NLog;
using ShopeeApi.Datas;
using ShopeeApi.Repository;
using ShopeeApi.SeedData;
using ShopeeApi.Service;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//Add Nlog References
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.AddScoped<ILoggerManager, LoggerManager>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string devCorsPolicy = builder.Configuration.GetSection("CorsPolicy:PolicyString").Value;

builder.Services.AddAutoMapper(typeof(Program).Assembly);

string localDotnet = builder.Configuration.GetSection("CorsPolicy:DotNetLocalHost").Value;
string localFrontend = builder.Configuration.GetSection("CorsPolicy:FrontendLocalHost").Value;

builder.Services.AddCors(options =>
{
    options.AddPolicy(devCorsPolicy,
            builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }
        );
});

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(
        options =>
        {
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.Unicode.GetBytes(
                        builder.Configuration.GetSection("JwtSettings:SecretKey").Value
                    )),
                ValidateIssuer = false,
                ValidateAudience = false,
            };
        }
    );

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<ICategoryFoodRepository, CategoryFoodRepository>();
builder.Services.AddScoped<IRecordRepository, RecordRepository>();
builder.Services.AddScoped<IBillRepository, BillRepository>();

builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddScoped<ICategoryFoodService, CategoryFoodService>();
builder.Services.AddScoped<IRecordService, RecordService>();
builder.Services.AddScoped<IBillService, BillService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(devCorsPolicy);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MigrateDatabase();

app.Run();