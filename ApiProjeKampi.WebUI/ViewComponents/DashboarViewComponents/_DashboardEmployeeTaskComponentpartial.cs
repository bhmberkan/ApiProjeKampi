using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.ViewComponents.DashboarViewComponents
{
    public class _DashboardEmployeeTaskComponentpartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardEmployeeTaskComponentpartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
