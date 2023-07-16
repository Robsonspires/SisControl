using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SisControl.Server.Data;
using SisControl.Shared;

namespace SisControl.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly DataContexto _contexto;

        public PessoasController(DataContexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<List<EntidadePessoa>>> BuscarTodasPessoas()
        {
            var pessoas = await _contexto.EntidadePessoa.ToListAsync();
            return Ok(pessoas);
        }

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
    }
}
