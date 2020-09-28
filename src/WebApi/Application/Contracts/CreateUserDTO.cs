using System.ComponentModel.DataAnnotations;

namespace FaculOop.WebApi.Application.Contracts
{
    /// <summary>
    /// Objeto de Transferência de Dados para criação de usuário.
    /// DataTransferObject
    /// </summary>
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "O identificador do usuáro é obrigatório."),
        Range(1, int.MaxValue, ErrorMessage = "O identificador deverá ser maior que 1.")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "O usuáro é obrigatório.")]
        public string User { get; set; }
    }
}