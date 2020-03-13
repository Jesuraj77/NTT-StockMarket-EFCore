using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarketMVC.Entities;

namespace StockMarketMVC.Web.Controllers
{
    public class LoginController : Controller
    {
        //Initiate object to the service
        public bool Login(string UserName, string Password, string UserType)
        {
            return false;
        }

        public bool SignUp(User user)
        {
            return false;
        }
    }
}