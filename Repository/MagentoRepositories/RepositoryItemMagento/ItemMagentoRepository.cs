
using System.Net.Http.Headers;
using System.Text;
using API_SAP_Magento.Models.Magento;
using API_SAP_Magento.Models.SAP;
using Newtonsoft.Json;
using static API_SAP_Magento.Models.Magento.ItemMagentoResponse;
using static API_SAP_Magento.Models.Magento.MagentoItem;

namespace API_SAP_Magento.Repository.MagentoRepositories.RepositoryItemMagento
{
    public class ItemMagentoRepository : IItemMagentoRepository
    {
        readonly string url = "https://dev.lojatiaraju.com.br/rest/all/V1/products?searchCriteria[currentPage]=1";
       
        public async Task<Root> GetAllItemsAsync()
        {             
             var content = File.ReadAllLines(@"C:\Users\wladimir.souza\Downloads\token.txt");            
            
             HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }; 

                using (var client = new HttpClient(clientHandler))
                {
                    try
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", content[0]);
                
                        var response = client.GetAsync(url);

                        string datasFromStore = await response.Result.Content.ReadAsStringAsync();

                        Root itens = JsonConvert.DeserializeObject<Root>(datasFromStore);

                        return itens;

                    }catch(Exception ex)
                    {
                        return null;
                    }
                    
                }

                
            
            //  using (var client = new HttpClient(clientHandler))
            //  {
            //     client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", content[0]);
                
            //     var response = client.GetAsync(url);                              
               
            //     string datasFromStore = await response.Result.Content.ReadAsStringAsync();

            //     Root itens = JsonConvert.DeserializeObject<Root>(datasFromStore);

            //     for(int i = 0; i < itens?.total_count ; i++)
            //     {
            //         var itemSAP = new ItemSAPEstoque(itens.items[i].sku,
            //                                 itens.items[i].,
            //                                 "");              

            //         items.Add(itemSAP);
            //     }
            //  }          
            

           

        }

        public async Task<string> GetItemId(int itemCode)
        {
           // ItemMagentoResponse? itemMagentoResponse = new();

           string itemId;

            HttpClientHandler clientHandler = new HttpClientHandler();
               clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }; 
            
             using (var client = new HttpClient(clientHandler))
             {
                var content = File.ReadAllLines(@"C:\Users\wladimir.souza\Downloads\token.txt");

                 client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", content[0]);
                var response = client.GetAsync($"https://dev.lojatiaraju.com.br/rest/all/V1/stockItems/{itemCode}");
                
                string datasFromStore = await response.Result.Content.ReadAsStringAsync();

                StockItem itemMagentoResponse = JsonConvert.DeserializeObject<StockItem>(datasFromStore);            
                
                itemId =  itemMagentoResponse.item_id;
             }          
            
            
            return itemId;
        }

        public Task<ItemSAP> GetItemMagentoByCode(string itemCode)
        {
            throw new NotImplementedException();
        }

        public async void UpdateStockMagento(ItemMagentoResponse estoqueItemMagento, string itemCode)
        {
            string jsonString = JsonConvert.SerializeObject(estoqueItemMagento);

            var content = File.ReadAllLines(@"C:\Users\wladimir.souza\Downloads\token.txt");            

            HttpClientHandler clientHandler = new HttpClientHandler();
               clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };  

            using (var client = new HttpClient(clientHandler))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", content[0]);

               await client.PutAsync($"https://dev.lojatiaraju.com.br/rest/all/V1/products/{itemCode}/stockItems/{estoqueItemMagento.stock_item.item_id}",
                          new StringContent(jsonString, Encoding.UTF8, "application/json"));
            }
        }
    }
}