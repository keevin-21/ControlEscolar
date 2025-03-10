using Datos.Contexto;
using Entidades.DTO;
using Entidades.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Datos.Repositorios
{
    public class CarreraRepositorio : ICarreraReposiitorio
    {
     
        private readonly D_ContextoBD _bd;
        //public CarreraRepositorio() { }
        public CarreraRepositorio(D_ContextoBD bd)
        {
            _bd = bd;
        }

        public async Task InsertarCarrera(E_Carrera carrera)
        {
            try
            {
                await _bd.Carreras.AddAsync(carrera);
                await _bd.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task BorrarCarrera(E_Carrera carrera)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<E_Carrera>> ListarCarreras()
        {
            return await _bd.Carreras.ToListAsync();
        }

        public async Task ModificarCarrera(E_Carrera carrera)
        {
            if (idCarrera != carrera.IdCarrera)
            {
                bd.Carreras.Update(carrera);
                await bd.SaveChangesAsync();
            }
        }

        public Task<E_Carrera> ObtenerCarreraPorId(int idCarrera)
        {
            throw new NotImplementedException();
        }
    }
}
