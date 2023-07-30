using System.ComponentModel.DataAnnotations;

namespace SisControl.Shared.Models
{
    public class EntidadeLancamento
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int? PessoaId { get; set; }
        [Required]
        public int? ComunidadeId { get; set; }
        [Required]
        public int Ano { get; set; }

        public bool Jan { get; set; } = false;
        public bool Fev { get; set; } = false;
        public bool Mar { get; set; } = false;
        public bool Abr { get; set; } = false;
        public bool Mai { get; set; } = false;
        public bool Jun { get; set; } = false;
        public bool Jul { get; set; } = false;
        public bool Ago { get; set; } = false;
        public bool Set { get; set; } = false;
        public bool Out { get; set; } = false;
        public bool Nov { get; set; } = false;
        public bool Dez { get; set; } = false;


    }
}
