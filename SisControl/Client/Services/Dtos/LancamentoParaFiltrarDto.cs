namespace SisControl.Client.Services.Dtos
{
    public class LancamentoParaFiltrarDto
    {
        public int Id { get; set; }
        public int ComunidadeId { get; set; }
        public string? Comunidade { get; set; }
        public int PessoaId { get; set; }
        public string? Pessoa { get; set; }
        public int Ano { get; set; }

        public List<LancamentoParaFiltrarDto>? LancamentoParaFiltrarDtos { get; set; }

    }
}
