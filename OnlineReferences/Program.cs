

using OnlineReferences.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IDbContext, FakeDBContext>();
builder.Services.AddScoped<ReferenceRequestInfo>(sp=>SessionReferenceRequestInfo.GetReferenceRequest(sp));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePages();
}
else
{
    app.UseExceptionHandler("/Error");
}
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();