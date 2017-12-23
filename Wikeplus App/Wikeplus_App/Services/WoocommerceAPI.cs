using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wikeplus_App.Models;

namespace Wikeplus_App.Services
{
    class WoocommerceAPI
    {
        private static string website_url = "https://wikeplus.com";
        private static string consumer_key = "ck_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        private static string consumer_secret = "cs_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

       private static string GetAllProductsApiUrl = string.Format("{0}/wc-api/v3/products?consumer_key={1}&consumer_secret={2}",website_url, consumer_key, consumer_secret);
       private static string GetAllOrdersApiUrl = string.Format("{0}/wc-api/v3/orders?consumer_key={1}&consumer_secret={2}",website_url, consumer_key, consumer_secret);


        public async Task<Products> GetAllProducts()
        {
            var httpClient = new HttpClient();            
            var response = await httpClient.GetAsync(GetAllProductsApiUrl);
            HttpContent content = response.Content;
            var json = await content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<Products>(json);
            return products;
        }

        public async Task<Orders> GetAllOrders()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(GetAllOrdersApiUrl);
            HttpContent content = response.Content;
            var json = await content.ReadAsStringAsync();
            var orders = JsonConvert.DeserializeObject<Orders>(json);
            return orders;
        }
    }
}
