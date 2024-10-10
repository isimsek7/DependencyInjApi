using DependencyInjApi.Interfaces;
using DependencyInjApi.Services;
using DependencyInjApi.Entitites;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<ITeacher, Teacher>();
builder.Services.AddSingleton<IClassroomService, ClassroomService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dependency Inj API V1");
    c.RoutePrefix = string.Empty;
});

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();
