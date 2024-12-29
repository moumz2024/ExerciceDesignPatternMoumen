using ExerciceDesignPattern.Adapters;
using ExerciceDesignPattern.Factory;
using ExerciceDesignPattern.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register Notification Service DI
builder.Services.AddTransient<INotificationService, EmailNotificationAdapter>();

// Register a factory for DI
builder.Services.AddTransient<NotificationFactory>();

// Register SMS adapter DI
builder.Services.AddTransient<SMSNotificationAdapter>();

builder.Services.AddScoped<IEmailNotificationService, EmailNotificationService>();
builder.Services.AddScoped<ISmsNotificationService, SmsNotificationService>();

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
