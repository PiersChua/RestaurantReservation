using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RestaurantReservation.Client;
using RestaurantReservation.Client.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using CurrieTechnologies.Razor.SweetAlert2;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("RestaurantReservation.ServerAPI", (sp,
client) => {
    client.BaseAddress = new
    Uri(builder.HostEnvironment.BaseAddress);
    client.EnableIntercept(sp);
})
.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("RestaurantReservation.ServerAPI"));

builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<HttpInterceptorService>();
builder.Services.AddApiAuthorization();
builder.Services.AddSweetAlert2();
builder.Services.AddSyncfusionBlazor(); //for charts
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF1cXmhKYVJpR2Nbe05xdF9GZVZQR2Y/P1ZhSXxXdkRgWH1ccHFUQmJVU00=");



await builder.Build().RunAsync();
