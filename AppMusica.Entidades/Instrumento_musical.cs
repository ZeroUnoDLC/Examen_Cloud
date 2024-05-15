using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMusica.Entidades
{
    public class Instrumento_musical
    {
        [Key]
        public int Id { get; set; } //PK
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Material { get; set; }
        public string? Marca { get; set; }
        public double Precio { get; set; }
        public double? Descuento { get; set; }

        //Llave Foranea
        public int IdTipo_instrumento { get; set; }

        public Tipo_instrumento? Tipo_Instrumento { get; set; }

    }
}
