using static API_SAP_Magento.DTOs.MagentoDTOs.MagentoOrdersDTO;

namespace API_SAP_Magento.Repository.MagentoRepositories.RepositoryBusinessPartnerMagento
{
    public interface IBusinessPartnerMagentoRepository
    {
        Task<List<ItemMagentoDTO>> GetMagentoOrdersDTOAsync();
    }
}