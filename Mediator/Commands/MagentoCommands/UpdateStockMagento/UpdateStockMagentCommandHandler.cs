using API_SAP_Magento.Mediator.Queries.GetItemsSAPEstoque;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento;
using API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP;
using MediatR;
using static API_SAP_Magento.Mediator.Commands.MagentoCommands.UpdateStockMagento.UpdateStockMagentoCommand;
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Mediator.Commands.MagentoCommands.UpdateStockMagento
{
    public class UpdateStockMagentCommandHandler : IRequestHandler<UpdateStockMagentoCommand, Unit>
    {
        private readonly IItemMagentoRepository _itemMagentoRepository;
        private readonly IItemSAPRepository _itemSAPRepository;
        private readonly IMediator _mediator;

        public UpdateStockMagentCommandHandler(IItemMagentoRepository itemMagentoRepository, IItemSAPRepository itemSAPRepository, IMediator mediator)
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
                try
                {
                     //Buscar no SAP apenas os itens que existem na Loja Virtual
                var datas = new GetItemsSAPEstoqueQuery(itensInMagento?.items[i].sku);

                List<ItemSAPEstoque> itemsInSAP = await _mediator.Send(datas);

                foreach(var itemSAP in itemsInSAP)
                {
                    if(itemSAP.Quantidade > 0)
                    {
                         itemMagento = new StockItemCommand(itensInMagento.items[i].id.ToString(),
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
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                          
                
            } 

            return Unit.Value;
        }
    }
}