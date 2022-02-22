using System.ComponentModel.DataAnnotations;

namespace GrainRestaurants.Core.DTOs.Request
{
    public class SignUpRequestDto
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório.")]
        [StringLength(maximumLength: 250, MinimumLength = 3, ErrorMessage = "Nome deve ter 3 a 250 caracteres.")]
        public string Name { get; set; }


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
