using Microsoft.EntityFrameworkCore;
using CRUD_API_EF_Basic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUD_API_EF_Basic.Controllers
{
    public class HomeController : Controller
    {
        private readonly CRUDAPIEFContext _DBContext;

        public HomeController(CRUDAPIEFContext context)
        {
            _DBContext = context;
        }

        public IActionResult Index()
        {
            List<Empleado> lista = _DBContext.Empleados.Include(c => c.oCargo).ToList();

            return View(lista);
        }

    }
}