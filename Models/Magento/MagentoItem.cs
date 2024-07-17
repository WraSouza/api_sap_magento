

namespace API_SAP_Magento.Models.Magento
{
    public class MagentoItem
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CategoryLink
    {
        public int position { get; set; }
        public string? category_id { get; set; }
    }

    public class CustomAttribute
    {
        public string? attribute_code { get; set; }
        public object? value { get; set; }
    }

    public class ExtensionAttributes
    {
        public List<int>? website_ids { get; set; }
        public List<CategoryLink>? category_links { get; set; }
    }

    public class ItemMagento
    {
        public int id { get; set; }
        public string? sku { get; set; }
        public string? name { get; set; }
        public int attribute_set_id { get; set; }
        public double price { get; set; }
        public int status { get; set; }
        public int visibility { get; set; }
        public string? type_id { get; set; }
        public string? created_at { get; set; }
        public string? updated_at { get; set; }
        public double weight { get; set; }
        public ExtensionAttributes? extension_attributes { get; set; }
        public List<ProductLink>? product_links { get; set; }
        public List<object>? options { get; set; }
        public List<MediaGalleryEntry>? media_gallery_entries { get; set; }
        public List<object>? tier_prices { get; set; }
        public List<CustomAttribute>? custom_attributes { get; set; }
    }

    public class MediaGalleryEntry
    {
        public int id { get; set; }
        public string? media_type { get; set; }
        public string? label { get; set; }
        public int position { get; set; }
        public bool disabled { get; set; }
        public List<string>? types { get; set; }
        public string? file { get; set; }
    }

    public class ProductLink
    {
        public string? sku { get; set; }
        public string? link_type { get; set; }
        public string? linked_product_sku { get; set; }
        public string? linked_product_type { get; set; }
        public int position { get; set; }
    }

    public class Root
    {
        public List<ItemMagento>? items { get; set; }
        public SearchCriteria? search_criteria { get; set; }
        public int total_count { get; set; }
    }

    public class SearchCriteria
    {
        public List<object>? filter_groups { get; set; }
        public int current_page { get; set; }
    }


    }
}