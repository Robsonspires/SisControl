using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SisControl.Client;
using SisControl.Client.Services;
using SisControl.Client.Services.ServicoPessoas;
using SisControl.Client.Services.ServicoLancamentos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IServicoPessoas, ServicoPessoas>();
builder.Services.AddScoped<IServicoLancamentos, ServicoLancamentos>();

await builder.Build().RunAsync();
