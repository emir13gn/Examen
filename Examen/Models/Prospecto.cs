using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class Prospecto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [Display(Name ="Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [Display(Name = "Primer apellido")]
        public string apellidoP { get; set; }

        [Display(Name = "Segundo apellido")]
        public string apellidoM { get; set; }

        [Display(Name = "Calle")]
        [Required(ErrorMessage = "La calle es obligatoria")]
        public string calle { get; set; }

        [Required(ErrorMessage = "El numero es obligatorio")]
        [Display(Name = "Número")]
        public int numero { get; set; }
        [Display(Name = "Colonia")]
        [Required(ErrorMessage = "La colonia es obligatoria")]
        public string colonia { get; set; }

        [Display(Name = "Código Postal")]
        [Required(ErrorMessage = "El código postal es obligatorio")]
        public int codigoPostal { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [Display(Name = "Telefono")]
        public int telefono { get; set; }

        [Required(ErrorMessage = "El RFC es obligatorio")]
        [Display(Name = "RFC")]
        public string rfc { get; set; }

        [Display(Name = "Estatus")]
        public string estatus { get; set; } = "ENVIADO";

        [Display(Name = "Observaciones")]
        public string observaciones { get; set; }

    }
}
