using SisControl.Client.Services.Dtos;
using SisControl.Shared.Models;

namespace SisControl.Client.Services
{
    public interface IServicoLancamentos
    {
        List<LancamentosConsultaDto> LancamentoDtos { get; set; }

        List<LancamentoParaFiltrarDto> LancamentoParaFiltrarDtos { get; set; }

        Task BuscarTodosLancamentos();

        Task BuscarParaFiltroLancamentos();

        Task BuscaLancamentosFiltro(int iAno);

    }
}
