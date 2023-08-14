namespace SisControl.Client.Services.Dtos
{
    public class LancamentosConsultaDto
    {
        public int Id { get; set; }
        public int ComunidadeId { get; set; }
        public string? Comunidade { get; set; }
        public int PessoaId { get; set; }
        public string? Pessoa { get; set; }
        public int Ano { get; set; }
        public bool MJan { get; set; }
        public bool MFev { get; set; }
        public bool MMar { get; set; }
        public bool MAbr { get; set; }
        public bool MMai { get; set; }
        public bool MJun { get; set; }
        public bool MJul { get; set; }
        public bool MAgo { get; set; }
        public bool MSet { get; set; }
        public bool MOut { get; set; }
        public bool MNov { get; set; }
        public bool MDez { get; set; }

        public List<LancamentosConsultaDto>? LancamentoDtos { get; set; }

    }
}
