using cineH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace cineH.Models
{
    public class pelicula
    {
        [Key]
        public int id_pelicula { get; set; }
        public string nombre_pelicula { get; set; }
        public string duracion { get; set; }
        public string audio { get; set; }
        public string calidad { get; set; }
        [Required]
        public int id_genero { get; set; }
        public genero genero { get; set; }
        [Required]
        public int id_formato { get; set; }
        public formato formato { get; set; }
        [Required]
        public int id_estudio{ get; set; }
        public estudio estudio { get; set; }
        [Required]
        public int id_director { get; set; }
        public director director { get; set; }
        public string elenco { get; set; }
        [Display(Name = "Fecha Estreno")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime fecha_estreno { get; set; }
        public string sinopsis { get; set; }
        public virtual ICollection<pelicula> Listapelicula { get; set; }
        public List<PeliculasImagenes> PeliculasImagenes { get; set; }

       

    }
}