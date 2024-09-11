using System.Net.Http.Headers;
using Newtonsoft.Json;
using static API_SAP_Magento.DTOs.MagentoDTOs.MagentoOrdersDTO;

namespace API_SAP_Magento.Repository.MagentoRepositories.RepositoryBusinessPartnerMagento
{
    public class BusinessPartnerMagentoRepository : IBusinessPartnerMagentoRepository
    {        
         readonly string url =  "https://www.lojatiaraju.com.br/rest/all/V1/orders?searchCriteria[currentPage]=1";
         //readonly string url = "https://www.lojatiaraju.com.br/rest/all/V1/orders?searchCriteria[pageSize]=1";

        public async Task<List<ItemMagentoDTO>> GetMagentoOrdersDTOAsync()
        {
            List<ItemMagentoDTO> allOrders = [];
           //var content = File.ReadAllLines(@"C:\Users\wladimir.souza\Downloads\token.txt");
            var content = File.ReadAllLines(@"C:\Users\wladimir.souza\Downloads\token_loja.txt");

             HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }; 

                using (var client = new HttpClient(clientHandler))
                {
                    try
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", content[0]);
                
                        var response = client.GetAsync(url);

                        string datasFromStore = await response.Result.Content.ReadAsStringAsync();                        
                       
                        var itens = JsonConvert.DeserializeObject<RootOrderDTO>(datasFromStore);

                        for(int i = 0; i < int.Parse(itens.total_count) ; i++)
                        {
                            if(itens.items?[i].status == "processing")
                            {
                                allOrders.Add(itens.items[i]);
                            }                             
                        }

                        return  allOrders;

                    }catch(Exception ex)
                    {                                      
                        Console.WriteLine(ex.ToString());
                    }
                }

                return allOrders;
        }
    }
}