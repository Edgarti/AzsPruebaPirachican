using System.ComponentModel.DataAnnotations;

namespace AzsPruebaPirachican.Models
{
    public class LibrosModel
    {
        [Key]
        public int libroID { get; set; }
        public int AutorID  { get; set; }

        public string? titulo { get; set; }

        public DateTime fecCreacion { get; set; }

        public int estado { get; set; }

    }
}
