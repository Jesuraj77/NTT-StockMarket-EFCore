
using StockMarketMVC.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketMVC.BusinessLayer.Interface
{
    public interface ILoginServices
    {
        bool Login(String UserName, String Password, string UserType);
        bool SignUp(User user);
    }
}
