
using Datos.Repositorios;
using Entidades.Modelos;

namespace Negocios
{
    public class CarreraNegocio
    {
        private readonly ICarreraReposiitorio _carreraRepositorio;
        public CarreraNegocio(ICarreraReposiitorio carreraRepositorio)
        {
            _carreraRepositorio = carreraRepositorio;
        }

        public async Task<string> InsertarCarrera(E_Carrera carrera)
        {
            try
            {
                await _carreraRepositorio.InsertarCarrera(carrera);
                return "Carrera insertada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<IEnumerable<E_Carrera>> ListarCarreras()
        {
            return await _carreraRepositorio.ListarCarreras();
        }   
    }
}
