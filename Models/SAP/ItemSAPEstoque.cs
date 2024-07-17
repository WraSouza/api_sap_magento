

namespace API_SAP_Magento.Models.SAP
{
    public class ItemSAPEstoque
    {
        public ItemSAPEstoque(string itemCode, int quantidade)
        {
            ItemCode = itemCode;
            Quantidade = quantidade;
        }

        public string ItemCode { get; set; }
        public int Quantidade { get; set; }
    }
}