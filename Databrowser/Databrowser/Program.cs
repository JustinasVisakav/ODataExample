using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Databrowser.API.Databrowser.WebAppBuilder;
using Databrowser.Configuration.Constants;
using Databrowser.Configuration.Interfaces;
using Databrowser.Configuration;
using Databrowser.EntityContextKeeper.DatabaseContexts;
using Databrowser.API.ODataModel;

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddControllers().AddOData(opt =>
{
    opt.AddODataModel();
});

builder.Services.AddHealthChecks();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAssetsServices();
builder.Services.AddScoped<IConfig, Config>();

builder.Configuration.AddEnvironmentVariables();

var services = builder.Services.BuildServiceProvider();
var config = services.GetService<IConfig>();

var postgreConnectionString = Environment.GetEnvironmentVariable(ODataConfiguration.EnvConnectionString) ?? builder.Configuration.GetConnectionString(ODataConfiguration.EnvConnectionStringProperty);
builder.Services.AddDbContextFactory<PostgresContext>(options =>
{
    options.UseNpgsql(postgreConnectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

var app = builder.Build();
app.UseODataBatching();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseODataRouteDebug();
app.UseEndpoints(endpoints => endpoints.MapControllers());


app.Run();
