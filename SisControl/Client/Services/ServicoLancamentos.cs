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

        public List<LancamentosConsultaDto> LancamentoDtos { get; set; } = new List<LancamentosConsultaDto>();
        public List<LancamentoParaFiltrarDto> LancamentoParaFiltrarDtos { get; set; } = new List<LancamentoParaFiltrarDto>();

        public async Task BuscarTodosLancamentos()
        {
            var result = await _http.GetFromJsonAsync<List<LancamentosConsultaDto>>("api/lancamentos");
            if (result != null)
                LancamentoDtos = result;
        }

        public async Task BuscarParaFiltroLancamentos()
        {
            var result = await _http.GetFromJsonAsync<List<LancamentoParaFiltrarDto>>("api/lancamentos");
            if (result != null)
                LancamentoParaFiltrarDtos = result;
        }

        public async Task BuscaLancamentosFiltro(int iAno)
        {
            var result = await _http.GetFromJsonAsync<List<LancamentosConsultaDto>>($"api/lancamentos/{iAno}");
            //var result = await _http.GetFromJsonAsync<List<LancamentoDto>>("api/lancamentos/{iAno}/{iCom}");
            if (result != null)
                LancamentoDtos = result;
        }

    }
}
