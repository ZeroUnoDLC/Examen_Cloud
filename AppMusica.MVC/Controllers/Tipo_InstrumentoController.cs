using AppEmpresa.ConsumeAPI;
using AppMusica.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppMusica.MVC.Controllers
{
    public class Tipo_InstrumentoController : Controller
    {

        private string urlApi;

        public Tipo_InstrumentoController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Tipo_instrumentos";
        }

        // GET: Tipo_InstrumentoController
        public ActionResult Index()
        {
            var data = Crud<Tipo_instrumento>.Read(urlApi);
            return View(data);
        }

        // GET: Tipo_InstrumentoController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Tipo_instrumento>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: Tipo_InstrumentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipo_InstrumentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tipo_instrumento data)
        {
            try
            {
                var newData = Crud<Tipo_instrumento>.Create(urlApi, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: Tipo_InstrumentoController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Tipo_instrumento>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: Tipo_InstrumentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tipo_instrumento data)
        {
            try
            {
                Crud<Tipo_instrumento>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: Tipo_InstrumentoController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Tipo_instrumento>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: Tipo_InstrumentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Tipo_instrumento data)
        {
            try
            {
                Crud<Tipo_instrumento>.Delete(urlApi, id);
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
