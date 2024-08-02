using System.Reflection;
using API_SAP_Magento.Endpoints.Magento;
using API_SAP_Magento.Endpoints.SAP;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IItemSAPRepository, ItemSAPRepository>();
builder.Services.AddScoped<IItemMagentoRepository, ItemMagentoRepository>();
builder.Services.Configure<LoginSAP>(builder.Configuration.GetSection("SAPLogin"));

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
});

var app = builder.Build();

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
.MagentoEstoqueEndpoint()
.WithTags("Magento - Estoque");

app.MapGroup("")
.MagentoItemsEndpoint()
.WithTags("Magento - Itens");


app.UseHttpsRedirection();


app.Run();


