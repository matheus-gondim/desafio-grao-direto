using System.ComponentModel.DataAnnotations;

namespace GrainRestaurants.Core.DTOs.Request
{
    public class SignInResquestDto
    {
        [Required(ErrorMessage = "Email é um campo obrigatótio.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Senha é um parametro obrigatório.")]
        [RegularExpression(
                @"(?=.*\d)(?=.*\W+)(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",
                ErrorMessage = "A senha deve conter pelo menos uma letra maiúscula, uma letra minúscula, um número e um símbolo."
        )]
        public string Password { get; set; }
    }
}
