using MediatR;

namespace API_SAP_Magento.Mediator.Commands.SAPCommands.SAPBusinessPartner
{
    public class SAPBusinessPartnerCommand : IRequest<int>
    {
        public string? CardCode { get; set; }
        public string? CardName { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
    }
}