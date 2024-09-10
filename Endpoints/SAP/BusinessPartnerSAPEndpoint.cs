
using API_SAP_Magento.Mediator.Commands.SAPCommands.SAPBusinessPartner;
using API_SAP_Magento.Models.SAP;
using MediatR;

namespace API_SAP_Magento.Endpoints.SAP
{
    public static class BusinessPartnerSAPEndpoint
    {
        public static RouteGroupBuilder SAPBusinessPartnerEndpoint(this RouteGroupBuilder app)
        {
            app.MapGet("/businesspartner-sap", () =>
            {                   
                   return Results.Ok();  

            }).Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-BusinessPartner-SAP")
              .WithOpenApi();

            app.MapPost("/businesspartner-sap", () =>
            {                
                return Results.Ok();  

            }).Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Post-BusinessPartner-SAP")
              .WithOpenApi();

            app.MapPut("/businesspartner-sap", async (IMediator mediator) =>
            {                
                var createNewBPInSAP = new SAPBusinessPartnerCommand();

                var orders = await mediator.Send(createNewBPInSAP);

                return Results.Ok();  

            }).Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Put-BusinessPartner-SAP")
              .WithOpenApi();

            return app;
        }
    }
}