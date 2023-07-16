using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SisControl.Server.Migrations
{
    /// <inheritdoc />
    public partial class CriaPessoas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadePessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Fone = table.Column<string>(type: "TEXT", nullable: false),
                    CEP = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    Complemento = table.Column<string>(type: "TEXT", nullable: false),
                    Bairro = table.Column<string>(type: "TEXT", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    UF = table.Column<string>(type: "TEXT", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadePessoa", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EntidadePessoa",
                columns: new[] { "Id", "Bairro", "CEP", "Cidade", "Complemento", "Cpf", "DataAtualizacao", "DataCadastro", "DataNascimento", "Email", "Endereco", "Fone", "Nome", "UF" },
                values: new object[,]
                {
                    { 1, "Este Aqui", "29.200-001", "Guarapari", "Apto 001", "111.111.111-11", new DateTime(2023, 7, 14, 10, 56, 21, 928, DateTimeKind.Local).AddTicks(7548), new DateTime(2023, 7, 14, 10, 56, 21, 928, DateTimeKind.Local).AddTicks(7534), new DateOnly(1972, 12, 16), "Teste@teste.com", "Rua da minha casa, 001", "(27) 99999-1234", "Primeira Pessoa Cadastrada", "ES" },
                    { 2, "Este Aqui", "29.200-002", "Guarapari", "Apto 002", "222.222.222-22", new DateTime(2023, 7, 14, 10, 56, 21, 928, DateTimeKind.Local).AddTicks(7643), new DateTime(2023, 7, 14, 10, 56, 21, 928, DateTimeKind.Local).AddTicks(7642), new DateOnly(1974, 7, 12), "Teste@teste.com", "Rua da minha casa, 002", "(27) 99999-2345", "Segunda Pessoa Cadastrada", "ES" },
                    { 3, "Este Aqui", "29.200-003", "Guarapari", "Apto 003", "333.333.333-33", new DateTime(2023, 7, 14, 10, 56, 21, 928, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 7, 14, 10, 56, 21, 928, DateTimeKind.Local).AddTicks(7652), new DateOnly(1997, 9, 29), "Teste@teste.com", "Rua da minha casa, 003", "(27) 99999-3456", "Terceira Pessoa Cadastrada", "ES" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntidadePessoa");
        }
    }
}
