using Microsoft.AspNetCore.Components;
using SisControl.Client.Services.Dtos;
using SisControl.Shared.Models;
using System.Net.Http.Json;
using System.Runtime;

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

        public List<LancamentoDto> LancamentoDtos { get; set; } = new List<LancamentoDto>();

        public async Task BuscarTodosLancamentos()
        {
            var result = await _http.GetFromJsonAsync<List<LancamentoDto>>("api/lancamentos");
            if (result != null)
                LancamentoDtos = result;
        }

    }
}
