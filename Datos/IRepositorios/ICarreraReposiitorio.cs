using Entidades.Modelos;

namespace Datos.Repositorios
{
    public interface ICarreraReposiitorio
    {
        Task InsertarCarrera(E_Carrera carrera);
        Task BorrarCarrera(E_Carrera carrera);
        Task ModificarCarrera(E_Carrera carrera);
        Task<E_Carrera> ObtenerCarreraPorId(int idCarrera);
        Task<IEnumerable<E_Carrera>> ListarCarreras();
    }
}
