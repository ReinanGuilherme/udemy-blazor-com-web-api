using PrimeiroAppBlazor.Library;

namespace PrimeiroAppBlazor.Client.Services
{
    public class CursoService
    {
		public List<CursoCLS> lista;
		public event Func<Task> OnChange;
		public event Func<CursoCLS, Task> OnEdit;
		public event Func<CursoCLS, Task> OnSearch;
		public CursoService()
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
		public List<CursoCLS> BuscarCursos(CursoCLS cursoCLS)
		{
			List<CursoCLS> listaTotal = ListarCursos();
			if (string.IsNullOrWhiteSpace(cursoCLS.nombrecurso))
			{
				listaTotal = listaTotal.Where(p => p.nombrecurso.ToUpper().Contains(cursoCLS.nombrecurso.ToUpper())).ToList();
			}

			if(cursoCLS.idcarrera != 0)
			{
				listaTotal = lista.Where(p => p.idcarrera == cursoCLS.idcarrera).ToList();
            }

			return listaTotal;
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
        public void Eliminar(int idcurso)
        {
            CursoCLS cursoCLS = lista.Where(p => p.idcurso == idcurso).First();
            lista.Remove(cursoCLS);
            NotificarCambios();
        }
        public void NotificarEditar(CursoCLS cursoCLS)
		{
			OnEdit.Invoke(cursoCLS);
		}
		public void NotificarSearch(CursoCLS cursoCLS)
		{
			OnSearch.Invoke(cursoCLS);
		}

		
    }
}
