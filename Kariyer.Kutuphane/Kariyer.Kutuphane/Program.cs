using Kariyer.Kutuphane.Business;
using Kariyer.Kutuphane.Business.Abstracts;
using Kariyer.Kutuphane.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IKitapManager,KitapManager>();
builder.Services.AddSingleton<IUyeManager, UyeManager>();
builder.Services.AddSingleton<IYayinEviManager, YayinEviManager>();
builder.Services.AddSingleton<IYazarManager, YazarManager>();
builder.Services.AddSingleton<IKutuphaneIslemleriManager, KutuphaneIslemleriManager>();


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
