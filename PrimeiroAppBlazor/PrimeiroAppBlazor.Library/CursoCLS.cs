using System.ComponentModel.DataAnnotations;

namespace PrimeiroAppBlazor.Library
{
    public class CursoCLS
    {
        public int idcurso { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre curso")]
        public string nombrecurso { get; set; } = string.Empty;
        [Range(1,10, ErrorMessage = "Debe ingresar un numero de creditos entre 1 y 10")]
        public int numerocreditos { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Seleccione una opcion del combo")]
		public int idcarrera { get; set; }
    }
}
