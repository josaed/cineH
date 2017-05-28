using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cineH.Models
{
    public class genero
    {
        [Key]
        public int id_genero { get; set; }
         [Required(ErrorMessage = "Ingrese la descripción del genero")]
         [Display(Name = "genero")]
        public string descripcion_genero { get; set; }
        public string UrlImagen { get; set; }
        public  virtual ICollection<genero> Listagenero { get; set; }
        [NotMapped]
        public HttpPostedFileWrapper ImagenSubida { get; set; }
    }
}
