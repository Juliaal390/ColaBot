using ColaBot_Web.Models;

namespace ColaBot_Web.Helper
{
    public interface ISessao
    {
        void CriarSessaoUsuario(UsuarioModel usuario);
        void RemoverSessaoUsuario();
        UsuarioModel BuscarSessaoUsuario();
    }
}
