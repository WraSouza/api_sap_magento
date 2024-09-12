using API_SAP_Magento.Models.SAP;
using MediatR;

namespace API_SAP_Magento.Mediator.Queries.GetItemsSAPEstoque
{
    public class GetItemsSAPEstoqueQuery : IRequest<List<ItemSAPEstoque>>
    {
        public GetItemsSAPEstoqueQuery(string itemCode)
        {
            ItemCode = itemCode;
        }
        public string ItemCode { get; set; }
        public int Quantidade { get; set; }
    }
}