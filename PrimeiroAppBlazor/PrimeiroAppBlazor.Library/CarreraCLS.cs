using System.ComponentModel.DataAnnotations;

namespace PrimeiroAppBlazor.Library
{
    public class CarreraCLS
    {
        public int idcarrera { get; set; }
        [Required(ErrorMessage = "Ingresse el nombre de la carrera")]
        [MaxLength(100, ErrorMessage = "El nombre carrera no debe sobrepassar los 100 caracteres.")]
        [MinLength(3, ErrorMessage = "El nombre carrera no debe tener los 100 caracteres.")]
        public string nombrecarrera { get; set; }
        [Required(ErrorMessage = "Ingresse el descripcion de la carrera")]
        public string descripcioncarrera { get; set; }
    }
}
