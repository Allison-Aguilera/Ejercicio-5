using Modelos;

namespace Ejercicio5.Interfaces
{
    public interface ILoginServicios
    {
        Task<bool> ValidarUsuario(Login login);
    }
}
