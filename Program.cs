var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// Add Application Insights
builder.Services.AddApplicationInsightsTelemetry("f218d444-516e-4001-9255-dbc4c009f75b;IngestionEndpoint=https://canadacentral-1.in.applicationinsights.azure.com/;LiveEndpoint=https://canadacentral.livediagnostics.monitor.azure.com/;ApplicationId=3250c4a6-9b9a-4653-b7dc-d53546419b3c");
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
