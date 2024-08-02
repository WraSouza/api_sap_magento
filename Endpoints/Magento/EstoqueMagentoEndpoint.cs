
using API_SAP_Magento.Mediator.Commands.MagentoCommands.UpdateStockMagento;
using API_SAP_Magento.Models.SAP;
using MediatR;
using static API_SAP_Magento.Mediator.Commands.MagentoCommands.UpdateStockMagento.UpdateStockMagentoCommand;

namespace API_SAP_Magento.Endpoints.Magento
{
    public static class EstoqueMagentoEndpoint
    {
        public static RouteGroupBuilder MagentoEstoqueEndpoint(this RouteGroupBuilder app)
        {
            app.MapPut("/atualiza-estoque-magento", (IMediator mediator) =>
            {               

                var updateStockMagentoo = new UpdateStockMagentoCommand();

                var atualizaEstoque = mediator.Send(updateStockMagentoo);
                         
                return Results.Ok();  

            }).Produces<ItemSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<ItemSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Update-Estoque-Magento")
              .WithOpenApi();
              
            return app;
        }
    }
}