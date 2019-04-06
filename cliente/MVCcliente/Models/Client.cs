
using System.ComponentModel.DataAnnotations;

namespace MVCcliente.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }

    }
}