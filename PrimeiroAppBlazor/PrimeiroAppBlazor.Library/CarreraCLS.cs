using System.ComponentModel.DataAnnotations;

namespace PrimeiroAppBlazor.Library
{
    public class CarreraCLS
    {
        public int idcarrera { get; set; }
        [Required(ErrorMessage = "Ingresse el nombre de la carrera")]
        public string nombrecarrera { get; set; }
        [Required(ErrorMessage = "Ingresse el descripcion de la carrera")]
        public string descripcioncarrera { get; set; }
    }
}
