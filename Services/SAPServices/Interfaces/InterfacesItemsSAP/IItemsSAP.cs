
using API_SAP_Magento.Models.SAP;

namespace API_SAP_Magento.Services.SAPServices.Interfaces.InterfacesItemsSAP
{
    public interface IItemsSAP
    {
        Task<List<ItemSAP>> GetAllItemsSAPAsync();
        Task<ItemSAP> GetItemByCodeAsync(string itemCode);
        Task<bool> AddItemAsync(ItemSAP itemSAP);
        Task<List<ItemSAP>> GetStockItemSAPAsync();
    }
}