using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pudi_padi.core.Migrations
{
    /// <inheritdoc />
    public partial class udipudi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "muugi_Ajalugus",
                columns: table => new
                {
                    muugi_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tootaja_ID = table.Column<int>(type: "int", nullable: false),
                    kuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_muugi_Ajalugus", x => x.muugi_ID);
                });

            migrationBuilder.CreateTable(
                name: "pudi_padi_poods",
                columns: table => new
                {
                    poe_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel_nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tootaja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tooted = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pudi_padi_poods", x => x.poe_ID);
                });

            migrationBuilder.CreateTable(
                name: "pusiklientide_Ostuajalugus",
                columns: table => new
                {
                    toode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toote_ID = table.Column<int>(type: "int", nullable: false),
                    toote_info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hind = table.Column<int>(type: "int", nullable: false),
                    toote_kogus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pusiklientide_Ostuajalugus", x => x.toode);
                });

            migrationBuilder.CreateTable(
                name: "pussikliendid",
                columns: table => new
                {
                    pusikliendi_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    perenimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel_nr = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aadress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pussikliendid", x => x.pusikliendi_ID);
                });

            migrationBuilder.CreateTable(
                name: "toodes",
                columns: table => new
                {
                    toote_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    toote_info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuupaev = table.Column<int>(type: "int", nullable: false),
                    kogus = table.Column<int>(type: "int", nullable: false),
                    ostuajalugu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hind = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toodes", x => x.toote_ID);
                });

            migrationBuilder.CreateTable(
                name: "tootajas",
                columns: table => new
                {
                    totaja_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    perenimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel_nr = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aadress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tootajas", x => x.totaja_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "muugi_Ajalugus");

            migrationBuilder.DropTable(
                name: "pudi_padi_poods");

            migrationBuilder.DropTable(
                name: "pusiklientide_Ostuajalugus");

            migrationBuilder.DropTable(
                name: "pussikliendid");

            migrationBuilder.DropTable(
                name: "toodes");

            migrationBuilder.DropTable(
                name: "tootajas");
        }
    }
}
