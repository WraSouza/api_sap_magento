using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using MediatR;

namespace API_SAP_Magento.Mediator.Queries.SAP.GetAllSAPItensEstoque
{
    public class GetItensSAPEstoqueQueryHandler : IRequestHandler<GetItensSAPEstoqueQuery, List<ItemSAPEstoque>>
    {
       private readonly IItemSAPRepository _itemSAPRepository;

        public GetItensSAPEstoqueQueryHandler(IItemSAPRepository itemSAPRepository)
        {
            _itemSAPRepository = itemSAPRepository;
        }
        public async Task<List<ItemSAPEstoque>> Handle(GetItensSAPEstoqueQuery request, CancellationToken cancellationToken)
        {
           return await _itemSAPRepository.GetEstoqueItemAsync(request.ItemCode);           
        }
    }
}