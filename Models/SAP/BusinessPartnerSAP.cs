
namespace API_SAP_Magento.Models.SAP
{
    public class BusinessPartnerSAP
    { 
        public BusinessPartnerSAP(string? cardName, string? rua,string? numero, string? bairro, string? zipCode, string? cidade, string? telefone, string? cPF, string? email)
        {
            CardName = cardName;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            ZipCode = zipCode;
            Cidade = cidade;
            Telefone = telefone;
            CPF = cPF;
            Email = email;
        }

        public string? CardName { get; private set; }
        public string? Rua { get; private set; }
        public string? Numero { get; private set; }
        public string? Bairro { get; private set; }
        public string? ZipCode { get; private set; }
        public string? Cidade { get; private set; }
        public string? Telefone { get; private set; }
        public string? CPF { get; private set; }
        public string? Email { get; private set; }
    }
}