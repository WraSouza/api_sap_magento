using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryBusinessPartnerMagento;
using API_SAP_Magento.Repository.SAPRepositories.BusinessPartnerSAPRepository;
using MediatR;
using static API_SAP_Magento.DTOs.MagentoDTOs.MagentoOrdersDTO;

namespace API_SAP_Magento.Mediator.Commands.SAPCommands.SAPBusinessPartner
{
    public class SAPBusinessPartnerCommandHandler : IRequestHandler<SAPBusinessPartnerCommand, int>
    {
        private readonly IBusinessPartnerMagentoRepository _magentoRepository;
        private readonly ISAPBPRepository _sapRepository;

        public SAPBusinessPartnerCommandHandler(IBusinessPartnerMagentoRepository magentoRepository, ISAPBPRepository sapRepository)
        {
            _magentoRepository = magentoRepository;
            _sapRepository = sapRepository;
        }
        public async Task<int> Handle(SAPBusinessPartnerCommand request, CancellationToken cancellationToken)
        {
            List<ItemMagentoDTO> bpInMagento = await _magentoRepository.GetMagentoOrdersDTOAsync();  

            for(int i = 0; i < bpInMagento.Count; i++)
            {
                bool verifyIfBPExist = await _sapRepository.VerifyIfBPExist(bpInMagento[i].billing_address.vat_id);                

                if(!verifyIfBPExist)
                {            

                    for( int j = i; j <= bpInMagento.Count; j++)
                    {
                        string fullName = bpInMagento[j].billing_address.firstname + " " + bpInMagento[j].customer_lastname;

                        var bpInSAP = new BusinessPartnerSAP(fullName.ToUpper()
                                                             ,bpInMagento[j].billing_address.street[0].ToUpper()
                                                             ,bpInMagento[j].billing_address.street[1].ToUpper()
                                                             ,bpInMagento[j].billing_address.street[3]
                                                             ,bpInMagento[j].billing_address.postcode
                                                             ,bpInMagento[j].billing_address.city
                                                             ,bpInMagento[j].billing_address.telephone
                                                             ,bpInMagento[j].billing_address.vat_id
                                                             ,bpInMagento[j].billing_address.email);

                        _sapRepository.CreateSAPBPAsync(bpInSAP);
                    }
                    
                }                             

            }           
           
        return 1;
           
        }
    }
}