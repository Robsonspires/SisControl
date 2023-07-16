using System.ComponentModel.DataAnnotations;

namespace SisControl.Shared
{
    public class EntidadePessoa
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s\p{L}]{5,70}$", ErrorMessage = "Nome é obrigatório, somente letras e com o mínimo de 5.")]
        public string Nome { get; set; } = string.Empty;

        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[012])\/(19|20)\d\d$", ErrorMessage = "Data inválida.")]
        public DateOnly DataNascimento { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido.")]
        public string Cpf { get; set; } = string.Empty;

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Email inválido.")]
        public string Email { get; set; } = string.Empty;

        [RegularExpression(@"^\(\d{2}\)\s\d{4,5}-\d{4}$", ErrorMessage = "Telefone inválido.")]
        public string Fone { get; set; } = string.Empty;

        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP inválido.")]
        public string CEP { get; set; } = string.Empty;

        public string Endereco { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;

        [RegularExpression(@"^[A-Z]{2,2}$", ErrorMessage = "Estado inválido.")]
        public string UF { get; set; } = string.Empty;

        [Required]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        [Required]
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
    }
}
