
using API_SAP_Magento.Models.Magento;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using API_SAP_Magento.Services.MagentoServices.MagentoInterfaces.InterfacesItemsMagento;
using static API_SAP_Magento.Models.Magento.ItemMagentoResponse;
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Services.MagentoServices.MagentoImplementations
{
    public class ItemsMagentoServices : IItemMagento
    {
        private readonly IItemMagentoRepository _itemMagento;
        private readonly IItemSAPRepository _itemSAPRepository;

        public ItemsMagentoServices(IItemMagentoRepository itemMagento, IItemSAPRepository itemSAPRepository)
        {
            _itemMagento = itemMagento;
            _itemSAPRepository = itemSAPRepository;
        }
        public async Task<List<ItemSAP>> GetAllItems()
        {
             throw new NotImplementedException();
        }

        public Task<ItemSAP> GetItemByCode()
        {
            throw new NotImplementedException();
        }

        public async void UpdateEstoqueMagento()
        {
            StockItem itemMagento;

            ItemMagentoResponse itemMagentoResponse;
            
            //Primeiro busca os itens na Magento
            Root itensInMagento = await _itemMagento.GetAllItemsAsync();
           
            for(int i = 0; i < itensInMagento.total_count; i++)
            {
                //Buscar no SAP apenas os itens que existem na Loja Virtual
                List<ItemSAPEstoque> itensInSAP = await _itemSAPRepository.GetEstoqueItemAsync(itensInMagento.items[i].sku);

                foreach(var itemSAP in itensInSAP)
                {
                    if(itemSAP.Quantidade > 0)
                    {
                         itemMagento = new StockItem(itensInMagento.items[i].id.ToString(),
                                                     itensInMagento.items[i].id.ToString(),
                                                     itemSAP.Quantidade.ToString(),true );

                        
                    }else
                    {
                         itemMagento = new StockItem(itensInMagento.items[i].id.ToString(),
                                                     itensInMagento.items[i].id.ToString(),
                                                     itemSAP.Quantidade.ToString(),false );
                    }

                    itemMagentoResponse = new ItemMagentoResponse(itemMagento);

                     _itemMagento.UpdateStockMagento(itemMagentoResponse,itemSAP.ItemCode);
                }              
                
            }                    
            
        }
    }
}