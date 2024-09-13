using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using MediatR;

namespace API_SAP_Magento.Mediator.Queries.SAP.GetAllSAPItensEstoque
{
    public class GetItensSAPEstoqueQueryHandler(IItemSAPRepository itemSAPRepository) : IRequestHandler<GetItensSAPEstoqueQuery, List<ItemSAPEstoque>>
    {    
        public async Task<List<ItemSAPEstoque>> Handle(GetItensSAPEstoqueQuery request, CancellationToken cancellationToken)
        {
           return await itemSAPRepository.GetEstoqueItemAsync(request.ItemCode);           
        }
    }
}