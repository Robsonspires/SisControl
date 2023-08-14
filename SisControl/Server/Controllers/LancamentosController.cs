using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SisControl.Client.Services.Dtos;
using SisControl.Server.Data;
using SisControl.Shared.Models;

namespace SisControl.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LancamentosController : ControllerBase
    {
        private readonly DataContexto _contexto;

        public LancamentosController(DataContexto contexto)
        { _contexto = contexto; }
        
        [HttpGet]
        public ActionResult<List<LancamentosConsultaDto>> BuscarTodosLancamentos()
        {
            // fazer a busca em três tabelas e criando uma.
            var lancamentos = from el in _contexto.EntidadeLancamentos
                              join ec in _contexto.EntidadeComunidades on el.ComunidadeId equals ec.Id
                              join ep in _contexto.EntidadePessoas on el.PessoaId equals ep.Id
                              select new
                              {
                                  el.Id,
                                  el.ComunidadeId,
                                  Comunidade = ec.Nome,
                                  el.PessoaId,
                                  Pessoa = ep.Nome,
                                  el.Ano,
                                  el.MJan,
                                  el.MFev,
                                  el.MMar,
                                  el.MAbr,
                                  el.MMai,
                                  el.MJun,
                                  el.MJul,
                                  el.MAgo,
                                  el.MSet,
                                  el.MOut,
                                  el.MNov,
                                  el.MDez
                              };

            //var lancamentos = await _contexto.LancamentoDtos.FromSqlRaw("EXECUTE BuscaLancamentos").ToListAsync();
            return Ok(lancamentos);
        }

        [HttpGet("filtro")]
        public ActionResult<List<LancamentoParaFiltrarDto>> BuscarParaFiltroLancamentos()
        {
            // fazer a busca em três tabelas e criando uma distinta
            var lancamentosParaFiltrar = from el in _contexto.EntidadeLancamentos
                              join ec in _contexto.EntidadeComunidades on el.ComunidadeId equals ec.Id
                              join ep in _contexto.EntidadePessoas on el.PessoaId equals ep.Id
                              select new
                              {
                                  el.Id,
                                  el.ComunidadeId,
                                  Comunidade = ec.Nome,
                                  el.PessoaId,
                                  Pessoa = ep.Nome,
                                  el.Ano
                              };

            return Ok(lancamentosParaFiltrar);
        }


        [HttpGet("{iAno}")]
        public ActionResult<List<LancamentosConsultaDto>> BuscaLancamentosFiltro(int iAno)
        {
            // fazer a busca em três tabelas e criando uma.
            var lancamentos = from el in _contexto.EntidadeLancamentos
                              join ec in _contexto.EntidadeComunidades on el.ComunidadeId equals ec.Id
                              join ep in _contexto.EntidadePessoas on el.PessoaId equals ep.Id
                              where el.Ano == iAno/* && el.ComunidadeId == iCom*/
                              select new
                              {
                                  el.Id,
                                  el.ComunidadeId,
                                  Comunidade = ec.Nome,
                                  el.PessoaId,
                                  Pessoa = ep.Nome,
                                  el.Ano,
                                  el.MJan,
                                  el.MFev,
                                  el.MMar,
                                  el.MAbr,
                                  el.MMai,
                                  el.MJun,
                                  el.MJul,
                                  el.MAgo,
                                  el.MSet,
                                  el.MOut,
                                  el.MNov,
                                  el.MDez
                              };
            return Ok(lancamentos);
        }
        
    }
}
