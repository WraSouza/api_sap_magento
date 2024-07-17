
using API_SAP_Magento.Models.SAP;

namespace API_SAP_Magento.Services.SAPServices.Interfaces.InterfacesItemsSAP
{
    public interface IItemsSAP
    {
        Task<List<ItemSAP>> GetAllItemsSAP();
        Task<ItemSAP> GetItemByCode(string itemCode);
        Task<bool> AddItemAsync(ItemSAP itemSAP);
        Task<List<ItemSAP>> GetStockItemSAP();
    }
}