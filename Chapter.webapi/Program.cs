using Chapter.WebApi.Contexts;
using Chapter.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ChapterContext, ChapterContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<LivroRepository, LivroRepository>();

var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>{
    endpoints.MapControllers();

});

app.Run();