
using API_SAP_Magento.Helpers.LoginHelper;
using API_SAP_Magento.Models.SAP;
using API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento;

namespace API_SAP_Magento.Repository.SAPRepositories.RepositoryItemSAP
{
    public class ItemSAPRepository : IItemSAPRepository
    {
        private readonly IItemMagentoRepository _magentoRepository;        

        public ItemSAPRepository(IItemMagentoRepository magentoRepository)
        {
            _magentoRepository = magentoRepository;
                       
        }
        public async Task<List<ItemSAP>> GetAllItemsAsync()
        { 
            List<ItemSAP> items = new List<ItemSAP>();

            string sql = "SELECT T0.\"ItemCode\", T0.\"ItemName\", T0.\"CodeBars\" FROM OITM T0";          
           
           //Realizar Login
           var company = Login.RealizarLogin();

           SAPbobsCOM.Recordset ors = (SAPbobsCOM.Recordset)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
           ors.DoQuery(sql);

           //Quantidade de Itens no SAP
           int qtdyTotalItens = ors.RecordCount;

           for(int i = 0; i < qtdyTotalItens; i++)
           {
              var itemSAP = new ItemSAP(ors.Fields.Item(0).Value.ToString(),
                                        ors.Fields.Item(1).Value.ToString(),
                                        "");             

              items.Add(itemSAP);
              ors.MoveNext();
           }

           return items;
        }

        public async Task<List<ItemSAPEstoque>> GetEstoqueItemAsync(string itemCode)
        {
           List<ItemSAPEstoque> estoqueItem = new();          

           try
           {
                var company = Login.RealizarLogin();

                 string sql = $"SELECT * FROM TJ_ESTOQUE T0 WHERE T0.\"ItemCode\" = '{itemCode}'";

                SAPbobsCOM.Recordset ors = (SAPbobsCOM.Recordset)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                ors.DoQuery(sql);
                int quantityItens = ors.RecordCount;

                for(int i = 0; i < quantityItens; i++)
                {
                    var itemSAP = new ItemSAPEstoque(ors.Fields.Item(0).Value.ToString(),                                               
                                                       int.Parse(ors.Fields.Item(3).Value.ToString()));

                    estoqueItem.Add(itemSAP);

                    ors.MoveNext();
                }

                
           }catch(Exception ex)
           {
                throw new Exception(ex.Message);
           }
            
           return estoqueItem;
        }


        public async Task<ItemSAP> GetItemByCodeAsync(string itemCode)
        {
            string sql = $"SELECT T0.\"ItemCode\", T0.\"ItemName\", T0.\"CodeBars\" FROM OITM T0 WHERE T0.\"ItemCode\" = '{itemCode}' ";   

            var company = Login.RealizarLogin();

            SAPbobsCOM.Recordset ors =  (SAPbobsCOM.Recordset)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            ors.DoQuery(sql);

            var itemSAP = new ItemSAP(ors.Fields.Item(0).Value.ToString(),
                                      ors.Fields.Item(1).Value.ToString(),
                                      "");           

            return itemSAP;
        }
    }
}