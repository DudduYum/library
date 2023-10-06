using AutoMapper;
using Library;
using Microsoft.EntityFrameworkCore;
using NSwag;
using Services;
using Services.dto;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();

// AUTO MAPPERE
var config = new MapperConfiguration(
    cfg =>
    {
        cfg.AddProfile(new AutoMapperProfile());
        
        
    });
var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);
// END MAPPER
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services
    //.AddEntityFrameworkSqlServer()
    .AddDbContext<LibraryContext>(
        options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DatabaseConnection"),
                b => b.MigrationsAssembly("Portal"))
    );

builder.Services.AddSwaggerGen();

builder.Services.AddOpenApiDocument(
    options =>
    {
        options.PostProcess = document =>
        {
            document.Info = new OpenApiInfo
            {
                Version = "v1",
                Title = "Libreria",
                Description = "Il progetto per gestire la libreria domestica",
            };
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseSwagger(options => { options.SerializeAsV2 = true; });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
    app.UseOpenApi();
    app.UseSwaggerUi3();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();