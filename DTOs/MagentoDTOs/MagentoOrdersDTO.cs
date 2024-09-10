

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
        public string customer_address_id { get; set; }
        public string? email { get; set; }
        public string entity_id { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string parent_id { get; set; }
        public string? postcode { get; set; }
        public string? region { get; set; }
        public string? region_code { get; set; }
        public string region_id { get; set; }
        public List<string>? street { get; set; }
        public string? telephone { get; set; }
        public string? vat_id { get; set; }
    }

    public class BillingAddress
    {
        public string? address_type { get; set; }
        public string? city { get; set; }
        public string? country_id { get; set; }
        public string customer_address_id { get; set; }
        public string? email { get; set; }
        public string entity_id { get; set; }
        public string? firstname { get; set; }
        public string lastname { get; set; }
        public string parent_id { get; set; }
        public string postcode { get; set; }
        public string region { get; set; }
        public string region_code { get; set; }
        public string region_id { get; set; }
        public List<string> street { get; set; }
        public string telephone { get; set; }
        public string vat_id { get; set; }
    }

    public class BundleOption
    {
        public string option_id { get; set; }
        public string option_qty { get; set; }
        public List<string> option_selections { get; set; }
    }

    public class ExtensionAttributes
    {
        public List<BundleOption> bundle_options { get; set; }
        public VaultPaymentToken vault_payment_token { get; set; }
        public List<ShippingAssignment> shipping_assignments { get; set; }
        public List<PaymentAdditionalInfo> payment_additional_info { get; set; }
        public List<object> applied_taxes { get; set; }
        public List<object> item_applied_taxes { get; set; }
    }

    public class ItemMagentoDTO
    {
        public string base_currency_code { get; set; }
        public double base_discount_amount { get; set; }
        //public string base_discount_canceled { get; set; }
        public double base_grand_total { get; set; }
        public string base_discount_tax_compensation_amount { get; set; }
        public double base_shipping_amount { get; set; }
        public double base_shipping_canceled { get; set; }
        public string base_shipping_discount_amount { get; set; }
        public string base_shipping_discount_tax_compensation_amnt { get; set; }
        public double base_shipping_incl_tax { get; set; }
        public string base_shipping_tax_amount { get; set; }
        public double base_subtotal { get; set; }
        public double base_subtotal_canceled { get; set; }
        public double base_subtotal_incl_tax { get; set; }
        //public string base_tax_amount { get; set; }
        public string base_tax_canceled { get; set; }
        public double base_total_canceled { get; set; }
        public double base_total_due { get; set; }
        public string base_to_global_rate { get; set; }
        public string base_to_order_rate { get; set; }
        public string billing_address_id { get; set; }
        public string created_at { get; set; }
        public string customer_email { get; set; }
        public string customer_firstname { get; set; }
        public string customer_group_id { get; set; }
        public string customer_id { get; set; }
        public string customer_is_guest { get; set; }
        public string customer_lastname { get; set; }
        public string customer_note { get; set; }
        public string customer_note_notify { get; set; }
        public string customer_taxvat { get; set; }
        public double discount_amount { get; set; }
        //public string discount_canceled { get; set; }
        public string email_sent { get; set; }
        public string entity_id { get; set; }
        public string ext_order_id { get; set; }
        public string global_currency_code { get; set; }
        public double grand_total { get; set; }
        public string discount_tax_compensation_amount { get; set; }
        public string increment_id { get; set; }
        public string is_virtual { get; set; }
        public string order_currency_code { get; set; }
        public string protect_code { get; set; }
        public string quote_id { get; set; }
        public string remote_ip { get; set; }
        public double shipping_amount { get; set; }
        public double shipping_canceled { get; set; }
        public string shipping_description { get; set; }
        public string shipping_discount_amount { get; set; }
        public string shipping_discount_tax_compensation_amount { get; set; }
        public double shipping_incl_tax { get; set; }
        public string shipping_tax_amount { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public string store_currency_code { get; set; }
        public string store_id { get; set; }
        public string store_name { get; set; }
        public string store_to_base_rate { get; set; }
        public string store_to_order_rate { get; set; }
        public double subtotal { get; set; }
        public double subtotal_canceled { get; set; }
        public double subtotal_incl_tax { get; set; }
        //public string tax_amount { get; set; }
        public string tax_canceled { get; set; }
        public double total_canceled { get; set; }
        public double total_due { get; set; }
        public string total_item_count { get; set; }
        public string total_qty_ordered { get; set; }
        public string updated_at { get; set; }
        public double weight { get; set; }
        public List<ItemMagentoDTO> items { get; set; }
        public BillingAddress billing_address { get; set; }
        public Payment payment { get; set; }
        public List<StatusHistory> status_histories { get; set; }
        public ExtensionAttributes extension_attributes { get; set; }
        public double? base_discount_invoiced { get; set; }
        public string? base_discount_tax_compensation_invoiced { get; set; }
        public double? base_shipping_invoiced { get; set; }
        public double? base_subtotal_invoiced { get; set; }
        //public string? base_tax_invoiced { get; set; }
        public double? base_total_invoiced { get; set; }
        public string? base_total_invoiced_cost { get; set; }
        public double? base_total_paid { get; set; }
        public double? discount_invoiced { get; set; }
        public string? discount_tax_compensation_invoiced { get; set; }
        public string hold_before_state { get; set; }
        public string hold_before_status { get; set; }
        public double? shipping_invoiced { get; set; }
        public double? subtotal_invoiced { get; set; }
        public string? tax_invoiced { get; set; }
        public double? total_invoiced { get; set; }
        public double? total_paid { get; set; }
        public string applied_rule_ids { get; set; }
        public string coupon_code { get; set; }
        public string discount_description { get; set; }
        public string? base_total_refunded { get; set; }
        public string? customer_gender { get; set; }
        public string? total_refunded { get; set; }
        public string amount_refunded { get; set; }
        public string base_amount_refunded { get; set; }
        public double base_original_price { get; set; }
        public double base_price { get; set; }
        public double base_price_incl_tax { get; set; }
        public double base_row_invoiced { get; set; }
        public double base_row_total { get; set; }
        public double base_row_total_incl_tax { get; set; }
        public string discount_percent { get; set; }
        public string free_shipping { get; set; }
        public string discount_tax_compensation_canceled { get; set; }
        public string is_qty_decimal { get; set; }
        public string item_id { get; set; }
        public string name { get; set; }
        public string no_discount { get; set; }
        public string order_id { get; set; }
        public double original_price { get; set; }
        public double price { get; set; }
        public double price_incl_tax { get; set; }
        public string product_id { get; set; }
        public string product_type { get; set; }
        public string qty_canceled { get; set; }
        public string qty_invoiced { get; set; }
        public string qty_ordered { get; set; }
        public string qty_refunded { get; set; }
        public string qty_shipped { get; set; }
        public string quote_item_id { get; set; }
        public double row_invoiced { get; set; }
        public double row_total { get; set; }
        public double row_total_incl_tax { get; set; }
        public double row_weight { get; set; }
        public string sku { get; set; }
        public string tax_percent { get; set; }
        public string weee_tax_applied { get; set; }
        public ProductOption product_option { get; set; }
        public string? parent_item_id { get; set; }
        public ParentItem parent_item { get; set; }
    }

    public class ParentItem
    {
        public string amount_refunded { get; set; }
        public string base_amount_refunded { get; set; }
        public string base_discount_amount { get; set; }
        public string base_discount_invoiced { get; set; }
        public string base_discount_tax_compensation_amount { get; set; }
        public double base_original_price { get; set; }
        public double base_price { get; set; }
        public double base_price_incl_tax { get; set; }
        public string base_row_invoiced { get; set; }
        public double base_row_total { get; set; }
        public double base_row_total_incl_tax { get; set; }
        public string base_tax_amount { get; set; }
        public string base_tax_invoiced { get; set; }
        public string created_at { get; set; }
        public string discount_amount { get; set; }
        public string discount_invoiced { get; set; }
        public string discount_percent { get; set; }
        public string free_shipping { get; set; }
        public string discount_tax_compensation_amount { get; set; }
        public string discount_tax_compensation_canceled { get; set; }
        public string is_qty_decimal { get; set; }
        public string is_virtual { get; set; }
        public string item_id { get; set; }
        public string name { get; set; }
        public string no_discount { get; set; }
        public string order_id { get; set; }
        public double original_price { get; set; }
        public double price { get; set; }
        public double price_incl_tax { get; set; }
        public string product_id { get; set; }
        public string product_type { get; set; }
        public string qty_canceled { get; set; }
        public string qty_invoiced { get; set; }
        public string qty_ordered { get; set; }
        public string qty_refunded { get; set; }
        public string qty_shipped { get; set; }
        public string quote_item_id { get; set; }
        public string row_invoiced { get; set; }
        public double row_total { get; set; }
        public double row_total_incl_tax { get; set; }
        public double row_weight { get; set; }
        public string sku { get; set; }
        public string store_id { get; set; }
        public string tax_amount { get; set; }
        public string tax_canceled { get; set; }
        public string tax_invoiced { get; set; }
        public string tax_percent { get; set; }
        public string updated_at { get; set; }
        public double weight { get; set; }
        public ProductOption product_option { get; set; }
    }

    public class Payment
    {
        public object account_status { get; set; }
        public List<object> additional_information { get; set; }
        public double amount_ordered { get; set; }
        public double base_amount_ordered { get; set; }
        public double base_shipping_amount { get; set; }
        public string cc_exp_year { get; set; }
        public string cc_last4 { get; set; }
        public string cc_ss_start_month { get; set; }
        public string cc_ss_start_year { get; set; }
        public string entity_id { get; set; }
        public string last_trans_id { get; set; }
        public string method { get; set; }
        public string parent_id { get; set; }
        public double shipping_amount { get; set; }
        public double? amount_authorized { get; set; }
        public double? amount_paid { get; set; }
        public double? base_amount_authorized { get; set; }
        public double? base_amount_paid { get; set; }
        public double? base_amount_paid_online { get; set; }
        public double? base_shipping_captured { get; set; }
        public string cc_exp_month { get; set; }
        public string? cc_number_enc { get; set; }
        public string? cc_owner { get; set; }
        public string? cc_type { get; set; }
        public double? shipping_captured { get; set; }
        public ExtensionAttributes? extension_attributes { get; set; }
    }

    public class PaymentAdditionalInfo
    {
        public string? key { get; set; }
        public object? value { get; set; }
    }

    public class ProductOption
    {
        public ExtensionAttributes? extension_attributes { get; set; }
    }

    public class RootOrderDTO
    {
        public List<ItemMagentoDTO>? items { get; set; }
        public SearchCriteria? search_criteria { get; set; }
        public string total_count { get; set; }
    }

    public class SearchCriteria
    {
        public List<object> filter_groups { get; set; }
        public string current_page { get; set; }
    }

    public class Shipping
    {
        public Address address { get; set; }
        public string method { get; set; }
        public Total total { get; set; }
    }

    public class ShippingAssignment
    {
        public Shipping shipping { get; set; }
        public List<ItemMagentoDTO> items { get; set; }
    }

    public class StatusHistory
    {
        public string comment { get; set; }
        public string created_at { get; set; }
        public string entity_id { get; set; }
        public string entity_name { get; set; }
        public string? is_customer_notified { get; set; }
        public string is_visible_on_front { get; set; }
        public string parent_id { get; set; }
        public string status { get; set; }
    }

    public class Total
    {
        public double base_shipping_amount { get; set; }
        public double base_shipping_canceled { get; set; }
        public string base_shipping_discount_amount { get; set; }
        public string base_shipping_discount_tax_compensation_amnt { get; set; }
        public double base_shipping_incl_tax { get; set; }
        public string base_shipping_tax_amount { get; set; }
        public double shipping_amount { get; set; }
        public double shipping_canceled { get; set; }
        public string shipping_discount_amount { get; set; }
        public string shipping_discount_tax_compensation_amount { get; set; }
        public double shipping_incl_tax { get; set; }
        public string shipping_tax_amount { get; set; }
        public double? base_shipping_invoiced { get; set; }
        public double? shipping_invoiced { get; set; }
    }

    public class VaultPaymentToken
    {
        public string entity_id { get; set; }
        public string customer_id { get; set; }
        public string public_hash { get; set; }
        public string payment_method_code { get; set; }
        public string type { get; set; }
        public string created_at { get; set; }
        public string expires_at { get; set; }
        public string gateway_token { get; set; }
        public string token_details { get; set; }
        public bool is_active { get; set; }
        public bool is_visible { get; set; }
    }
    }
}