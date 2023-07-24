using SisControl.Shared.Models;

namespace SisControl.Client.Services
{
    public interface IServicoLancamentos
    {
        List<EntidadeLancamento> ListaLancamentos { get; set; }

        Task BuscarTodosLancamentos();
        //Task<EntidadeLancamento> BuscaLancamentos(int id);

        //Task CadastraLancamentos(EntidadeLancamento Lancamentos);
        //Task GravaPessoa(EntidadeLancamento Lancamentos);
        //Task DeletarLancamentos(int id);
        //Task CancelarAcao();
    }
}
