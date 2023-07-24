using Microsoft.AspNetCore.Mvc;
using SisControl.Server.Data;
using SisControl.Shared.Models;

namespace SisControl.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LancamentosController : ControllerBase
    {
        private readonly DataContexto _contexto;
        //private EntidadePessoa pPessoa = new EntidadePessoa();
        //private EntidadeComunidade cNome = new EntidadeComunidade();

        public LancamentosController(DataContexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<List<EntidadeLancamento>>> BuscarTodosLancamentos()
        {
            // EXEMPLO 01 - select 
            /*
            var lancamentos = _contexto.EntidadeLancamento.Select(el => new
            {
                el.Id,
                el.ComunidadeId,
                Comunidade = cNome.Nome,
                el.PessoaId,
                Pessoa = pNome.Nome,
                el.Ano,
                el.Jan
            });
            */

            /* EXEMPLO 02 - com linq  */
            var lancamentos = from el in _contexto.EntidadeLancamento
                              join ec in _contexto.EntidadeComunidade on el.ComunidadeId equals ec.Id
                              join ep in _contexto.EntidadePessoa on el.PessoaId equals ep.Id
                              select new
                              {
                                  el.Id,
                                  el.ComunidadeId,
                                  Comunidade = ec.Nome,
                                  el.PessoaId,
                                  Pessoa = ep.Nome,
                                  el.Ano,
                                  el.Jan
                              }; 

            //var lancamentos = await _contexto.EntidadeLancamento.ToListAsync();
            return Ok(lancamentos);
        }

        /*
        * SQL DA BUSCA
        SELECT 
            el.Id, 
            el.ComunidadeId, 
            ec.Nome as Comunidade, 
            el.PessoaId as Pessoa
        FROM
            EntidadeLancamento el 
        INNER JOIN
            EntidadeComunidade ec 
        ON 
            ec.Id = el.ComunidadeId
        */


        /*
        [HttpGet("{id}")]
        public async Task<ActionResult<EntidadePessoa>> BuscaPessoa(int id)
        {
            var pessoa = await _contexto.EntidadePessoa
                    .FirstOrDefaultAsync(x => x.Id == id);
            if (pessoa == null)
            {
                return NotFound("Cadastro não encontrado");
            }
            return Ok(pessoa);
        }

        [HttpPost]
        public async Task<ActionResult<List<EntidadePessoa>>> CreateCadastrarPessoa(EntidadePessoa pessoa)
        {
            _contexto.EntidadePessoa.Add(pessoa);
            await _contexto.SaveChangesAsync();
            return Ok(await BuscarTodasPessoas());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<EntidadePessoa>>> GravaPessoa(EntidadePessoa pessoa, int id)
        {
            var dbPessoa = await _contexto.EntidadePessoa
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbPessoa == null)
                return NotFound("Heroi não encontrado");

            dbPessoa.Nome = pessoa.Nome;
            dbPessoa.DataNascimento = pessoa.DataNascimento;
            dbPessoa.Email = pessoa.Email;
            dbPessoa.Fone = pessoa.Fone;
            dbPessoa.Cpf = pessoa.Cpf;
            dbPessoa.CEP = pessoa.CEP;
            dbPessoa.Endereco = pessoa.Endereco;
            dbPessoa.UF = pessoa.UF;
            dbPessoa.Complemento = pessoa.Complemento;
            dbPessoa.Bairro = pessoa.Bairro;
            dbPessoa.Cidade = pessoa.Cidade;
            dbPessoa.DataAtualizacao = DateTime.Now;

            await _contexto.SaveChangesAsync();
            return Ok(await BuscarTodasPessoas());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<EntidadePessoa>>> DeletarPessoa(int id)
        {
            var dbPessoa = await _contexto.EntidadePessoa
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbPessoa == null)
                return NotFound("Heroi não encontrado");

            _contexto.Remove(dbPessoa);
            await _contexto.SaveChangesAsync();

            return Ok(await BuscarTodasPessoas());
        }
        */
    }
}
