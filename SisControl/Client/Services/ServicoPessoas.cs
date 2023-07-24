using Microsoft.AspNetCore.Components;
using SisControl.Shared.Models;
using System.Net.Http.Json;

namespace SisControl.Client.Services.ServicoPessoas
{
    public class ServicoPessoas : IServicoPessoas
    {
        private readonly NavigationManager _navigationManager;
        private readonly HttpClient _http;

        public ServicoPessoas(NavigationManager navigationManager, HttpClient http)
        {
            _navigationManager = navigationManager;
            _http = http;
        }

        public List<EntidadePessoa> ListaPessoas { get; set; } = new List<EntidadePessoa>();

        public async Task<EntidadePessoa> BuscaPessoa(int id)
        {
            var result = await _http.GetFromJsonAsync<EntidadePessoa>($"api/pessoas/{id}");
            if (result != null)
                return result;
            throw new Exception("Não foi possível encontrar o Heroi");
        }

        public async Task BuscarTodasPessoas()
        {
            var result = await _http.GetFromJsonAsync<List<EntidadePessoa>>("api/pessoas");
            if (result != null)
                ListaPessoas = result;
        }

        public async Task CadastraPessoa(EntidadePessoa Pessoa)
        {
            var result = await _http.PostAsJsonAsync("api/pessoas", Pessoa);
            //if (result != null)
            //{
            //    await SetarPessoas(result);
            //}
            _navigationManager.NavigateTo("/consultarpessoas");

        }

        public async Task DeletarPessoa(int id)
        {
            var result = await _http.DeleteAsync($"api/pessoas/{id}");
            //await SetarPessoas(result);
            _navigationManager.NavigateTo("/consultarpessoas");
        }

        public async Task GravaPessoa(EntidadePessoa Pessoa)
        {
            var result = await _http.PutAsJsonAsync($"api/pessoas/{Pessoa.Id}", Pessoa);
            //await SetarPessoas(result);
            _navigationManager.NavigateTo("/consultarpessoas");
        }

        async Task IServicoPessoas.CancelarAcao()
        {
            var result = await _http.GetFromJsonAsync<List<EntidadePessoa>>("api/pessoas");
            if (result != null)
                ListaPessoas = result;
            _navigationManager.NavigateTo("/consultarpessoas");
        }

        private async Task SetarPessoas(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<EntidadePessoa>>();
            ListaPessoas = response;
            _navigationManager.NavigateTo("/consultarpessoas");
        }

    }
}
