using ColaBot_Web.Filters;
using ColaBot_Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace ColaBot_Web.Controllers
{
    [UsuarioLogado]
    public class ChatController : Controller
    {
        private readonly ISessao _sessao;
        public ChatController(ISessao sessao)
        {
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();

            return RedirectToAction("Index", "Home");
        }
    }
}
