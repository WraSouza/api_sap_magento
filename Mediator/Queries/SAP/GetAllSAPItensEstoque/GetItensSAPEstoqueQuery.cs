using API_SAP_Magento.Models.SAP;
using MediatR;

namespace API_SAP_Magento.Mediator.Queries.SAP.GetAllSAPItensEstoque
{
    public class GetItensSAPEstoqueQuery : IRequest<List<ItemSAPEstoque>>
    {
          public GetItensSAPEstoqueQuery(string itemCode)
        {
            ItemCode = itemCode;
        }
        public string ItemCode { get; set; }
        public int Quantidade { get; set; }
    }
}