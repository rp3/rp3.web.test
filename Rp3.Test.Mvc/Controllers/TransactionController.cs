using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rp3.Test.Mvc.Controllers
{
    public class TransactionController : Controller
    {

        public ActionResult Index()
        {
            Proxies.Proxy proxy = new Proxies.Proxy();

            var data = proxy.GetTransactions();

            List<Rp3.Test.Mvc.Models.TransactionViewModel> model = new List<Models.TransactionViewModel>();

            foreach(var item in data)
            {
                model.Add(new Models.TransactionViewModel()
                {
                    Amount = item.Amount,
                    CategoryId = item.CategoryId,
                    CategoryName = item.CategoryName,
                    Notes = item.Notes,
                    RegisterDate = item.RegisterDate,
                    ShortDescription = item.ShortDescription,
                    TransactionId = item.TransactionId,
                    TransactionType = item.TransactionType,
                    TransactionTypeId = item.TransactionTypeId                    
                });
            }
            
            return View(model);
        }

        public ActionResult Balance()
        {            
            return View();
        }

    }
}
