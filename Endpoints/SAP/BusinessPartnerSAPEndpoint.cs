
using API_SAP_Magento.Models.SAP;

namespace API_SAP_Magento.Endpoints.SAP
{
    public static class BusinessPartnerSAPEndpoint
    {
        public static RouteGroupBuilder SAPBusinessPartnerEndpoint(this RouteGroupBuilder app)
        {
            app.MapGet("/busca-parceiro-sap", () =>
            {         
                 
                   return Results.Ok();  

            }).Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status200OK)
              .Produces<BusinessPartnerSAP>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-BusinessPartner-SAP")
              .WithOpenApi();

            return app;
        }
    }
}