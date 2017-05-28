using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace cineH.Models
{
    public class PeliculasImagenes
    {
        [Key]
        public int id_pelicula { get; set; }
        public pelicula pelicula { get; set; }
        public string UrlImagenMiniatura { get; set; }
        public string UrlImagenMediana { get; set; }
        [NotMapped]
        public HttpPostedFileWrapper ImagenSubida { get; set; }
        [NotMapped]
        public bool ImagenEliminada { get; set; }
        
    }
}