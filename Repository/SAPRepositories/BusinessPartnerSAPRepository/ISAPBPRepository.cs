using API_SAP_Magento.Models.SAP;

namespace API_SAP_Magento.Repository.SAPRepositories.BusinessPartnerSAPRepository
{
    public interface ISAPBPRepository
    {
        int CreateSAPBPAsync(BusinessPartnerSAP partnerSAP);
        Task<bool> VerifyIfBPExistsAsync(string cpf);

        
    }
}