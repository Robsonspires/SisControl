using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SisControl.Shared.Models
{
    public class EntidadeLancamento
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int PessoaId { get; set; }

        [Required]
        public int ComunidadeId { get; set; }

        [Required]
        public int Ano { get; set; }

        public bool Jan { get; set; }
        public bool Fev { get; set; }
        public bool Mar { get; set; }
        public bool Abr { get; set; }
        public bool Mai { get; set; }
        public bool Jun { get; set; }
        public bool Jul { get; set; }
        public bool Ago { get; set; }
        public bool Set { get; set; }
        public bool Out { get; set; }
        public bool Nov { get; set; }
        public bool Dez { get; set; }

    }

}
