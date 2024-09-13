

using System.ComponentModel.DataAnnotations;

namespace API_SAP_Magento.Models.SAP
{
    public class EstoqueItemSAP
    {
        public EstoqueItemSAP(string? idMagento, string? itemCode, string? onHand, bool isInStock)
        {
            IdMagento = idMagento;
            ItemCode = itemCode;            
            OnHand = onHand;
            IsInStock = isInStock;
        }

        [Required]
        public string? IdMagento { get; private set; }
        [Required]
        public string? ItemCode { get; private set; }   
        [Required]    
        public string? OnHand { get; private set; }
        [Required]
        public bool IsInStock { get; private set; }

    }
}