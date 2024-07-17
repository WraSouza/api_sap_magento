
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Services.MagentoServices.MagentoImplementations;

namespace API_SAP_Magento.Endpoints.Magento
{
    public static class EstoqueMagentoEndpoint
    {
        public static RouteGroupBuilder MagentoEstoqueEndpoint(this RouteGroupBuilder app)
        {
            app.MapPut("/atualiza-estoque-magento", (ItemsMagentoServices magentoServices) =>
            {       
                magentoServices.UpdateEstoqueMagento();  
                         
                return Results.Ok();  

            }).Produces<ItemSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<ItemSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Update-Items-Magento")
              .WithOpenApi();
              
            return app;
        }
    }
}