using System.ComponentModel.DataAnnotations;

namespace ColaBot_Web.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
    }
}
