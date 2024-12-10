using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SaneamentoPet;
using SaneamentoPet.Client.Services;
using System.Net.Http;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
//var builder = WebApplication.CreateBuilder(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<PetService>();

// Configurar o HttpClient para se comunicar com a API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/api/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

builder.Services.AddScoped<PetService>();


