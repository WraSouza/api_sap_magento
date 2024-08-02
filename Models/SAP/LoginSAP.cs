namespace API_SAP_Magento.Models.SAP
{
    public class LoginSAP
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Server { get; set; }
        public string? CompanyDB { get; set; }
        public string? DbServerType { get; set; }
        public bool UseTrusted { get; set; }
       
    }
}

