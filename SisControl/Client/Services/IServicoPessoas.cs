using SisControl.Shared;

namespace SisControl.Client.Services
{
    public interface IServicoPessoas
    {
        List<EntidadePessoa> ListaPessoas { get; set; }

        Task BuscarTodasPessoas();
        Task<EntidadePessoa> BuscaPessoa(int id);

        Task CadastraPessoa(EntidadePessoa Pessoa);
        Task GravaPessoa(EntidadePessoa Pessoa);
        Task DeletarPessoa(int id);
        Task CancelarAcao();
    }
}
