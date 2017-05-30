
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cineH.Models;
using cineH.Helper;

namespace cineH.Controllers
{
    
   
[Authorize(Roles="Admin")]
        public class PeliculaController : Controller
        {
        private DBContext db = new DBContext();

        //
        // GET: /Automovil/

        public ActionResult Index()
        {


            return View(db.Peliculas
                .Include("nombre_pelicula")
                .Include("duracion")
                .Include("audio")
                .Include("calidad")
                .Include("genero.descripcion_genero")
                .Include("formato.descripcion_formato")
                .Include("estudio.descripcion_estudio")
                .Include("director.descripcion_director")
                .Include("elenco")
                .Include("sinopsis")

                .Include("PeliculasImagenes")
                .ToList());
           

        }

        //
        // GET: /Automovil/Details/5

        public ActionResult Details(int id = 0)
        {
            pelicula pelicula = db.Peliculas.Find(id);
            if (pelicula == null)
            {
                return HttpNotFound();
            }
  
            return View(pelicula);
        }

        //
        // GET: /Peliculas/Create

        public ActionResult Create()
        {

            var pelicula = new pelicula()

            {
                fecha_estreno = DateTime.Now


            };

            return View(pelicula);

        } 

        //
        // POST: /Automovil/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(pelicula pelicula)
        {
            if (ModelState.IsValid)

            {

                if (pelicula.PeliculasImagenes != null && pelicula.PeliculasImagenes.Any())

                 {
                   var guardarImagen = new GuardarImagen();
          
                    foreach (var imagen in pelicula.PeliculasImagenes)

                     {
                     string  fileName =Guid.NewGuid().ToString();

                      imagen.UrlImagenMiniatura=  guardarImagen.ResizeAndSave(fileName,imagen.ImagenSubida.InputStream , Tamanos.Miniatura, false);
                      imagen.UrlImagenMediana = guardarImagen.ResizeAndSave(fileName, imagen.ImagenSubida.InputStream, Tamanos.Miniatura, false);
                         
                       }
                   }

                         
                db.Automovils.Add(pelicula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_pelicula = new SelectList(db.Peliculas, "Id_pelicula", "nombre_pelicula", "duracion", "audio","calidad","descripcion_genero",
                "descripcion_formato","descricion_estudio", "descripcion_director","elenco","sinopsis", pelicula.id_pelicula);
            return View(pelicula);
        }


    }
}


