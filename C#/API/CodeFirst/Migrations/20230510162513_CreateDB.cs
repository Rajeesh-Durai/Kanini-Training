using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThirdAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    DeptNo = table.Column<int>(type: "int", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptNo1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.DeptNo);
                    table.ForeignKey(
                        name: "FK_Depts_Depts_DeptNo1",
                        column: x => x.DeptNo1,
                        principalTable: "Depts",
                        principalColumn: "DeptNo");
                });

            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    Eno = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.Eno);
                    table.ForeignKey(
                        name: "FK_Emps_Depts_DeptNo",
                        column: x => x.DeptNo,
                        principalTable: "Depts",
                        principalColumn: "DeptNo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depts_DeptNo1",
                table: "Depts",
                column: "DeptNo1");

            migrationBuilder.CreateIndex(
                name: "IX_Emps_DeptNo",
                table: "Emps",
                column: "DeptNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emps");

            migrationBuilder.DropTable(
                name: "Depts");
        }
    }
}
