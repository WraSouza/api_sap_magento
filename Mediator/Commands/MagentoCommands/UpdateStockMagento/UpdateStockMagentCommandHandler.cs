<<<<<<< HEAD:Services/MagentoServices/MagentoImplementations/ItemsMagentoServices.cs

using API_SAP_Magento.Mediator.Queries.GetItemsSAPEstoque;
using API_SAP_Magento.Models.Magento;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using API_SAP_Magento.Services.MagentoServices.MagentoInterfaces.InterfacesItemsMagento;
using MediatR;
using static API_SAP_Magento.Models.Magento.ItemMagentoResponse;
=======
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using MediatR;
using static API_SAP_Magento.Mediator.Commands.MagentoCommands.UpdateStockMagento.UpdateStockMagentoCommand;
>>>>>>> tmp:Mediator/Commands/MagentoCommands/UpdateStockMagento/UpdateStockMagentCommandHandler.cs
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Mediator.Commands.MagentoCommands.UpdateStockMagento
{
    public class UpdateStockMagentCommandHandler : IRequestHandler<UpdateStockMagentoCommand, Unit>
    {
        private readonly IItemMagentoRepository _itemMagentoRepository;
        private readonly IItemSAPRepository _itemSAPRepository;
        private readonly IMediator _mediator;

<<<<<<< HEAD:Services/MagentoServices/MagentoImplementations/ItemsMagentoServices.cs
        public ItemsMagentoServices(IItemMagentoRepository itemMagento, IItemSAPRepository itemSAPRepository, IMediator mediator)
=======
        public UpdateStockMagentCommandHandler(IItemMagentoRepository itemMagentoRepository, IItemSAPRepository itemSAPRepository)
>>>>>>> tmp:Mediator/Commands/MagentoCommands/UpdateStockMagento/UpdateStockMagentCommandHandler.cs
        {
            _itemMagentoRepository = itemMagentoRepository;
            _itemSAPRepository = itemSAPRepository;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(UpdateStockMagentoCommand request, CancellationToken cancellationToken)
        {
            StockItemCommand itemMagento;

            UpdateStockMagentoCommand itemMagentoResponse;
            
            //Primeiro busca os itens na Magento
            Root itensInMagento = await _itemMagentoRepository.GetAllItemsAsync();
           
            for(int i = 0; i < itensInMagento?.total_count; i++)
            {
                //Buscar no SAP apenas os itens que existem na Loja Virtual
                var datas = new GetItemsSAPEstoqueQuery(itensInMagento?.items[i].sku);

                List<ItemSAPEstoque> itemsInSAP = await _mediator.Send(datas);

                foreach(var itemSAP in itemsInSAP)
                {
                    if(itemSAP.Quantidade > 0)
                    {
<<<<<<< HEAD:Services/MagentoServices/MagentoImplementations/ItemsMagentoServices.cs
                         itemMagento = new StockItem(itensInMagento?.items[i]?.id.ToString(),
=======
                         itemMagento = new StockItemCommand(itensInMagento.items[i].id.ToString(),
>>>>>>> tmp:Mediator/Commands/MagentoCommands/UpdateStockMagento/UpdateStockMagentCommandHandler.cs
                                                     itensInMagento.items[i].id.ToString(),
                                                     itemSAP.Quantidade.ToString(),true );
                        
                    }else
                    {
                         itemMagento = new StockItemCommand(itensInMagento.items[i].id.ToString(),
                                                     itensInMagento.items[i].id.ToString(),
                                                     itemSAP.Quantidade.ToString(),false );
                    }

                    itemMagentoResponse = new UpdateStockMagentoCommand(itemMagento);

                     _itemMagentoRepository.UpdateStockMagento(itemMagentoResponse,itemSAP.ItemCode);
                }              
                
            } 

            return Unit.Value;
        }
    }
}