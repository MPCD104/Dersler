using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer.Kutuphane.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KutuphaneIslemleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeId = table.Column<int>(type: "int", nullable: false),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    VerildigiTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SonGetirmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KutuphaneIslemleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uye",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UyelikTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyelikAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uye", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YayinEvi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayinEvi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YayinEviId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false),
                    TurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitap_Tur_TurId",
                        column: x => x.TurId,
                        principalTable: "Tur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitap_YayinEvi_YayinEviId",
                        column: x => x.YayinEviId,
                        principalTable: "YayinEvi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitap_Yazar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_TurId",
                table: "Kitap",
                column: "TurId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_YayinEviId",
                table: "Kitap",
                column: "YayinEviId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_YazarId",
                table: "Kitap",
                column: "YazarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitap");

            migrationBuilder.DropTable(
                name: "KutuphaneIslemleri");

            migrationBuilder.DropTable(
                name: "Uye");

            migrationBuilder.DropTable(
                name: "Tur");

            migrationBuilder.DropTable(
                name: "YayinEvi");

            migrationBuilder.DropTable(
                name: "Yazar");
        }
    }
}
