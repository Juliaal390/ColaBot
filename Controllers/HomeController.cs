using ColaBot_Web.Filters;
using ColaBot_Web.Helper;
using ColaBot_Web.Models;
using ColaBot_Web.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ColaBot_Web.Controllers
{
    [Retornar]
    public class HomeController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

        public HomeController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //procura a entidade
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorEmail(loginModel.Email);

                    if (usuario != null)
                    {
                        //verifica se a senha da entidade é igual à informada
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Chat");
                        }
                        TempData["MensagemErro"] = "Senha inválida";

                    }

                    TempData["MensagemErro"] = "Email e/ou senha inválidos";
                }

                return View("Index");

            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Não foi possível fazer login: {e.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
