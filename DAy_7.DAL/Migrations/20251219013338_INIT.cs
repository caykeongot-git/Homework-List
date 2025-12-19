using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAy_7.DAL.Migrations
{
    /// <inheritdoc />
    public partial class INIT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CongTys",
                columns: table => new
                {
                    MaCty = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenCty = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SLNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTys", x => x.MaCty);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SoLanXN = table.Column<int>(type: "int", nullable: false),
                    AmTinh = table.Column<bool>(type: "bit", nullable: false),
                    MaCty = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanViens_CongTys_MaCty",
                        column: x => x.MaCty,
                        principalTable: "CongTys",
                        principalColumn: "MaCty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaCty",
                table: "NhanViens",
                column: "MaCty");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "CongTys");
        }
    }
}
