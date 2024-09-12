

namespace API_SAP_Magento.DTOs.MagentoDTOs
{
    public class MagentoOrdersDTO
    {
        
        
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Address
    {
        public string? address_type { get; set; }
        public string? city { get; set; }
        public string? country_id { get; set; }       
        public string? email { get; set; }        
        public string? firstname { get; set; }
        public string? lastname { get; set; }       
        public List<string>? street { get; set; }
        public string? telephone { get; set; }
        public string? vat_id { get; set; }
    }

    public class BillingAddress
    {
        public string? address_type { get; set; }
        public string? city { get; set; }       
        public string? email { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? postcode { get; set; }       
        public List<string>? street { get; set; }
        public string? telephone { get; set; }
        public string? vat_id { get; set; }
    }

    public class ItemMagentoDTO
    {
        public string? base_currency_code { get; set; }       
        public double base_shipping_amount { get; set; }
        public double base_shipping_canceled { get; set; }        
        public string? customer_email { get; set; }
        public string? customer_firstname { get; set; }
        public string? customer_group_id { get; set; }         
        public string? customer_lastname { get; set; }        
        public string? state { get; set; }
        public string? status { get; set; }      
        public List<ItemMagentoDTO>? items { get; set; }
        public BillingAddress? billing_address { get; set; }  
        public string? sku { get; set; }
        
    }   

    public class RootOrderDTO
    {
        public List<ItemMagentoDTO>? items { get; set; }       
        public string? total_count { get; set; }
    }

   
    }
}