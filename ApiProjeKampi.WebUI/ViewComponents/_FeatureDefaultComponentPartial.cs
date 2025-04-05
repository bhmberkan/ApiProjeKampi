using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.ViewComponents
{
    public class _FeatureDefaultComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
