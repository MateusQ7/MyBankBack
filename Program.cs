var builder = WebApplication.CreateBuilder(args);

// Adicione serviços à contagem de injeção de dependência (equivalente a anotações de configuração no Spring)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurações do pipeline de requisição HTTP (equivalente ao `@SpringBootApplication` e configurações no Spring)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Configuração de segurança similar ao Spring Boot
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Roteamento padrão (equivalente a rotas no Spring MVC)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

