using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySQL.Entidades;
using System.Linq;

namespace MySQL.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto db;
        public UsuariosController(Contexto _db)
        {
            db = _db;
        }
        public ActionResult Index()
        {
            return View(db.USUARIOS.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Usuario dadosQueVemTela)
        {
            db.USUARIOS.Add(dadosQueVemTela);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            return View(db.USUARIOS.Where(a=>a.Id == id).FirstOrDefault() );
        }


        [HttpPost]
        public ActionResult Edit(int id, Usuario dadosQueVemTela)
        {
            db.USUARIOS.Update(dadosQueVemTela);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.USUARIOS.Remove(
                db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("index");
        }


    }
}