

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

        public string? IdMagento { get; private set; }
        public string? ItemCode { get; private set; }       
        public string? OnHand { get; private set; }
        public bool IsInStock { get; private set; }

    }
}