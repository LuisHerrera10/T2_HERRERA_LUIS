using Microsoft.AspNetCore.Mvc;
using T2_HERRERA_LUIS.Models;
using T2_HERRERA_LUIS.Services;

namespace T2_HERRERA_LUIS.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        public DistribuidorController(ApplicationDbContext  context) 
        {
            this.dbcontext = context;
        }
        public IActionResult Index()
        {
            var viewModel = new DistribuidorViewModel
            {
                distribuidores = dbcontext.distribuidores.ToList(),
                distribuidor = new Distribuidor()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Distribuidor distribuidor)
        {
            if(ModelState.IsValid)
            {
                dbcontext.distribuidores.Add(distribuidor);
                dbcontext.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id)
        {
            if(id== null || id==0) 
            {
                return NotFound();
            }
            var obj = dbcontext.distribuidores.Find(id);
            if(obj==null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Distribuidor distribuidor)
        {
            if(ModelState.IsValid)
            {
                dbcontext.distribuidores.Update(distribuidor);
                dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id) 
        {
            if(id== null || id == 0)
            {
                return NotFound();
            }
            var obj = dbcontext.distribuidores.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Distribuidor distribuidor)
        {
            if(distribuidor==null)
            {
                return NotFound();
            }
            dbcontext.distribuidores.Remove(distribuidor);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
