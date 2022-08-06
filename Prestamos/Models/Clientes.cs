using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Prestamos.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(60)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]

        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(200)]

        public virtual ICollection<Prestamos> Prestamos { get; set; }
    }
}