namespace API_SAP_Magento.Models.SAP
{
    public class ItemSAP
    {
        public ItemSAP(string? itemCode, string? itemName, string barCode)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            BarCode = barCode;
        }

        public string? ItemCode { get; set; } = string.Empty; 
        public string? ItemName { get; set;}    
        public string BarCode { get; set; }  = string.Empty;
    }
}