using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SisControl.Server.Migrations
{
    /// <inheritdoc />
    public partial class RecriandoasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadeComunidade",
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
                    table.PrimaryKey("PK_EntidadeComunidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadeLancamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    ComunidadeId = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Jan = table.Column<bool>(type: "bit", nullable: false),
                    Fev = table.Column<bool>(type: "bit", nullable: false),
                    Mar = table.Column<bool>(type: "bit", nullable: false),
                    Abr = table.Column<bool>(type: "bit", nullable: false),
                    Mai = table.Column<bool>(type: "bit", nullable: false),
                    Jun = table.Column<bool>(type: "bit", nullable: false),
                    Jul = table.Column<bool>(type: "bit", nullable: false),
                    Ago = table.Column<bool>(type: "bit", nullable: false),
                    Set = table.Column<bool>(type: "bit", nullable: false),
                    Out = table.Column<bool>(type: "bit", nullable: false),
                    Nov = table.Column<bool>(type: "bit", nullable: false),
                    Dez = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadeLancamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadePessoa",
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
                    table.PrimaryKey("PK_EntidadePessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadeUsuario",
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
                    table.PrimaryKey("PK_EntidadeUsuario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EntidadeComunidade",
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
                    { 9, "Prainha de Olaria", "29202-515", "Guarapari", "27.054.162/009620", "Com. São João", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "São João Batista", "ES" },
                    { 10, "Olaria", "29202-515", "Guarapari", "27.054.162/009620", "Com. São Judas", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "São Judas Tadeu", "ES" },
                    { 11, "Coroado", "29202-515", "Guarapari", "27.054.162/009620", "Com. São Sebastião", new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofirdev@outlook.com", "R. Eliziário Lourenço Dias, 505", "(27) 99937-1549", "São Sebastião", "ES" }
                });

            migrationBuilder.InsertData(
                table: "EntidadeLancamento",
                columns: new[] { "Id", "Abr", "Ago", "Ano", "ComunidadeId", "Dez", "Fev", "Jan", "Jul", "Jun", "Mai", "Mar", "Nov", "Out", "PessoaId", "Set" },
                values: new object[,]
                {
                    { 1, true, false, 2023, 1, false, true, true, false, false, true, true, false, false, 1, false },
                    { 2, true, false, 2023, 3, false, true, true, false, false, true, true, false, false, 2, false },
                    { 3, true, false, 2023, 8, false, true, true, false, false, true, true, false, false, 3, false },
                    { 4, true, false, 2023, 1, false, true, true, false, false, true, true, false, false, 2, false },
                    { 5, true, false, 2023, 9, false, true, true, false, false, true, true, false, false, 1, false }
                });

            migrationBuilder.InsertData(
                table: "EntidadePessoa",
                columns: new[] { "Id", "Bairro", "CEP", "Cidade", "Complemento", "Cpf", "DataAtualizacao", "DataCadastro", "DataNascimento", "Email", "Endereco", "Fone", "Nome", "UF" },
                values: new object[,]
                {
                    { 1, "Este Aqui", "29.200-001", "Guarapari", "Apto 001", "111.111.111-11", new DateTime(2023, 7, 23, 20, 52, 25, 219, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 7, 23, 20, 52, 25, 219, DateTimeKind.Local).AddTicks(5151), new DateTime(1972, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "testeum@teste.com", "Rua da minha casa, 001", "(27) 99999-1234", "Primeira Pessoa Cadastrada", "ES" },
                    { 2, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 7, 23, 20, 52, 25, 219, DateTimeKind.Local).AddTicks(5243), new DateTime(2023, 7, 23, 20, 52, 25, 219, DateTimeKind.Local).AddTicks(5243), new DateTime(1974, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "testedois@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Segunda Pessoa Cadastrada", "ES" },
                    { 3, "Este Aqui", "29.200-003", "Guarapari", "Apto 003", "333.333.333-33", new DateTime(2023, 7, 23, 20, 52, 25, 219, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 7, 23, 20, 52, 25, 219, DateTimeKind.Local).AddTicks(5253), new DateTime(1997, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "testetres@teste.com", "Rua da minha casa, 003", "(27) 99999-3456", "Terceira Pessoa Cadastrada", "ES" }
                });

            migrationBuilder.InsertData(
                table: "EntidadeUsuario",
                columns: new[] { "Id", "ComunidadeId", "Nivel", "PessoaId", "Senha" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, "sem" },
                    { 2, 2, 0, 2, "sem" },
                    { 3, 3, 0, 1, "sem" },
                    { 4, 5, 0, 1, "sem" },
                    { 5, 8, 0, 3, "sem" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntidadeComunidade");

            migrationBuilder.DropTable(
                name: "EntidadeLancamento");

            migrationBuilder.DropTable(
                name: "EntidadePessoa");

            migrationBuilder.DropTable(
                name: "EntidadeUsuario");
        }
    }
}
