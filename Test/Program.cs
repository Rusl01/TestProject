using Test.Service;
using Test.Service.ClassService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IPalindrom, PolindromService>();
builder.Services.AddTransient<ISortArray<int>, SortArrayService<int>>();
builder.Services.AddTransient<ISumArray, SumArrayService>();

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

//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "SumOfOdd",
//        pattern: "{controller=Palindrom}/{action=Index}/{id?}");
//    endpoints.MapControllerRoute(
//        name: "Sorting",
//        pattern: "{controller=Sort}/{action=Index}/{id?}");
//    endpoints.MapControllerRoute(
//        name: "DisplayResult",
//        pattern: "{controller=SumArray}/{action=Index}/{id?}");
//});

app.UseAuthorization();

app.MapControllers();

app.Run();
