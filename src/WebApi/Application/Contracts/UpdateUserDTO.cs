using System.ComponentModel.DataAnnotations;

namespace FaculOop.WebApi.Application.Contracts
{
    /// <summary>
    /// Objeto de Transferência de Dados para atualização de usuário.
    /// DataTransferObject
    /// </summary>
    public class UpdateUserDTO
    {
        [Required(ErrorMessage = "O usuáro é obrigatório.")]
        public string User { get; set; }
    }
}