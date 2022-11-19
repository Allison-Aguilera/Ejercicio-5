using Datos.Interfaces;
using Datos.Repositorio;
using Ejercicio5.Interfaces;
using Modelos;

namespace Ejercicio5.Servicios
{
    public class LoginServicios : ILoginServicios
    {
        private readonly Config _configuracion;
        private ILoginRepositorio loginRepositorio;

        public LoginServicios(Config config)
        {
            _configuracion = config;
            loginRepositorio = new LoginRepositorio(config.CadenaConexion);
        }

        public async Task<bool> ValidarUsuario(Login login)
        {
            return await loginRepositorio.ValidarUsuario(login);
        }
    }
}
