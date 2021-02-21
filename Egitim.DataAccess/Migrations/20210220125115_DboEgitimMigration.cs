using Microsoft.EntityFrameworkCore.Migrations;

namespace Egitim.DataAccess.Migrations
{
    public partial class DboEgitimMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Okullar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OkulAdi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OkulAciklama = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    OkulPuan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FotoBaglantisi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okullar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenAdSoyad = table.Column<string>(type: "nvarchar(61)", maxLength: 61, nullable: false),
                    OgretmenBrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OgretmenAciklama = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    OgretmenPuan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FotoBaglantisi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OgretmenPozisyon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OkulId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogretmenler_Okullar_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okullar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OkulYorumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YorumIcerik = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Puan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OkulId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OkulYorumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OkulYorumlari_Okullar_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okullar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgretmenYorumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YorumIcerik = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Puan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OgretmenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenYorumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgretmenYorumlari_Ogretmenler_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenler_OkulId",
                table: "Ogretmenler",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenYorumlari_OgretmenId",
                table: "OgretmenYorumlari",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_OkulYorumlari_OkulId",
                table: "OkulYorumlari",
                column: "OkulId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgretmenYorumlari");

            migrationBuilder.DropTable(
                name: "OkulYorumlari");

            migrationBuilder.DropTable(
                name: "Ogretmenler");

            migrationBuilder.DropTable(
                name: "Okullar");
        }
    }
}
