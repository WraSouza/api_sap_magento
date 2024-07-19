
using API_SAP_Magento.Mediator.Queries.GetAllSAPItems;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Services.SAPServices;
using MediatR;

namespace API_SAP_Magento.Endpoints.SAP
{
    public static class ItemsSAPEndpoint
    {        
        public static RouteGroupBuilder SAPItemsEndpoint(this RouteGroupBuilder app)
        {           
            
            app.MapGet("/busca-itens-sap", async (ItemSAPServices sapServices) =>
            {                 
                var allItens = await sapServices.GetAllItemsSAPAsync();               

                return Results.Ok(allItens);  

            }).Produces<ItemSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<ItemSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-Items-SAP")
              .WithOpenApi();

            app.MapGet("/busca-itens-sap-nome/{id}", (int id,ItemSAPServices sapServices) =>
            {
                var allItens = sapServices.GetItemByCodeAsync(id.ToString());

                return Results.Ok(allItens);  

            }).Produces<ItemSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<ItemSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-Items-SAP-Por-Nome")
              .WithOpenApi();

            return app;
        }
    }
}