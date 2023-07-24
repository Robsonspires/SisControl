using Microsoft.AspNetCore.Components;
using SisControl.Shared.Models;
using System.Net.Http.Json;

namespace SisControl.Client.Services.ServicoLancamentos
{
    public class ServicoLancamentos : IServicoLancamentos
    {
        private readonly NavigationManager _navigationManager;
        private readonly HttpClient _http;

        public ServicoLancamentos(NavigationManager navigationManager, HttpClient http)
        {
            _navigationManager = navigationManager;
            _http = http;
        }

        public List<EntidadeLancamento> ListaLancamentos { get; set; } = new List<EntidadeLancamento>();

        public async Task BuscarTodosLancamentos()
        {
            var result = await _http.GetFromJsonAsync<List<EntidadeLancamento>>("api/lancamentos");
                if (result != null)
                    ListaLancamentos = result;        }

            //public async Task<EntidadePessoa> BuscaPessoa(int id)
            //{
            //    var result = await _http.GetFromJsonAsync<EntidadePessoa>($"api/pessoas/{id}");
            //    if (result != null)
            //        return result;
            //    throw new Exception("Não foi possível encontrar o Heroi");
            //}

            //public async Task CadastraPessoa(EntidadePessoa Pessoa)
            //{
            //    var result = await _http.PostAsJsonAsync("api/pessoas", Pessoa);
            //    //if (result != null)
            //    //{
            //    //    await SetarPessoas(result);
            //    //}
            //    _navigationManager.NavigateTo("/consultarpessoas");

            //}

            //public async Task DeletarPessoa(int id)
            //{
            //    var result = await _http.DeleteAsync($"api/pessoas/{id}");
            //    //await SetarPessoas(result);
            //    _navigationManager.NavigateTo("/consultarpessoas");
            //}

            //public async Task GravaPessoa(EntidadePessoa Pessoa)
            //{
            //    var result = await _http.PutAsJsonAsync($"api/pessoas/{Pessoa.Id}", Pessoa);
            //    //await SetarPessoas(result);
            //    _navigationManager.NavigateTo("/consultarpessoas");
            //}

            //async Task IServicoLancamentos.CancelarAcao()
            //{
            //    var result = await _http.GetFromJsonAsync<List<EntidadePessoa>>("api/pessoas");
            //    if (result != null)
            //        ListaPessoas = result;
            //    _navigationManager.NavigateTo("/consultarpessoas");
            //}

            //private async Task SetarPessoas(HttpResponseMessage result)
            //{
            //    var response = await result.Content.ReadFromJsonAsync<List<EntidadePessoa>>();
            //    ListaPessoas = response;
            //    _navigationManager.NavigateTo("/consultarpessoas");
            //}

        }
    }
