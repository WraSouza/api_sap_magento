using MediatR;
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Endpoints.Magento
{
    public static class ItemsMagentoEndpoint
    {
        public static RouteGroupBuilder MagentoItemsEndpoint(this RouteGroupBuilder app)
        {
            app.MapGet("/busca-itens-magento", (IMediator mediator) =>
            {
                
                return Results.Ok();  

            }).Produces<Root>(statusCode: StatusCodes.Status200OK)
              .Produces<Root>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-Items-Magento")
              .WithOpenApi();         
            

            return app;
        }
    }
}