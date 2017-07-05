using System;
using System.Web.Mvc;
using calculatrice.Models;

namespace calculatrice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PerformOperation(ComputationModel model)
        {
            double result = 0;
            switch (model.OperatorType)
            {
                case 1:
                    result = model.FirstValue + model.SecondtValue;
                    break;
                case 2:
                    result = model.FirstValue - model.SecondtValue;
                    break;
                case 3:
                    result = model.FirstValue * model.SecondtValue;
                    break;
                case 4:
                    result = model.FirstValue / model.SecondtValue;
                    break;
                case 5:
                    result = Math.Pow(model.FirstValue, model.SecondtValue);
                    break;
                case 6:
                    result = model.FirstValue * Math.Sqrt(model.SecondtValue);
                    break;
                case 7:
                    result = model.FirstValue % model.SecondtValue;
                    break;
                default:
                    break;
            }


            return Json(result);
        }
    }
}
