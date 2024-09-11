using API_SAP_Magento.Repository.MagentoRepositories.RepositoryBusinessPartnerMagento;
using MediatR;
using static API_SAP_Magento.DTOs.MagentoDTOs.MagentoOrdersDTO;

namespace API_SAP_Magento.Mediator.Queries.Magento.GetMagentoOrder
{
    public class GetMagentoOrderQueryHandler : IRequestHandler<GetMagentoOrderQuery, List<ItemMagentoDTO>>
    {
        private readonly IBusinessPartnerMagentoRepository _businessPartnerMagentoRepository;
        public GetMagentoOrderQueryHandler(IBusinessPartnerMagentoRepository businessPartnerMagentoRepository)
        {
            _businessPartnerMagentoRepository = businessPartnerMagentoRepository;
        }

        public async Task<List<ItemMagentoDTO>> Handle(GetMagentoOrderQuery request, CancellationToken cancellationToken)
        {            
            return await _businessPartnerMagentoRepository.GetMagentoOrdersDTOAsync();                 
        }
    }
}