using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisControl.Shared.Models
{
    public class EntidadeUsuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PessoaId { get; set; }

        [Required]
        public int ComunidadeId { get; set; }

        public string Senha { get; set; } = "sem";
        public int Nivel { get; set; } = 0;
    }
}
