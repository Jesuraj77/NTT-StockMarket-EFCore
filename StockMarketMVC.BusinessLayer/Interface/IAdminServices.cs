
using StockMarketMVC.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketMVC.BusinessLayer.Interface
{
    public interface IAdminServices
    {
        bool AddCompany(List<Company> company);
        bool DeleteCompany(int Id);
        Company ViewCompany(int Id);
        Company UpdateCompany(int Id);
        IPODetail UpdateIPODetail(int Id);
        Company GetCompanyById(int Id);
        bool ImportData(object file);//Upload the Excel file of Stock Exchange. 
        IPODetail GetIPOById(int Id);
    }
}
