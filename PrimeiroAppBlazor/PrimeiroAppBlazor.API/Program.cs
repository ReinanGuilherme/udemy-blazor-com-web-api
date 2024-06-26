var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add config cors
builder.Services.AddCors(option =>
{
    option.AddPolicy("CorsPolicy", builder =>
    {
        builder.
        AllowAnyOrigin().
        AllowAnyMethod().
        AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// add config cors
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
