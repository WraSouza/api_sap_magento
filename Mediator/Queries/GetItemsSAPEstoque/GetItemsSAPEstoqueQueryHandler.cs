

using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using MediatR;

namespace API_SAP_Magento.Mediator.Queries.GetItemsSAPEstoque
{
    public class GetItemsSAPEstoqueQueryHandler(IItemSAPRepository itemSAPRepository) : IRequestHandler<GetItemsSAPEstoqueQuery, List<ItemSAPEstoque>>
    {
        public async Task<List<ItemSAPEstoque>> Handle(GetItemsSAPEstoqueQuery request, CancellationToken cancellationToken)
        {
            var itemsSAP = await itemSAPRepository.GetEstoqueItemAsync(request.ItemCode);

            return itemsSAP;
        }
    }
}