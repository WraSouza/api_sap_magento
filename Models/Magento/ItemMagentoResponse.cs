

namespace API_SAP_Magento.Models.Magento
{
    public class ItemMagentoResponse
    {

        public StockItem stock_item { get; set;}

         public ItemMagentoResponse(StockItem stock_item)
        {
            this.stock_item = stock_item;
        }

        public class StockItem
        {
             public StockItem(string item_id, string product_id, string qty, bool is_in_stock)
        {
            this.item_id = item_id;
            this.product_id = product_id;
            this.stock_id = "1";
            this.qty = qty;
            this.is_in_stock = is_in_stock;
        }


        public string item_id { get; set; }
        public string product_id { get; set; }
        public string stock_id { get; set; }
        public string qty { get; set; }
        public bool is_in_stock { get; set; }
        }

       
    }
}