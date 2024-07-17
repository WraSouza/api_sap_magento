

using API_SAP_Magento.Services.MagentoServices.MagentoImplementations;
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Endpoints.Magento
{
    public static class ItemsMagentoEndpoint
    {
        public static RouteGroupBuilder MagentoItemsEndpoint(this RouteGroupBuilder app)
        {
            app.MapGet("/busca-itens-magento", (ItemsMagentoServices magentoServices) =>
            {          
                var allItens = magentoServices.GetAllItems();

                return Results.Ok(allItens);  

            }).Produces<Root>(statusCode: StatusCodes.Status200OK)
              .Produces<Root>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-Items-Magento")
              .WithOpenApi();

            app.MapPut("/atualiza-itens-magento", (ItemsMagentoServices magentoServices) =>
            {          
                magentoServices.UpdateEstoqueMagento();

                return Results.Ok();  

            }).Produces<Root>(statusCode: StatusCodes.Status200OK)
              .Produces<Root>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Update-Items-Magento")
              .WithOpenApi();
            

            return app;
        }
    }
}