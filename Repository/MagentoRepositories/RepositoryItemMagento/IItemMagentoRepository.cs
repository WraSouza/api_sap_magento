using API_SAP_Magento.Mediator.Commands.MagentoCommands.UpdateStockMagento;
using API_SAP_Magento.Models.SAP;
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento
{
    public interface IItemMagentoRepository
    {
        Task<Root> GetAllItemsAsync();
        Task<ItemSAP> GetItemMagentoByCodeAsync(string itemCode);
        void UpdateStockMagento(UpdateStockMagentoCommand estoqueItemMagento, string itemCode);
        Task<string> GetItemIdAsync(int itemCode);
    }
}