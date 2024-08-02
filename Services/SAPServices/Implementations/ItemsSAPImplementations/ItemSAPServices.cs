using API_SAP_Magento.Mediator.Queries.GetItemsSAPEstoque;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using API_SAP_Magento.Services.SAPServices.Interfaces.InterfacesItemsSAP;
<<<<<<< HEAD
using MediatR;
=======
using Microsoft.Extensions.Options;
>>>>>>> tmp

namespace API_SAP_Magento.Services.SAPServices
{
    public class ItemSAPServices : IItemsSAP
    {
<<<<<<< HEAD
        private readonly IItemSAPRepository _itemSAPRepository;
        private readonly IMediator _mediator;

        public ItemSAPServices(IItemSAPRepository itemSAPRepository, IMediator mediator)
        {
            _itemSAPRepository = itemSAPRepository;
            _mediator = mediator;
=======
        private readonly IItemSAPRepository _itemSAPRepository;        

        public ItemSAPServices(IItemSAPRepository itemSAPRepository)
        {
            _itemSAPRepository = itemSAPRepository;           
>>>>>>> tmp
        }

        public Task<bool> AddItemAsync(ItemSAP itemSAP)
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public async Task<List<ItemSAP>> GetAllItemsSAPAsync()
        {
            var allItens = await _itemSAPRepository.GetAllItemsAsync();          
=======
        public async Task<List<ItemSAP>> GetAllItemsSAP()
        {            
            var allItens = await _itemSAPRepository.GetAllItemsAsync();
>>>>>>> tmp
           
            return allItens;
        }

        public async Task<ItemSAP> GetItemByCodeAsync(string itemCode)
        {
            var itemSAP =  await _itemSAPRepository.GetItemByCodeAsync(itemCode);

            return itemSAP;
        }

        public async Task<List<ItemSAP>> GetStockItemSAPAsync()
        {
           return await _itemSAPRepository.GetAllItemsAsync();
        }
    }
}