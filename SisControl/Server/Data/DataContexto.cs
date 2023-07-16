using Microsoft.EntityFrameworkCore;
using SisControl.Shared;

namespace SisControl.Server.Data
{
    public class DataContexto : DbContext
    {
        public DataContexto(DbContextOptions<DataContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EntidadePessoa>().HasData(
                new EntidadePessoa
                {
                    Id = 1,
                    Nome = "Primeira Pessoa Cadastrada",
                    DataNascimento = DateOnly.Parse("16/12/1972"),
                    Cpf = "111.111.111-11",
                    Email = "Teste@teste.com",
                    Fone = "(27) 99999-1234",
                    CEP = "29.200-001",
                    Endereco = "Rua da minha casa, 001",
                    Complemento = "Apto 001",
                    Bairro = "Este Aqui",
                    Cidade = "Guarapari",
                    UF = "ES"
                },
                new EntidadePessoa
                {
                    Id = 2,
                    Nome = "Segunda Pessoa Cadastrada",
                    DataNascimento = DateOnly.Parse("12/07/1974"),
                    Cpf = "222.222.222-22",
                    Email = "Teste@teste.com",
                    Fone = "(27) 99999-2345",
                    CEP = "29.200-002",
                    Endereco = "Rua da minha casa, 002",
                    Complemento = "Apto 002",
                    Bairro = "Este Aqui",
                    Cidade = "Guarapari",
                    UF = "ES"
                },
                new EntidadePessoa
                {
                    Id = 3,
                    Nome = "Terceira Pessoa Cadastrada",
                    DataNascimento = DateOnly.Parse("29/09/1997"),
                    Cpf = "333.333.333-33",
                    Email = "Teste@teste.com",
                    Fone = "(27) 99999-3456",
                    CEP = "29.200-003",
                    Endereco = "Rua da minha casa, 003",
                    Complemento = "Apto 003",
                    Bairro = "Este Aqui",
                    Cidade = "Guarapari",
                    UF = "ES"
                }
            );
        }
        public DbSet<EntidadePessoa> EntidadePessoa { get; set; }
    }
}
