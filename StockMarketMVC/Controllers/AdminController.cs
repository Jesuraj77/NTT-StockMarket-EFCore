using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarketMVC.Entities;

namespace StockMarketMVC.Web.Controllers
{
    public class AdminController : Controller
    {

        //Initiate object to the service
        public bool AddCompany(List<Company> company)
        {

            return false;

        }


        public bool DeleteCompany(int Id)
        {
            return true;
        }


        public IActionResult UpdateCompany(int Id)
        {
            Company Company = new Company();
            return View();
        }


        public IActionResult GetCompanyById(int Id)
        {
            Company Company = new Company();
            return View();
        }


        public IActionResult GetIPOById(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return View();
        }


        public bool ImportData(object file)
        {
            return true;
        }


        public IActionResult UpdateIPODetail(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return View();
        }


        public IActionResult ViewCompany(int Id)
        {
            Company CompanyList = new Company();
            return View();
        }
    }
}