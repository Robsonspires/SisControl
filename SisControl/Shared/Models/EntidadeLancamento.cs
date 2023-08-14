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

        public bool MJan { get; set; } = false;
        public bool MFev { get; set; } = false;
        public bool MMar { get; set; } = false;
        public bool MAbr { get; set; } = false;
        public bool MMai { get; set; } = false;
        public bool MJun { get; set; } = false;
        public bool MJul { get; set; } = false;
        public bool MAgo { get; set; } = false;
        public bool MSet { get; set; } = false;
        public bool MOut { get; set; } = false;
        public bool MNov { get; set; } = false;
        public bool MDez { get; set; } = false;


    }
}
