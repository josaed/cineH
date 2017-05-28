using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cineH.Models
{
    public class director
    {
        [Key]
        public int id_director { get; set; }
        public string nombre_director { get; set; }
        public string apellido_director { get; set; }
        [Display(Name = "Fecha nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime fecha_nacimiento { get; set; }
        public string lugar_de_nacimiento { get; set; }
        public string UrlImagen { get; set; }
        public virtual ICollection<director> Listadirector { get; set; }
        [NotMapped]
        public HttpPostedFileWrapper ImagenSubida { get; set; }
    }
}