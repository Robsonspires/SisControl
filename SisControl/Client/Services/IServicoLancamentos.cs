using SisControl.Client.Services.Dtos;
using SisControl.Shared.Models;

namespace SisControl.Client.Services
{
    public interface IServicoLancamentos
    {
        List<LancamentoDto> LancamentoDtos { get; set; }

        Task BuscarTodosLancamentos();

    }
}
