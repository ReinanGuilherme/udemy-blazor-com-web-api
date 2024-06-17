using PrimeiroAppBlazor.Library;

namespace PrimeiroAppBlazor.Client.Services
{
	public class CarreraService
	{
        public event Func<Task> onChange;
        public event Func<CarreraCLS, Task> onEdit;
		public List<CarreraCLS> lista { get; set; }

        public CarreraService()
        {
            lista = new List<CarreraCLS>();

            lista.Add(new CarreraCLS() { idcarrera = 1, nombrecarrera = "Informatica", descripcioncarrera = "Desc1" });
            lista.Add(new CarreraCLS() { idcarrera = 2, nombrecarrera = "Medicina", descripcioncarrera = "Desc2" });
        }

        public List<CarreraCLS> listarCarreras()
        {
            return lista;
        }
        public void agregar(CarreraCLS carreraCLS)
        {
            lista.Add(carreraCLS);
            notificarCambios();

		}
        public void eliminar(int idCarrera)
        {
            CarreraCLS obj =  lista.Where(p => p.idcarrera == idCarrera).First();
            lista.Remove(obj);
        }
        public void notificarCambios()
        {
            onChange?.Invoke();
        }
        
        public void notificarEdit(CarreraCLS carreraCLS)
        {
            onEdit.Invoke(carreraCLS);
        }
    }
}
