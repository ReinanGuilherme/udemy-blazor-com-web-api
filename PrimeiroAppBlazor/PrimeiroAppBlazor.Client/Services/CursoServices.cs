using PrimeiroAppBlazor.Library;

namespace PrimeiroAppBlazor.Client.Services
{
    public class CursoServices
    {
		public List<CursoCLS> lista;
		public event Action OnChange;
		public event Action<CursoCLS> OnEdit;
		public CursoServices()
        {
			lista = new List<CursoCLS>();
			lista.Add(new CursoCLS
			{
				idcurso = 1,
				nombrecurso = "Matematica",
				numerocreditos = 6
			});

			lista.Add(new CursoCLS
			{
				idcurso = 2,
				nombrecurso = "Historia",
				numerocreditos = 8
			});
		}
		public List<CursoCLS> ListarCursos()
		{
			return lista;
		}

		public void Agregar(CursoCLS curso)
		{
			lista.Add(curso);
			NotificarCambios();
		}

		public void NotificarCambios()
		{
			OnChange.Invoke();
		}
		
		public void NotificarEditar(CursoCLS cursoCLS)
		{
			OnEdit.Invoke(cursoCLS);
		}

		public void Eliminar(int idcurso)
		{
			CursoCLS cursoCLS = lista.Where(p => p.idcurso == idcurso).First();
			lista.Remove(cursoCLS);
			NotificarCambios();
		}
    }
}
