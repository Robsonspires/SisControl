﻿using Microsoft.EntityFrameworkCore;
using SisControl.Shared.Models;
using SisControl.Client.Services.Dtos;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel.DataAnnotations.Schema;

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
                    DataNascimento = DateTime.Parse("16/12/1972"),
                    Cpf = "111.111.111-11",
                    Email = "testeum@teste.com",
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
                    DataNascimento = DateTime.Parse("12/07/1974"),
                    Cpf = "222.222.222-22",
                    Email = "testedois@teste.com",
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
                    DataNascimento = DateTime.Parse("12/07/1974"),
                    Cpf = "222.222.222-22",
                    Email = "testedois@teste.com",
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
                    Id = 4,
                    Nome = "Quarta Pessoa Cadastrada",
                    DataNascimento = DateTime.Parse("12/07/1974"),
                    Cpf = "222.222.222-22",
                    Email = "testedois@teste.com",
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
                    Id = 5,
                    Nome = "Quinta Pessoa Cadastrada",
                    DataNascimento = DateTime.Parse("12/07/1974"),
                    Cpf = "222.222.222-22",
                    Email = "testedois@teste.com",
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
                    Id = 6,
                    Nome = "Sexta Pessoa Cadastrada",
                    DataNascimento = DateTime.Parse("12/07/1974"),
                    Cpf = "222.222.222-22",
                    Email = "testedois@teste.com",
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
                    Id = 7,
                    Nome = "Setima Pessoa Cadastrada",
                    DataNascimento = DateTime.Parse("29/09/1997"),
                    Cpf = "333.333.333-33",
                    Email = "testetres@teste.com",
                    Fone = "(27) 99999-3456",
                    CEP = "29.200-003",
                    Endereco = "Rua da minha casa, 003",
                    Complemento = "Apto 003",
                    Bairro = "Este Aqui",
                    Cidade = "Guarapari",
                    UF = "ES"
                }
           );

            modelBuilder.Entity<EntidadeComunidade>().HasData(
                new EntidadeComunidade
                {
                    Id = 1,
                    Nome = "Divino Espírito Santo",
                    DataFundacao = DateTime.Parse("30/08/2016"),
                    Cnpj = "27.054.162/009620",
                    Email = "ofirdev@outlook.com",
                    Fone = "(27) 99937-1549",
                    CEP = "29202-515",
                    Endereco = "R. Eliziário Lourenço Dias, 505",
                    Complemento = "Com. Divino",
                    Bairro = "Ipiranga",
                    Cidade = "Guarapari",
                    UF = "ES"
                },
               new EntidadeComunidade
               {
                   Id = 2,
                   Nome = "Nossa Senhora do Carmo",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. N. S. do Carmo",
                   Bairro = "São João",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 3,
                   Nome = "Nossa Senhora Rainha da Paz",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. Rainha da Paz",
                   Bairro = "Ipiranga",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 4,
                   Nome = "Sagrada Família",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. Sagrada Família",
                   Bairro = "Praia do Riacho",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 5,
                   Nome = "Santa Cruz",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. Santa Cruz",
                   Bairro = "Kubitscheck",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 6,
                   Nome = "Santa Margarida",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. Santa Margarida",
                   Bairro = "Santa Margarida",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 7,
                   Nome = "Santo Expedito",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. Santo Expedito",
                   Bairro = "Concha D'Ostra",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 8,
                   Nome = "São João Batista",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. São João",
                   Bairro = "Prainha de Olaria",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 9,
                   Nome = "São Judas Tadeu",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. São Judas",
                   Bairro = "Olaria",
                   Cidade = "Guarapari",
                   UF = "ES"
               },
               new EntidadeComunidade
               {
                   Id = 10,
                   Nome = "São Sebastião",
                   DataFundacao = DateTime.Parse("30/08/2016"),
                   Cnpj = "27.054.162/009620",
                   Email = "ofirdev@outlook.com",
                   Fone = "(27) 99937-1549",
                   CEP = "29202-515",
                   Endereco = "R. Eliziário Lourenço Dias, 505",
                   Complemento = "Com. São Sebastião",
                   Bairro = "Coroado",
                   Cidade = "Guarapari",
                   UF = "ES"
               }
           );

            modelBuilder.Entity<EntidadeUsuario>().HasData(
                new EntidadeUsuario
                {
                    Id = 1,
                    PessoaId = 1,
                    ComunidadeId = 1
                },
                new EntidadeUsuario
                {
                    Id = 2,
                    PessoaId = 2,
                    ComunidadeId = 2
                },
                new EntidadeUsuario
                {
                    Id = 3,
                    PessoaId = 1,
                    ComunidadeId = 3
                },
                new EntidadeUsuario
                {
                    Id = 4,
                    PessoaId = 1,
                    ComunidadeId = 5
                },
                new EntidadeUsuario
                {
                    Id = 5,
                    PessoaId = 3,
                    ComunidadeId = 8
                }
                );

            modelBuilder.Entity<EntidadeLancamento>().HasData(
                new EntidadeLancamento
                {
                    Id = 1,
                    PessoaId = 1,
                    ComunidadeId = 1,
                    Ano = 2023,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = false,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = true
                },
                new EntidadeLancamento
                {
                    Id = 2,
                    PessoaId = 2,
                    ComunidadeId = 3,
                    Ano = 2023,
                    MJan = false,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 3,
                    PessoaId = 3,
                    ComunidadeId = 8,
                    Ano = 2023,
                    MJan = true,
                    MFev = false,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = true,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 4,
                    PessoaId = 2,
                    ComunidadeId = 1,
                    Ano = 2023,
                    MJan = true,
                    MFev = true,
                    MMar = false,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 5,
                    PessoaId = 1,
                    ComunidadeId = 9,
                    Ano = 2023,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = false,
                    MOut = false,
                    MNov = false,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 6,
                    PessoaId = 1,
                    ComunidadeId = 1,
                    Ano = 2022,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = false,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = true
                },
                new EntidadeLancamento
                {
                    Id = 7,
                    PessoaId = 2,
                    ComunidadeId = 3,
                    Ano = 2021,
                    MJan = false,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 8,
                    PessoaId = 3,
                    ComunidadeId = 8,
                    Ano = 2021,
                    MJan = true,
                    MFev = false,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = true,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 9,
                    PessoaId = 2,
                    ComunidadeId = 1,
                    Ano = 2022,
                    MJan = true,
                    MFev = true,
                    MMar = false,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 10,
                    PessoaId = 1,
                    ComunidadeId = 6,
                    Ano = 2022,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = false,
                    MOut = false,
                    MNov = false,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 11,
                    PessoaId = 1,
                    ComunidadeId = 1,
                    Ano = 2023,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = false,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = true
                },
                new EntidadeLancamento
                {
                    Id = 12,
                    PessoaId = 2,
                    ComunidadeId = 3,
                    Ano = 2023,
                    MJan = false,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 13,
                    PessoaId = 3,
                    ComunidadeId = 8,
                    Ano = 2023,
                    MJan = true,
                    MFev = false,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = true,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 14,
                    PessoaId = 2,
                    ComunidadeId = 1,
                    Ano = 2023,
                    MJan = true,
                    MFev = true,
                    MMar = false,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 15,
                    PessoaId = 1,
                    ComunidadeId = 9,
                    Ano = 2023,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = false,
                    MOut = false,
                    MNov = false,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 16,
                    PessoaId = 1,
                    ComunidadeId = 1,
                    Ano = 2022,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = false,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = true
                },
                new EntidadeLancamento
                {
                    Id = 17,
                    PessoaId = 2,
                    ComunidadeId = 3,
                    Ano = 2021,
                    MJan = false,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 18,
                    PessoaId = 3,
                    ComunidadeId = 8,
                    Ano = 2021,
                    MJan = true,
                    MFev = false,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = true,
                    MNov = true,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 19,
                    PessoaId = 2,
                    ComunidadeId = 1,
                    Ano = 2022,
                    MJan = true,
                    MFev = true,
                    MMar = false,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = true,
                    MOut = false,
                    MNov = false,
                    MDez = false
                },
                new EntidadeLancamento
                {
                    Id = 20,
                    PessoaId = 1,
                    ComunidadeId = 6,
                    Ano = 2022,
                    MJan = true,
                    MFev = true,
                    MMar = true,
                    MAbr = true,
                    MMai = true,
                    MJun = false,
                    MJul = false,
                    MAgo = false,
                    MSet = false,
                    MOut = false,
                    MNov = false,
                    MDez = false
                }

                );
        }
        public DbSet<EntidadePessoa> EntidadePessoas { get; set; }
        public DbSet<EntidadeComunidade> EntidadeComunidades { get; set; }
        public DbSet<EntidadeLancamento> EntidadeLancamentos { get; set; }
        public DbSet<EntidadeUsuario> EntidadeUsuarios { get; set; }

        public virtual DbSet<LancamentosConsultaDto> LancamentoDtos { get; set; }
        public virtual DbSet<LancamentoParaFiltrarDto> LancamentoParaFiltrarDtos { get; set; }
    }
}
