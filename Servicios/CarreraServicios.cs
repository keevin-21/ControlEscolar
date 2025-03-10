using Entidades.Modelos;
using Negocios;


namespace Servicios
{
    public class CarreraServicios
    {
        private readonly CarreraNegocio _carreraNegocio;
        public CarreraServicios(CarreraNegocio carreraNegocio)
        {
            _carreraNegocio = carreraNegocio;
        }

        public async Task<string> InsertarCarrera(E_Carrera carrera)
        {
            return await _carreraNegocio.InsertarCarrera(carrera);
        }   

        public async Task<IEnumerable<E_Carrera>> ListarCarreras()
        {
            return await _carreraNegocio.ListarCarreras();
        }
    }
}
