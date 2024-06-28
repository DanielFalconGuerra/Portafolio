using Portafolio.Models.APIFutbol;
using RestSharp;

namespace Portafolio.Repositories
{
    public class ApiFutbolRepository: IApiFutbolRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseAddress;
        private readonly RestClient _restClient;

        public ApiFutbolRepository(HttpClient client, string baseAddress)
        {
            _client = client;
            _baseAddress = baseAddress;
            _restClient = new RestClient(baseAddress);
        }
        public async Task<Totals> getTotals()
        {
            var request = new RestRequest("Documentation/getTotals", Method.Get);
            //var response = _restClient.Execute<Totals>(request);
            try
            {
                var response = await _restClient.ExecuteAsync<Totals>(request);
                return response.Data;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
