using SAPbobsCOM;

namespace API_SAP_Magento.Helpers.LoginHelper
{
    public static class Login
    {
        public static Company RealizarLogin()
        {
            SAPbobsCOM.Company company= new SAPbobsCOM.Company();
            try
            {                
                company.UserName = "wladimir.souza";
                company.Password = "Admin10*";
                company.Server = "linux-7lxj:30015";
                company.CompanyDB = "SBO_TIARAJU_HOM";
                company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB;
                company.UseTrusted = false;

                company.Connect();

            }catch(Exception ex)
            {
                company = null;
            }
                

                return company;
        }
    }
}