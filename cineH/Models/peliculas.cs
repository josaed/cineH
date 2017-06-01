using cineH.Controllers;
using cineH.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace cineH.Models
{
    public class peliculas
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

        /**************************************/
        /*****************MYSQL****************/
        /**************************************/

        //agregar cliente en mysql
        public static int Agregar(peliculas pId_pelicula)
        {


            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (id_pelicula,nombre_pelicula,duracion,audio,calidad,id_genero,id_formato,id_estudio,id_director,fecha_estreno,elenco,sinopsis) values ({0},'{1}','{2}', '{3}','{4}',{5},{6},{7}, {8},'{9}', '{10}','{11}')",
                pId_pelicula.id_pelicula, pId_pelicula.nombre_pelicula, pId_pelicula.duracion, pId_pelicula.audio, pId_pelicula.calidad, pId_pelicula.id_genero, pId_pelicula.id_formato, pId_pelicula.id_estudio, pId_pelicula.id_director, pId_pelicula.fecha_estreno, pId_pelicula.elenco, pId_pelicula.sinopsis), conectarmysql.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


       

    }
}