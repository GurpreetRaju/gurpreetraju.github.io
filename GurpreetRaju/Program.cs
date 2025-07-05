using GurpreetRaju;
using GurpreetRaju.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShineBlazor.Components.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

HttpClient httpClient = new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
};
builder.Configuration.AddJsonStream(await httpClient.GetStreamAsync("appsettings.json"));

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ToastService>();
builder.Services.AddScoped<CaptchaService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();