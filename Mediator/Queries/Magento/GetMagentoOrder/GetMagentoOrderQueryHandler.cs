using API_SAP_Magento.Repository.MagentoRepositories.RepositoryBusinessPartnerMagento;
using MediatR;
using static API_SAP_Magento.DTOs.MagentoDTOs.MagentoOrdersDTO;

namespace API_SAP_Magento.Mediator.Queries.Magento.GetMagentoOrder
{
    public class GetMagentoOrderQueryHandler(IBusinessPartnerMagentoRepository businessPartnerMagentoRepository) : IRequestHandler<GetMagentoOrderQuery, List<ItemMagentoDTO>>
    {
        public async Task<List<ItemMagentoDTO>> Handle(GetMagentoOrderQuery request, CancellationToken cancellationToken)
        {            
            return await businessPartnerMagentoRepository.GetMagentoOrdersDTOAsync();                 
        }
    }
}