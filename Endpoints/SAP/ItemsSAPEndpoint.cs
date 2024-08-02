using API_SAP_Magento.Models.SAP;
using MediatR;

namespace API_SAP_Magento.Endpoints.SAP
{
    public static class ItemsSAPEndpoint
    {          
        public static RouteGroupBuilder SAPItemsEndpoint(this RouteGroupBuilder app)
        {           
            
            app.MapGet("/busca-itens-sap", async (IMediator mediator) =>
            {                            

                return Results.Ok();  

            }).Produces<ItemSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<ItemSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-Items-SAP")
              .WithOpenApi();

            app.MapGet("/busca-itens-sap-nome/{id}", (int id,IMediator mediator) =>
            {
                

                return Results.Ok();  

            }).Produces<ItemSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<ItemSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-Items-SAP-Por-Nome")
              .WithOpenApi();

            return app;
        }
    }
}