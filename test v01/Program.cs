using Microsoft.AspNetCore.Authentication.Cookies;
using Notify_iGlem.Services;
using SeuProjeto.Hubs;
using test_v01.Services;

var builder = WebApplication.CreateBuilder(args);


// Adicionar serviços ao contêiner
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
builder.Services.AddScoped<INotificacaoObservable, NotificacaoObservable>();


// Adicionando sessão
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(30);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
});

// Configurar autenticação com cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = "/Account/Login"; // Caminho da página de login
		options.AccessDeniedPath = "/Account/AccessDenied"; // Caminho para quando o acesso é negado
	});

builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Adicionar middleware de autenticação e autorização
app.UseAuthentication();
app.UseAuthorization();

app.UseSession();
app.UseStatusCodePagesWithReExecute("/Home/AccessDenied");
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
