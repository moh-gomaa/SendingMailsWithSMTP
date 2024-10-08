using SendingMailsWithSMTP.Models;
using SendingMailsWithSMTP.Services;

var builder = WebApplication.CreateBuilder(args);
var confg = builder.Configuration;

builder.Services.Configure<MailSettings>(confg.GetSection("MailSettings"));

builder.Services.AddTransient<IMailingService, MailingService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
