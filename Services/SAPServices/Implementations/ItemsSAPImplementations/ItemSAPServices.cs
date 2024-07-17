using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using API_SAP_Magento.Services.SAPServices.Interfaces.InterfacesItemsSAP;

namespace API_SAP_Magento.Services.SAPServices
{
    public class ItemSAPServices : IItemsSAP
    {
        private readonly IItemSAPRepository _itemSAPRepository;
        public ItemSAPServices(IItemSAPRepository itemSAPRepository)
        {
            _itemSAPRepository = itemSAPRepository;
        }

        public Task<bool> AddItemAsync(ItemSAP itemSAP)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ItemSAP>> GetAllItemsSAP()
        {
            var allItens = await _itemSAPRepository.GetAllItemsAsync();
           
            return allItens;
        }

        public async Task<ItemSAP> GetItemByCode(string itemCode)
        {
            var itemSAP =  await _itemSAPRepository.GetItemByCode(itemCode);

            return itemSAP;
        }

        public async Task<List<ItemSAP>> GetStockItemSAP()
        {
           return await _itemSAPRepository.GetAllItemsAsync();
        }
    }
}