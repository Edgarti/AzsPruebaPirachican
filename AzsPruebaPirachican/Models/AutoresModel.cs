using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AzsPruebaPirachican.Models
{
    public class AutoresModel
    {
        [Key]
        public int autorID  { get; set; }
        public string? nombre { get; set; }
        public DateTime fecCreacion { get; set; }
        public int estado { get; set; }         
   
    }
}
