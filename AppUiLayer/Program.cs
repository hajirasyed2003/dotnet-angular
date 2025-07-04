var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient("CaseStudyAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7234/");
});

builder.Services.AddSession();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=UserInfo}/{action=LoginPage}/{id?}");

app.Run();