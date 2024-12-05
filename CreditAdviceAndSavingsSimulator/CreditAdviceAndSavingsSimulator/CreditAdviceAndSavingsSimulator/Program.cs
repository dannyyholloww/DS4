using CreditAdviceAndSavingsSimulator.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<CreditAdviceService>();
builder.Services.AddScoped<SavingsSimulationService>();



// Agregar servicios de autenticación/autorización (necesario si usas app.UseAuthorization()).
builder.Services.AddAuthorization();

var app = builder.Build();

// Configuración del pipeline HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Solo llama a app.UseAuthorization si usas autorizaciones en tu aplicación.
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
