using System.ComponentModel.DataAnnotations;

namespace ColaBot_Web.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email informado é inválido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Senha { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
