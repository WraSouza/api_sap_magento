

using System.ComponentModel.DataAnnotations;

namespace API_SAP_Magento.Models.SAP
{
    public class ItemSAPEstoque
    {
        public ItemSAPEstoque(string itemCode, int? quantidade)
        {
            ItemCode = itemCode;
            Quantidade = quantidade;
        }
        
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public int? Quantidade { get; set; }
    }
}