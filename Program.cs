using System.Reflection;
using API_SAP_Magento.Endpoints.Magento;
using API_SAP_Magento.Endpoints.SAP;
using API_SAP_Magento.Helpers.LoginHelper;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryBusinessPartnerMagento;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento;
using API_SAP_Magento.Repository.SAPRepositories.BusinessPartnerSAPRepository;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using Serilog;
using Serilog.Sinks.Grafana.Loki;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IItemSAPRepository, ItemSAPRepository>(); 
builder.Services.AddScoped<ISAPBPRepository, SAPBPRepository>();
builder.Services.AddScoped<IItemMagentoRepository, ItemMagentoRepository>();
builder.Services.AddScoped<IBusinessPartnerMagentoRepository, BusinessPartnerMagentoRepository>();
builder.Services.AddSingleton<Login>();
builder.Services.Configure<LoginSAP>(builder.Configuration.GetSection("SAPLogin"));

builder.Logging.ClearProviders();

var logger = new LoggerConfiguration()
.Enrich.WithEnvironmentName()
.Enrich.WithMachineName()
.Enrich.WithMemoryUsage()
.WriteTo.Console()
.WriteTo.GrafanaLoki("http://192.168.3.148:3100",
new List<LokiLabel>()
{
  new()
  {
    Key = "Service",
    Value = System.IO.Path.GetFileName(Assembly.GetExecutingAssembly().Location).Replace(".dll","")
  }
})
.WriteTo.Seq("http://192.168.3.148:5341/")
.CreateLogger();



builder.Logging.AddSerilog(logger);

builder.Services.AddSwaggerGen(opt => 
{
    opt.SwaggerDoc("v1", new () { Title = "API SAP Magento", Version = "v1" });
});

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
});

var app = builder.Build();



// app.UseSwaggerUI(config =>
// {
//     config.ConfigObject.AdditionalItems["syntaxHighlight"] = new Dictionary<string, object>
//     {
//         ["activated"] = false
//     };
// });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGroup("")
.SAPItemsEndpoint()
.WithTags("SAP - Itens");

app.MapGroup("")
.SAPBusinessPartnerEndpoint()
.WithTags("SAP - BusinessPartner");

app.MapGroup("")
.MagentoOrdersEndpoint()
.WithTags("Magento - Orders");

app.MapGroup("")
.MagentoEstoqueEndpoint()
.WithTags("Magento - Estoque");

app.MapGroup("")
.MagentoItemsEndpoint()
.WithTags("Magento - Itens");


app.UseHttpsRedirection();

app.Run();


