using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.IoTrash.Data.Migrations
{
    public partial class testa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbEmpresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 40, nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmpresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbCaminhao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(nullable: false),
                    QuantidadeLixo = table.Column<double>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCaminhao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbCaminhao_TbEmpresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "TbEmpresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbRota",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescricaoRota = table.Column<string>(nullable: false),
                    DiaDaSemana = table.Column<int>(nullable: false),
                    CaminhaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbRota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbRota_TbCaminhao_CaminhaoId",
                        column: x => x.CaminhaoId,
                        principalTable: "TbCaminhao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbLixeira",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescricaoLixeira = table.Column<string>(nullable: false),
                    VolumeLixo = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    RotaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbLixeira", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbLixeira_TbRota_RotaId",
                        column: x => x.RotaId,
                        principalTable: "TbRota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbCaminhao_EmpresaId",
                table: "TbCaminhao",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_TbLixeira_RotaId",
                table: "TbLixeira",
                column: "RotaId");

            migrationBuilder.CreateIndex(
                name: "IX_TbRota_CaminhaoId",
                table: "TbRota",
                column: "CaminhaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbLixeira");

            migrationBuilder.DropTable(
                name: "TbRota");

            migrationBuilder.DropTable(
                name: "TbCaminhao");

            migrationBuilder.DropTable(
                name: "TbEmpresa");
        }
    }
}
