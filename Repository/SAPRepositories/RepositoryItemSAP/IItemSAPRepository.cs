
using API_SAP_Magento.Models.SAP;

namespace API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP
{
    public interface IItemSAPRepository
    {
        Task<List<ItemSAP>> GetAllItemsAsync();       
        Task<ItemSAP> GetItemByCodeAsync(string itemCode);
        Task<List<ItemSAPEstoque>> GetEstoqueItemAsync(string itemCode);
    }
}