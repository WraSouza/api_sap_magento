
using API_SAP_Magento.DTOs.MagentoDTOs;
using API_SAP_Magento.Mediator.Queries.Magento.GetMagentoOrder;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API_SAP_Magento.Endpoints.Magento
{
    public static class OrdersMagentoEndpoints
    {
        public static RouteGroupBuilder MagentoOrdersEndpoint(this RouteGroupBuilder app)
        {
            app.MapGet("/orders-magento", async (IMediator mediator) =>
            {       
                try
                {
                     var getOrder = new GetMagentoOrderQuery();

                     var orders = await mediator.Send(getOrder);  

                     return Results.Ok(orders);  
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }    
               
                return Results.NoContent();
            }).Produces<MagentoOrdersDTO>(statusCode: StatusCodes.Status200OK)
              .Produces<MagentoOrdersDTO>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-Orders-Magento")
              .WithOpenApi();         
            

            return app;
        }
    }
}