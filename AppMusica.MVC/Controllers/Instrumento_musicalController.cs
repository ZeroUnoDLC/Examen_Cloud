using AppEmpresa.ConsumeAPI;
using AppMusica.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppMusica.MVC.Controllers
{
    public class Instrumento_musicalController : Controller
    {
        private string urlApi;

        public Instrumento_musicalController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Instrumentos_musicales";
        }

        // GET: Instrumento_musicalController
        public ActionResult Index()
        {
            var data = Crud<Instrumento_musical>.Read(urlApi);
            return View(data);
        }

        // GET: Instrumento_musicalController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Instrumento_musical>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: Instrumento_musicalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instrumento_musicalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instrumento_musical data)
        {
            try
            {
                var newData = Crud<Instrumento_musical>.Create(urlApi, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: Instrumento_musicalController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Instrumento_musical>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: Instrumento_musicalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Instrumento_musical data)
        {
            try
            {
                Crud<Instrumento_musical>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: Instrumento_musicalController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Instrumento_musical>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: Instrumento_musicalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Instrumento_musical data)
        {
            try
            {
                Crud<Instrumento_musical>.Delete(urlApi, id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
    }
}
