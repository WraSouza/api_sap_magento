using API_SAP_Magento.Models.SAP;

namespace API_SAP_Magento.Repository.SAPRepositories.BusinessPartnerSAPRepository
{
    public interface ISAPBPRepository
    {
        Task<int> CreateSAPBPAsync(BusinessPartnerSAP partnerSAP);
        Task<bool> VerifyIfBPExist(string cpf);

        
    }
}