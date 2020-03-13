using StockMarketMVC.BusinessLayer.Interface;
using StockMarketMVC.DataLayer.DataContext;
using StockMarketMVC.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketMVC.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private StockdbContext _context;

        public AdminServices(StockdbContext context)
        {
            _context = context;
        }


        public bool AddCompany(List<Company> company)
        {

            return false;

        }


        public bool DeleteCompany(int Id)
        {
            return true;
        }


        public Company UpdateCompany(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public Company GetCompanyById(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public IPODetail GetIPOById(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return IPOdetail;
        }


        public bool ImportData(object file)
        {
            return true;
        }


        public IPODetail UpdateIPODetail(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return IPOdetail;
        }


        public Company ViewCompany(int Id)
        {
            Company CompanyList = new Company();
            return CompanyList;
        }
    }
}
