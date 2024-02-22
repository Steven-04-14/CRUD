using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormCRUD.Models
{
    public class Producto
    {
        [Key]

        public int Id { get; set; }
        [Required]

        [DisplayName ("Nombre Producto")]
        public string NombreProducto { get; set; }
        [Required]

        public double Precio { get; set; }
        [Required]

        public int Qty { get; set; }
    }
}
