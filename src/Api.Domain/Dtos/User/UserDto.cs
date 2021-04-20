using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDto
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no maximo {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório para Login")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caractere(s)")]
        public string Email { get; set; }

    }
}
