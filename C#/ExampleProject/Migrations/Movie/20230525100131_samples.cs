using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleProject.Migrations.Movie
{
    /// <inheritdoc />
    public partial class samples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logins",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "screenDetails",
                columns: table => new
                {
                    ScreenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    SeatType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SeatStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenDetails", x => x.ScreenId);
                });

            migrationBuilder.CreateTable(
                name: "movieDetails",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    ScreenDetailsScreenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieDetails", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_movieDetails_screenDetails_ScreenDetailsScreenId",
                        column: x => x.ScreenDetailsScreenId,
                        principalTable: "screenDetails",
                        principalColumn: "ScreenId");
                });

            migrationBuilder.CreateTable(
                name: "bookingDetails",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "Date", nullable: false),
                    LoginUserId = table.Column<int>(type: "int", nullable: true),
                    MovieDetailsMovieId = table.Column<int>(type: "int", nullable: true),
                    ScreenDetailsScreenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingDetails", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_bookingDetails_logins_LoginUserId",
                        column: x => x.LoginUserId,
                        principalTable: "logins",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_bookingDetails_movieDetails_MovieDetailsMovieId",
                        column: x => x.MovieDetailsMovieId,
                        principalTable: "movieDetails",
                        principalColumn: "MovieId");
                    table.ForeignKey(
                        name: "FK_bookingDetails_screenDetails_ScreenDetailsScreenId",
                        column: x => x.ScreenDetailsScreenId,
                        principalTable: "screenDetails",
                        principalColumn: "ScreenId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookingDetails_LoginUserId",
                table: "bookingDetails",
                column: "LoginUserId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingDetails_MovieDetailsMovieId",
                table: "bookingDetails",
                column: "MovieDetailsMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingDetails_ScreenDetailsScreenId",
                table: "bookingDetails",
                column: "ScreenDetailsScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_movieDetails_ScreenDetailsScreenId",
                table: "movieDetails",
                column: "ScreenDetailsScreenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingDetails");

            migrationBuilder.DropTable(
                name: "logins");

            migrationBuilder.DropTable(
                name: "movieDetails");

            migrationBuilder.DropTable(
                name: "screenDetails");
        }
    }
}
