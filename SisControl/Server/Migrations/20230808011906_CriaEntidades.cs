using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SisControl.Server.Migrations
{
    /// <inheritdoc />
    public partial class CriaEntidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadeComunidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadeComunidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadeLancamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    ComunidadeId = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    MJan = table.Column<bool>(type: "bit", nullable: false),
                    MFev = table.Column<bool>(type: "bit", nullable: false),
                    MMar = table.Column<bool>(type: "bit", nullable: false),
                    MAbr = table.Column<bool>(type: "bit", nullable: false),
                    MMai = table.Column<bool>(type: "bit", nullable: false),
                    MJun = table.Column<bool>(type: "bit", nullable: false),
                    MJul = table.Column<bool>(type: "bit", nullable: false),
                    MAgo = table.Column<bool>(type: "bit", nullable: false),
                    MSet = table.Column<bool>(type: "bit", nullable: false),
                    MOut = table.Column<bool>(type: "bit", nullable: false),
                    MNov = table.Column<bool>(type: "bit", nullable: false),
                    MDez = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadeLancamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadePessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadePessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadeUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    ComunidadeId = table.Column<int>(type: "int", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadeUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LancamentoDtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComunidadeId = table.Column<int>(type: "int", nullable: false),
                    Comunidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    Pessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    MJan = table.Column<bool>(type: "bit", nullable: false),
                    MFev = table.Column<bool>(type: "bit", nullable: false),
                    MMar = table.Column<bool>(type: "bit", nullable: false),
                    MAbr = table.Column<bool>(type: "bit", nullable: false),
                    MMai = table.Column<bool>(type: "bit", nullable: false),
                    MJun = table.Column<bool>(type: "bit", nullable: false),
                    MJul = table.Column<bool>(type: "bit", nullable: false),
                    MAgo = table.Column<bool>(type: "bit", nullable: false),
                    MSet = table.Column<bool>(type: "bit", nullable: false),
                    MOut = table.Column<bool>(type: "bit", nullable: false),
                    MNov = table.Column<bool>(type: "bit", nullable: false),
                    MDez = table.Column<bool>(type: "bit", nullable: false),
                    LancamentosConsultaDtoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LancamentoDtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LancamentoDtos_LancamentoDtos_LancamentosConsultaDtoId",
                        column: x => x.LancamentosConsultaDtoId,
                        principalTable: "LancamentoDtos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LancamentoParaFiltrarDtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComunidadeId = table.Column<int>(type: "int", nullable: false),
                    Comunidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    Pessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    LancamentoParaFiltrarDtoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LancamentoParaFiltrarDtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LancamentoParaFiltrarDtos_LancamentoParaFiltrarDtos_LancamentoParaFiltrarDtoId",
                        column: x => x.LancamentoParaFiltrarDtoId,
                        principalTable: "LancamentoParaFiltrarDtos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "EntidadeComunidades",
                columns: new[] { "Id", "Bairro", "CEP", "Cidade", "Cnpj", "Complemento", "DataFundacao", "Email", "Endereco", "Fone", "Nome", "UF" },
                values: new object[,]
                {
                    { 1, "Ipiranga", "29202-515", "Guarapari", "27.054.162/009620", "Com. Divino", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "Divino Espírito Santo", "ES" },
                    { 2, "São João", "29202-515", "Guarapari", "27.054.162/009620", "Com. N. S. do Carmo", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "Nossa Senhora do Carmo", "ES" },
                    { 3, "Ipiranga", "29202-515", "Guarapari", "27.054.162/009620", "Com. Rainha da Paz", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "Nossa Senhora Rainha da Paz", "ES" },
                    { 4, "Praia do Riacho", "29202-515", "Guarapari", "27.054.162/009620", "Com. Sagrada Família", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "Sagrada Família", "ES" },
                    { 5, "Kubitscheck", "29202-515", "Guarapari", "27.054.162/009620", "Com. Santa Cruz", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "Santa Cruz", "ES" },
                    { 6, "Santa Margarida", "29202-515", "Guarapari", "27.054.162/009620", "Com. Santa Margarida", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "Santa Margarida", "ES" },
                    { 7, "Concha D'Ostra", "29202-515", "Guarapari", "27.054.162/009620", "Com. Santo Expedito", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "Santo Expedito", "ES" },
                    { 8, "Prainha de Olaria", "29202-515", "Guarapari", "27.054.162/009620", "Com. São João", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "São João Batista", "ES" },
                    { 9, "Olaria", "29202-515", "Guarapari", "27.054.162/009620", "Com. São Judas", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "São Judas Tadeu", "ES" },
                    { 10, "Coroado", "29202-515", "Guarapari", "27.054.162/009620", "Com. São Sebastião", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "São Sebastião", "ES" }
                });

            migrationBuilder.InsertData(
                table: "EntidadeLancamentos",
                columns: new[] { "Id", "Ano", "ComunidadeId", "MAbr", "MAgo", "MDez", "MFev", "MJan", "MJul", "MJun", "MMai", "MMar", "MNov", "MOut", "MSet", "PessoaId" },
                values: new object[,]
                {
                    { 1, 2023, 1, false, false, true, true, true, false, false, true, true, false, false, true, 1 },
                    { 2, 2023, 3, true, false, false, true, false, false, false, true, true, true, false, true, 2 },
                    { 3, 2023, 8, true, false, false, false, true, false, false, true, true, true, true, true, 3 },
                    { 4, 2023, 1, true, false, false, true, true, false, false, true, false, false, false, true, 2 },
                    { 5, 2023, 9, true, false, false, true, true, false, false, true, true, false, false, false, 1 },
                    { 6, 2022, 1, false, false, true, true, true, false, false, true, true, false, false, true, 1 },
                    { 7, 2021, 3, true, false, false, true, false, false, false, true, true, true, false, true, 2 },
                    { 8, 2021, 8, true, false, false, false, true, false, false, true, true, true, true, true, 3 },
                    { 9, 2022, 1, true, false, false, true, true, false, false, true, false, false, false, true, 2 },
                    { 10, 2022, 6, true, false, false, true, true, false, false, true, true, false, false, false, 1 },
                    { 11, 2023, 1, false, false, true, true, true, false, false, true, true, false, false, true, 1 },
                    { 12, 2023, 3, true, false, false, true, false, false, false, true, true, true, false, true, 2 },
                    { 13, 2023, 8, true, false, false, false, true, false, false, true, true, true, true, true, 3 },
                    { 14, 2023, 1, true, false, false, true, true, false, false, true, false, false, false, true, 2 },
                    { 15, 2023, 9, true, false, false, true, true, false, false, true, true, false, false, false, 1 },
                    { 16, 2022, 1, false, false, true, true, true, false, false, true, true, false, false, true, 1 },
                    { 17, 2021, 3, true, false, false, true, false, false, false, true, true, true, false, true, 2 },
                    { 18, 2021, 8, true, false, false, false, true, false, false, true, true, true, true, true, 3 },
                    { 19, 2022, 1, true, false, false, true, true, false, false, true, false, false, false, true, 2 },
                    { 20, 2022, 6, true, false, false, true, true, false, false, true, true, false, false, false, 1 }
                });

            migrationBuilder.InsertData(
                table: "EntidadePessoas",
                columns: new[] { "Id", "Bairro", "CEP", "Cidade", "Complemento", "Cpf", "DataAtualizacao", "DataCadastro", "DataNascimento", "Email", "Endereco", "Fone", "Nome", "UF" },
                values: new object[,]
                {
                    { 1, "Este Aqui", "29.200-001", "Guarapari", "Apto 001", "111.111.111-11", new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7495), new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7485), new DateTime(1972, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "testeum@teste.com", "Rua da minha casa, 001", "(27) 99999-1234", "Primeira Pessoa Cadastrada", "ES" },
                    { 2, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7580), new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "testedois@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Segunda Pessoa Cadastrada", "ES" },
                    { 3, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7591), new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7591), new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "testedois@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Terceira Pessoa Cadastrada", "ES" },
                    { 4, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7596), new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7596), new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "testedois@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Quarta Pessoa Cadastrada", "ES" },
                    { 5, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7601), new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "testedois@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Quinta Pessoa Cadastrada", "ES" },
                    { 6, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7607), new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7606), new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "testedois@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Sexta Pessoa Cadastrada", "ES" },
                    { 7, "Este Aqui", "29.200-003", "Guarapari", "Apto 003", "333.333.333-33", new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 8, 7, 22, 19, 6, 394, DateTimeKind.Local).AddTicks(7612), new DateTime(1997, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "testetres@teste.com", "Rua da minha casa, 003", "(27) 99999-3456", "Setima Pessoa Cadastrada", "ES" }
                });

            migrationBuilder.InsertData(
                table: "EntidadeUsuarios",
                columns: new[] { "Id", "ComunidadeId", "Nivel", "PessoaId", "Senha" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, "sem" },
                    { 2, 2, 0, 2, "sem" },
                    { 3, 3, 0, 1, "sem" },
                    { 4, 5, 0, 1, "sem" },
                    { 5, 8, 0, 3, "sem" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LancamentoDtos_LancamentosConsultaDtoId",
                table: "LancamentoDtos",
                column: "LancamentosConsultaDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_LancamentoParaFiltrarDtos_LancamentoParaFiltrarDtoId",
                table: "LancamentoParaFiltrarDtos",
                column: "LancamentoParaFiltrarDtoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntidadeComunidades");

            migrationBuilder.DropTable(
                name: "EntidadeLancamentos");

            migrationBuilder.DropTable(
                name: "EntidadePessoas");

            migrationBuilder.DropTable(
                name: "EntidadeUsuarios");

            migrationBuilder.DropTable(
                name: "LancamentoDtos");

            migrationBuilder.DropTable(
                name: "LancamentoParaFiltrarDtos");
        }
    }
}
