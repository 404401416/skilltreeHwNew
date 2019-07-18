using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Account.Models;
using Account.Repository;



namespace Account.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {

            return View();
        }

       
        public ActionResult Data()
        {
            List<ViewModels> display = new List<ViewModels>();
            //抓取account方法
            var repo = new AccountEFRepository();
            var AccountDB = repo.account();

            //轉換型態
            for (int i = 0; i < AccountDB.Count; i++)
            {
                display.Add(new ViewModels
                {
                    Type = (AccountDB[i].Categoryyy == 0) ? "收入" : "支出",
                    DateTime = AccountDB[i].Dateee,
                    Money = AccountDB[i].Amounttt,
                    Number = i+1,
                });
            }
            return View(display);
        }

       
      

    }
}