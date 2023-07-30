using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        {
            _contexto = contexto;
        }
        
        [HttpGet]
        public ActionResult<List<EntidadeLancamento>> Buscando()
        {
            // Usando o linq para a fazer a busca em três tabelas 
            // e criando uma.
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
                                  el.Jan, el.Fev, el.Mar, el.Abr,
                                  el.Mai, el.Jun, el.Jul, el.Ago,
                                  el.Set, el.Out, el.Nov, el.Dez
                              };
            return Ok(lancamentos);
        }
        
    }
}
