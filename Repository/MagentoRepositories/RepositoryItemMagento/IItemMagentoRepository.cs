

using API_SAP_Magento.Models.Magento;
using API_SAP_Magento.Models.SAP;
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento
{
    public interface IItemMagentoRepository
    {
        Task<Root> GetAllItemsAsync();
        Task<ItemSAP> GetItemMagentoByCode(string itemCode);
        void UpdateStockMagento(ItemMagentoResponse estoqueItemMagento, string itemCode);
        Task<string> GetItemId(int itemCode);
    }
}