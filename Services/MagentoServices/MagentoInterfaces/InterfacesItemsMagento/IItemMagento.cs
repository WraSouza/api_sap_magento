
using API_SAP_Magento.Models.SAP;


namespace API_SAP_Magento.Services.MagentoServices.MagentoInterfaces.InterfacesItemsMagento
{
    public interface IItemMagento
    {
        Task<List<ItemSAP>> GetAllItems();
        Task<ItemSAP> GetItemByCode();
        void UpdateEstoqueMagento();
    }
}