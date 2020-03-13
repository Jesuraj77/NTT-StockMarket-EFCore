using StockMarketMVC.BusinessLayer.Interface;
using StockMarketMVC.DataLayer.DataContext;
using StockMarketMVC.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketMVC.BusinessLayer.Services
{
    public class LoginServices : ILoginServices
    {
        private StockdbContext _context;

        public LoginServices(StockdbContext context)
        {
            _context = context;
        }

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
