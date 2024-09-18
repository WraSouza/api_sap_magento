using API_SAP_Magento.Helpers.LoginHelper;
using API_SAP_Magento.Models.SAP;
using SAPbobsCOM;

namespace API_SAP_Magento.Repository.SAPRepositories.BusinessPartnerSAPRepository
{
    public class SAPBPRepository(Login login) : ISAPBPRepository
    {        

        public int CreateSAPBPAsync(BusinessPartnerSAP partnerSAP)
        {      
            try
            {
                var company = login.RealizarLogin();
                    
                BusinessPartners businessPartnerSAP = (BusinessPartners)company.GetBusinessObject(BoObjectTypes.oBusinessPartners);
                   
                businessPartnerSAP.Series = 74;
                businessPartnerSAP.CardType = SAPbobsCOM.BoCardTypes.cCustomer;
                businessPartnerSAP.Addresses.AddressName = "Entrega";
                businessPartnerSAP.Addresses.Street = partnerSAP.Rua;
                businessPartnerSAP.Addresses.Block = partnerSAP.Bairro;
                businessPartnerSAP.Addresses.ZipCode = partnerSAP.ZipCode;
                businessPartnerSAP.Addresses.City = partnerSAP.Cidade;
                businessPartnerSAP.Addresses.StreetNo = partnerSAP.Numero;
                businessPartnerSAP.CardName = partnerSAP.CardName;
                businessPartnerSAP.EmailAddress = partnerSAP.Email;
                businessPartnerSAP.Phone1 = partnerSAP.Telefone;      
                businessPartnerSAP.GroupCode = 109; 
                businessPartnerSAP.FiscalTaxID.TaxId4 = partnerSAP.CPF;                            

                businessPartnerSAP.Add();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
               
            return 1;
            
        }

        public async Task<bool> VerifyIfBPExistsAsync(string cpf)
        {
            bool verifyIfBPExist = false;
           
            string sql = $"SELECT T0.\"CardCode\" FROM CRD7 T0 WHERE T0.\"TaxId4\" = '{cpf}'";

            var company = login.RealizarLogin();            

            try
            {                
                 Recordset ors =  (Recordset)company.GetBusinessObject(BoObjectTypes.BoRecordset);
                 ors.DoQuery(sql);

                 if(ors.RecordCount > 0)
                 {
                     verifyIfBPExist = true;

                    return verifyIfBPExist;
                 }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            return verifyIfBPExist;

        }
    }
}