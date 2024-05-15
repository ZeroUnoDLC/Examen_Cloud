using System.ComponentModel.DataAnnotations;

namespace AppMusica.Entidades
{
    public class Tipo_instrumento
    {
        [Key]
        public int Id { get; set; } //PK
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List <Instrumento_musical>? Instrumentos { get; set;}

    }
}
