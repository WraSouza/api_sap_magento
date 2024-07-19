

using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using MediatR;

namespace API_SAP_Magento.Mediator.Queries.GetItemsSAPEstoque
{
    public class GetItemsSAPEstoqueQueryHandler : IRequestHandler<GetItemsSAPEstoqueQuery, List<ItemSAPEstoque>>
    {
        private readonly IItemSAPRepository _itemSAPRepository;

        public GetItemsSAPEstoqueQueryHandler(IItemSAPRepository itemSAPRepository)
        {
            _itemSAPRepository = itemSAPRepository;
        }
        public async Task<List<ItemSAPEstoque>> Handle(GetItemsSAPEstoqueQuery request, CancellationToken cancellationToken)
        {
            var itemsSAP = await _itemSAPRepository.GetEstoqueItemAsync(request.ItemCode);

            return itemsSAP;
        }
    }
}