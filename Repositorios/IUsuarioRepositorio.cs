using ColaBot_Web.Models;

namespace ColaBot_Web.Repositorios
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorEmail(string email);
        UsuarioModel ListarPorId(int id);
    }
}
