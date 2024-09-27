using Inventario.Data;
using Inventario.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Controllers
{
    public class ProductosController : Controller
    {
        private readonly AppDbContext RepositorioPropductos;
        public ProductosController(AppDbContext context)
        {
            RepositorioPropductos = context;

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var productos = await RepositorioPropductos.Productos.ToListAsync();
            return View(productos);
        }

        //[HttpPost]
        public async Task<IActionResult> Crear(Producto producto)
        {
            //duda de esto
            if (ModelState.IsValid)
            {
                    RepositorioPropductos.Add(producto);
                    await RepositorioPropductos.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return View(producto);
            }
        }
    }

