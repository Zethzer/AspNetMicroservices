using AspnetRunBasics.Extensions;
using AspnetRunBasics.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspnetRunBasics.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _client;

        public OrderService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<OrderResponseModel>> GetOrdersByUsername(string username)
        {
            var response = await _client.GetAsync($"/Order/{username}");
            return await response.ReadContentAs<List<OrderResponseModel>>();
        }
    }
}
