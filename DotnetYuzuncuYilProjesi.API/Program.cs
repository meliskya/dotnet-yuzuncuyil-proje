using DotnetYuzuncuYilProjesi.API.ExceptionHandler;
using DotnetYuzuncuYilProjesi.Core.Repositories;
using DotnetYuzuncuYilProjesi.Core.Services;
using DotnetYuzuncuYilProjesi.Core.UnitOfWorks;
using DotnetYuzuncuYilProjesi.Repository;
using DotnetYuzuncuYilProjesi.Repository.Repositories;
using DotnetYuzuncuYilProjesi.Repository.UnitOfWorks;
using DotnetYuzuncuYilProjesi.Service;
using DotnetYuzuncuYilProjesi.Service.Mapping;
using DotnetYuzuncuYilProjesi.Service.Services;
using DotnetYuzuncuYilProjesi.Service.Validations;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IPlayListService, PlayListService>();
builder.Services.AddScoped<ISongService, SongService>();
builder.Services.AddScoped<IMusicDetailService, MusicDetailService>();
builder.Services.AddControllers().AddFluentValidation(x =>
      {
          x.RegisterValidatorsFromAssemblyContaining<PlayListDtoValidator>();
          x.RegisterValidatorsFromAssemblyContaining<SongDtoValidator>();
          x.RegisterValidatorsFromAssemblyContaining<MusicDetailDtoValidator>();
      });

//AddDbContext ��lemler

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
 });

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
