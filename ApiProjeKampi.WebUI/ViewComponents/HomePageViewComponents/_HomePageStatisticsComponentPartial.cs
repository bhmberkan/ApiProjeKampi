using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace ApiProjeKampi.WebUI.ViewComponents.HomePageViewComponents
{
    public class _HomePageStatisticsComponentPartial : ViewComponent
    { 
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomePageStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7222/api/Statistics/ProductCount");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.v1 = jsonData;



            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7222/api/Statistics/ReservationCount");

            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.v2 = jsonData;


            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7222/api/Statistics/ChefCount");

            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.v3 = jsonData;



            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4= await client4.GetAsync("https://localhost:7222/api/Statistics/TotalGuestCount");

            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.v4 = jsonData;



            return View();
        }
    }
}
