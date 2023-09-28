using _07_MVC_EmployeeEntity.Entities;
using _07_MVC_EmployeeEntity.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _07_MVC_EmployeeEntity.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepo _repo;

        public CompanyController(ICompanyRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var company = _repo.GetAll();
            return View(company);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {
            _repo.Add(company);
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            var company = _repo.GetCompany(id);
            return View(company);
        }

        public IActionResult Update(int id)
        {
            return View(_repo.GetCompany(id));
        }

        [HttpPost]
        public IActionResult Update(Company company)
        {
            var companyOld=_repo.GetCompany(company.Id);
            companyOld.Brand=company.Brand;
            companyOld.Name = company.Name;
            companyOld.Address=company.Address;
            _repo.Update(companyOld);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repo.Delete(_repo.GetCompany(id));
            return RedirectToAction("Index");
        }
    }
}
