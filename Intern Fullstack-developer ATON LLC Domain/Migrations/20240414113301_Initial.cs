using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Intern_Fullstack_developer_ATON_LLC_Domain.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsiblePersonId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Users_ResponsiblePersonId",
                        column: x => x.ResponsiblePersonId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "Login", "Password" },
                values: new object[,]
                {
                    { 1, "Пользователь 1", "user1", "password1" },
                    { 2, "Пользователь 2", "user2", "password2" },
                    { 3, "Пользователь 3", "user3", "password3" },
                    { 4, "Пользователь 4", "user4", "password4" },
                    { 5, "Пользователь 5", "user5", "password5" },
                    { 6, "Пользователь 6", "user6", "password6" },
                    { 7, "Пользователь 7", "user7", "password7" },
                    { 8, "Пользователь 8", "user8", "password8" },
                    { 9, "Пользователь 9", "user9", "password9" },
                    { 10, "Пользователь 10", "user10", "password10" },
                    { 11, "Пользователь 11", "user11", "password11" },
                    { 12, "Пользователь 12", "user12", "password12" },
                    { 13, "Пользователь 13", "user13", "password13" },
                    { 14, "Пользователь 14", "user14", "password14" },
                    { 15, "Пользователь 15", "user15", "password15" },
                    { 16, "Пользователь 16", "user16", "password16" },
                    { 17, "Пользователь 17", "user17", "password17" },
                    { 18, "Пользователь 18", "user18", "password18" },
                    { 19, "Пользователь 19", "user19", "password19" },
                    { 20, "Пользователь 20", "user20", "password20" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AccountNumber", "BirthDate", "FirstName", "LastName", "MiddleName", "ResponsiblePersonId", "Status", "TIN" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1980, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 1", "Фамилия 1", "Отчество 1", 14, "Не в работе", "1234567891" },
                    { 2, 2, new DateTime(1980, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 2", "Фамилия 2", "Отчество 2", 12, "Не в работе", "1234567892" },
                    { 3, 3, new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 3", "Фамилия 3", "Отчество 3", 15, "Не в работе", "1234567893" },
                    { 4, 4, new DateTime(1980, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 4", "Фамилия 4", "Отчество 4", 3, "Не в работе", "1234567894" },
                    { 5, 5, new DateTime(1980, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 5", "Фамилия 5", "Отчество 5", 18, "Не в работе", "1234567895" },
                    { 6, 6, new DateTime(1980, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 6", "Фамилия 6", "Отчество 6", 8, "Не в работе", "1234567896" },
                    { 7, 7, new DateTime(1980, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 7", "Фамилия 7", "Отчество 7", 11, "Не в работе", "1234567897" },
                    { 8, 8, new DateTime(1980, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 8", "Фамилия 8", "Отчество 8", 4, "Не в работе", "1234567898" },
                    { 9, 9, new DateTime(1980, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 9", "Фамилия 9", "Отчество 9", 15, "Не в работе", "1234567899" },
                    { 10, 10, new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 10", "Фамилия 10", "Отчество 10", 11, "Не в работе", "12345678910" },
                    { 11, 11, new DateTime(1980, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 11", "Фамилия 11", "Отчество 11", 7, "Не в работе", "12345678911" },
                    { 12, 12, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 12", "Фамилия 12", "Отчество 12", 8, "Не в работе", "12345678912" },
                    { 13, 13, new DateTime(1981, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 13", "Фамилия 13", "Отчество 13", 6, "Не в работе", "12345678913" },
                    { 14, 14, new DateTime(1981, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 14", "Фамилия 14", "Отчество 14", 4, "Не в работе", "12345678914" },
                    { 15, 15, new DateTime(1981, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 15", "Фамилия 15", "Отчество 15", 2, "Не в работе", "12345678915" },
                    { 16, 16, new DateTime(1981, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 16", "Фамилия 16", "Отчество 16", 18, "Не в работе", "12345678916" },
                    { 17, 17, new DateTime(1981, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 17", "Фамилия 17", "Отчество 17", 14, "Не в работе", "12345678917" },
                    { 18, 18, new DateTime(1981, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 18", "Фамилия 18", "Отчество 18", 12, "Не в работе", "12345678918" },
                    { 19, 19, new DateTime(1981, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 19", "Фамилия 19", "Отчество 19", 17, "Не в работе", "12345678919" },
                    { 20, 20, new DateTime(1981, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 20", "Фамилия 20", "Отчество 20", 3, "Не в работе", "12345678920" },
                    { 21, 21, new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 21", "Фамилия 21", "Отчество 21", 3, "Не в работе", "12345678921" },
                    { 22, 22, new DateTime(1981, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 22", "Фамилия 22", "Отчество 22", 3, "Не в работе", "12345678922" },
                    { 23, 23, new DateTime(1981, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 23", "Фамилия 23", "Отчество 23", 16, "Не в работе", "12345678923" },
                    { 24, 24, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 24", "Фамилия 24", "Отчество 24", 18, "Не в работе", "12345678924" },
                    { 25, 25, new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 25", "Фамилия 25", "Отчество 25", 18, "Не в работе", "12345678925" },
                    { 26, 26, new DateTime(1982, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 26", "Фамилия 26", "Отчество 26", 5, "Не в работе", "12345678926" },
                    { 27, 27, new DateTime(1982, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 27", "Фамилия 27", "Отчество 27", 20, "Не в работе", "12345678927" },
                    { 28, 28, new DateTime(1982, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 28", "Фамилия 28", "Отчество 28", 15, "Не в работе", "12345678928" },
                    { 29, 29, new DateTime(1982, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 29", "Фамилия 29", "Отчество 29", 16, "Не в работе", "12345678929" },
                    { 30, 30, new DateTime(1982, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 30", "Фамилия 30", "Отчество 30", 17, "Не в работе", "12345678930" },
                    { 31, 31, new DateTime(1982, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 31", "Фамилия 31", "Отчество 31", 11, "Не в работе", "12345678931" },
                    { 32, 32, new DateTime(1982, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 32", "Фамилия 32", "Отчество 32", 10, "Не в работе", "12345678932" },
                    { 33, 33, new DateTime(1982, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 33", "Фамилия 33", "Отчество 33", 12, "Не в работе", "12345678933" },
                    { 34, 34, new DateTime(1982, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 34", "Фамилия 34", "Отчество 34", 9, "Не в работе", "12345678934" },
                    { 35, 35, new DateTime(1982, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 35", "Фамилия 35", "Отчество 35", 8, "Не в работе", "12345678935" },
                    { 36, 36, new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 36", "Фамилия 36", "Отчество 36", 17, "Не в работе", "12345678936" },
                    { 37, 37, new DateTime(1983, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 37", "Фамилия 37", "Отчество 37", 15, "Не в работе", "12345678937" },
                    { 38, 38, new DateTime(1983, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 38", "Фамилия 38", "Отчество 38", 8, "Не в работе", "12345678938" },
                    { 39, 39, new DateTime(1983, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 39", "Фамилия 39", "Отчество 39", 20, "Не в работе", "12345678939" },
                    { 40, 40, new DateTime(1983, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 40", "Фамилия 40", "Отчество 40", 1, "Не в работе", "12345678940" },
                    { 41, 41, new DateTime(1983, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 41", "Фамилия 41", "Отчество 41", 11, "Не в работе", "12345678941" },
                    { 42, 42, new DateTime(1983, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 42", "Фамилия 42", "Отчество 42", 19, "Не в работе", "12345678942" },
                    { 43, 43, new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 43", "Фамилия 43", "Отчество 43", 2, "Не в работе", "12345678943" },
                    { 44, 44, new DateTime(1983, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 44", "Фамилия 44", "Отчество 44", 4, "Не в работе", "12345678944" },
                    { 45, 45, new DateTime(1983, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 45", "Фамилия 45", "Отчество 45", 4, "Не в работе", "12345678945" },
                    { 46, 46, new DateTime(1983, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 46", "Фамилия 46", "Отчество 46", 3, "Не в работе", "12345678946" },
                    { 47, 47, new DateTime(1983, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 47", "Фамилия 47", "Отчество 47", 19, "Не в работе", "12345678947" },
                    { 48, 48, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 48", "Фамилия 48", "Отчество 48", 14, "Не в работе", "12345678948" },
                    { 49, 49, new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 49", "Фамилия 49", "Отчество 49", 5, "Не в работе", "12345678949" },
                    { 50, 50, new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 50", "Фамилия 50", "Отчество 50", 7, "Не в работе", "12345678950" },
                    { 51, 51, new DateTime(1984, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 51", "Фамилия 51", "Отчество 51", 7, "Не в работе", "12345678951" },
                    { 52, 52, new DateTime(1984, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 52", "Фамилия 52", "Отчество 52", 15, "Не в работе", "12345678952" },
                    { 53, 53, new DateTime(1984, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 53", "Фамилия 53", "Отчество 53", 11, "Не в работе", "12345678953" },
                    { 54, 54, new DateTime(1984, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 54", "Фамилия 54", "Отчество 54", 13, "Не в работе", "12345678954" },
                    { 55, 55, new DateTime(1984, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 55", "Фамилия 55", "Отчество 55", 4, "Не в работе", "12345678955" },
                    { 56, 56, new DateTime(1984, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 56", "Фамилия 56", "Отчество 56", 10, "Не в работе", "12345678956" },
                    { 57, 57, new DateTime(1984, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 57", "Фамилия 57", "Отчество 57", 14, "Не в работе", "12345678957" },
                    { 58, 58, new DateTime(1984, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 58", "Фамилия 58", "Отчество 58", 9, "Не в работе", "12345678958" },
                    { 59, 59, new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 59", "Фамилия 59", "Отчество 59", 3, "Не в работе", "12345678959" },
                    { 60, 60, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 60", "Фамилия 60", "Отчество 60", 17, "Не в работе", "12345678960" },
                    { 61, 61, new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 61", "Фамилия 61", "Отчество 61", 2, "Не в работе", "12345678961" },
                    { 62, 62, new DateTime(1985, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 62", "Фамилия 62", "Отчество 62", 1, "Не в работе", "12345678962" },
                    { 63, 63, new DateTime(1985, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 63", "Фамилия 63", "Отчество 63", 14, "Не в работе", "12345678963" },
                    { 64, 64, new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 64", "Фамилия 64", "Отчество 64", 5, "Не в работе", "12345678964" },
                    { 65, 65, new DateTime(1985, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 65", "Фамилия 65", "Отчество 65", 14, "Не в работе", "12345678965" },
                    { 66, 66, new DateTime(1985, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 66", "Фамилия 66", "Отчество 66", 15, "Не в работе", "12345678966" },
                    { 67, 67, new DateTime(1985, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 67", "Фамилия 67", "Отчество 67", 5, "Не в работе", "12345678967" },
                    { 68, 68, new DateTime(1985, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 68", "Фамилия 68", "Отчество 68", 17, "Не в работе", "12345678968" },
                    { 69, 69, new DateTime(1985, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 69", "Фамилия 69", "Отчество 69", 10, "Не в работе", "12345678969" },
                    { 70, 70, new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 70", "Фамилия 70", "Отчество 70", 6, "Не в работе", "12345678970" },
                    { 71, 71, new DateTime(1985, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 71", "Фамилия 71", "Отчество 71", 2, "Не в работе", "12345678971" },
                    { 72, 72, new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 72", "Фамилия 72", "Отчество 72", 5, "Не в работе", "12345678972" },
                    { 73, 73, new DateTime(1986, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 73", "Фамилия 73", "Отчество 73", 11, "Не в работе", "12345678973" },
                    { 74, 74, new DateTime(1986, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 74", "Фамилия 74", "Отчество 74", 6, "Не в работе", "12345678974" },
                    { 75, 75, new DateTime(1986, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 75", "Фамилия 75", "Отчество 75", 12, "Не в работе", "12345678975" },
                    { 76, 76, new DateTime(1986, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 76", "Фамилия 76", "Отчество 76", 8, "Не в работе", "12345678976" },
                    { 77, 77, new DateTime(1986, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 77", "Фамилия 77", "Отчество 77", 2, "Не в работе", "12345678977" },
                    { 78, 78, new DateTime(1986, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 78", "Фамилия 78", "Отчество 78", 13, "Не в работе", "12345678978" },
                    { 79, 79, new DateTime(1986, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 79", "Фамилия 79", "Отчество 79", 18, "Не в работе", "12345678979" },
                    { 80, 80, new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 80", "Фамилия 80", "Отчество 80", 18, "Не в работе", "12345678980" },
                    { 81, 81, new DateTime(1986, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 81", "Фамилия 81", "Отчество 81", 10, "Не в работе", "12345678981" },
                    { 82, 82, new DateTime(1986, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 82", "Фамилия 82", "Отчество 82", 4, "Не в работе", "12345678982" },
                    { 83, 83, new DateTime(1986, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 83", "Фамилия 83", "Отчество 83", 2, "Не в работе", "12345678983" },
                    { 84, 84, new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 84", "Фамилия 84", "Отчество 84", 11, "Не в работе", "12345678984" },
                    { 85, 85, new DateTime(1987, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 85", "Фамилия 85", "Отчество 85", 14, "Не в работе", "12345678985" },
                    { 86, 86, new DateTime(1987, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 86", "Фамилия 86", "Отчество 86", 12, "Не в работе", "12345678986" },
                    { 87, 87, new DateTime(1987, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 87", "Фамилия 87", "Отчество 87", 8, "Не в работе", "12345678987" },
                    { 88, 88, new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 88", "Фамилия 88", "Отчество 88", 19, "Не в работе", "12345678988" },
                    { 89, 89, new DateTime(1987, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 89", "Фамилия 89", "Отчество 89", 4, "Не в работе", "12345678989" },
                    { 90, 90, new DateTime(1987, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 90", "Фамилия 90", "Отчество 90", 19, "Не в работе", "12345678990" },
                    { 91, 91, new DateTime(1987, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 91", "Фамилия 91", "Отчество 91", 6, "Не в работе", "12345678991" },
                    { 92, 92, new DateTime(1987, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 92", "Фамилия 92", "Отчество 92", 17, "Не в работе", "12345678992" },
                    { 93, 93, new DateTime(1987, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 93", "Фамилия 93", "Отчество 93", 16, "Не в работе", "12345678993" },
                    { 94, 94, new DateTime(1987, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 94", "Фамилия 94", "Отчество 94", 4, "Не в работе", "12345678994" },
                    { 95, 95, new DateTime(1987, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 95", "Фамилия 95", "Отчество 95", 19, "Не в работе", "12345678995" },
                    { 96, 96, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 96", "Фамилия 96", "Отчество 96", 15, "Не в работе", "12345678996" },
                    { 97, 97, new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 97", "Фамилия 97", "Отчество 97", 15, "Не в работе", "12345678997" },
                    { 98, 98, new DateTime(1988, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 98", "Фамилия 98", "Отчество 98", 5, "Не в работе", "12345678998" },
                    { 99, 99, new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 99", "Фамилия 99", "Отчество 99", 2, "Не в работе", "12345678999" },
                    { 100, 100, new DateTime(1988, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 100", "Фамилия 100", "Отчество 100", 19, "Не в работе", "123456789100" },
                    { 101, 101, new DateTime(1988, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 101", "Фамилия 101", "Отчество 101", 2, "Не в работе", "123456789101" },
                    { 102, 102, new DateTime(1988, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 102", "Фамилия 102", "Отчество 102", 15, "Не в работе", "123456789102" },
                    { 103, 103, new DateTime(1988, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 103", "Фамилия 103", "Отчество 103", 3, "Не в работе", "123456789103" },
                    { 104, 104, new DateTime(1988, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 104", "Фамилия 104", "Отчество 104", 17, "Не в работе", "123456789104" },
                    { 105, 105, new DateTime(1988, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 105", "Фамилия 105", "Отчество 105", 12, "Не в работе", "123456789105" },
                    { 106, 106, new DateTime(1988, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 106", "Фамилия 106", "Отчество 106", 1, "Не в работе", "123456789106" },
                    { 107, 107, new DateTime(1988, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 107", "Фамилия 107", "Отчество 107", 5, "Не в работе", "123456789107" },
                    { 108, 108, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 108", "Фамилия 108", "Отчество 108", 9, "Не в работе", "123456789108" },
                    { 109, 109, new DateTime(1989, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 109", "Фамилия 109", "Отчество 109", 11, "Не в работе", "123456789109" },
                    { 110, 110, new DateTime(1989, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 110", "Фамилия 110", "Отчество 110", 6, "Не в работе", "123456789110" },
                    { 111, 111, new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 111", "Фамилия 111", "Отчество 111", 15, "Не в работе", "123456789111" },
                    { 112, 112, new DateTime(1989, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 112", "Фамилия 112", "Отчество 112", 15, "Не в работе", "123456789112" },
                    { 113, 113, new DateTime(1989, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 113", "Фамилия 113", "Отчество 113", 20, "Не в работе", "123456789113" },
                    { 114, 114, new DateTime(1989, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 114", "Фамилия 114", "Отчество 114", 10, "Не в работе", "123456789114" },
                    { 115, 115, new DateTime(1989, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 115", "Фамилия 115", "Отчество 115", 11, "Не в работе", "123456789115" },
                    { 116, 116, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 116", "Фамилия 116", "Отчество 116", 12, "Не в работе", "123456789116" },
                    { 117, 117, new DateTime(1989, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 117", "Фамилия 117", "Отчество 117", 9, "Не в работе", "123456789117" },
                    { 118, 118, new DateTime(1989, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 118", "Фамилия 118", "Отчество 118", 12, "Не в работе", "123456789118" },
                    { 119, 119, new DateTime(1989, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 119", "Фамилия 119", "Отчество 119", 11, "Не в работе", "123456789119" },
                    { 120, 120, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 120", "Фамилия 120", "Отчество 120", 18, "Не в работе", "123456789120" },
                    { 121, 121, new DateTime(1990, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 121", "Фамилия 121", "Отчество 121", 18, "Не в работе", "123456789121" },
                    { 122, 122, new DateTime(1990, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 122", "Фамилия 122", "Отчество 122", 19, "Не в работе", "123456789122" },
                    { 123, 123, new DateTime(1990, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 123", "Фамилия 123", "Отчество 123", 9, "Не в работе", "123456789123" },
                    { 124, 124, new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 124", "Фамилия 124", "Отчество 124", 14, "Не в работе", "123456789124" },
                    { 125, 125, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 125", "Фамилия 125", "Отчество 125", 16, "Не в работе", "123456789125" },
                    { 126, 126, new DateTime(1990, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 126", "Фамилия 126", "Отчество 126", 3, "Не в работе", "123456789126" },
                    { 127, 127, new DateTime(1990, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 127", "Фамилия 127", "Отчество 127", 11, "Не в работе", "123456789127" },
                    { 128, 128, new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 128", "Фамилия 128", "Отчество 128", 13, "Не в работе", "123456789128" },
                    { 129, 129, new DateTime(1990, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 129", "Фамилия 129", "Отчество 129", 3, "Не в работе", "123456789129" },
                    { 130, 130, new DateTime(1990, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 130", "Фамилия 130", "Отчество 130", 8, "Не в работе", "123456789130" },
                    { 131, 131, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 131", "Фамилия 131", "Отчество 131", 7, "Не в работе", "123456789131" },
                    { 132, 132, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 132", "Фамилия 132", "Отчество 132", 12, "Не в работе", "123456789132" },
                    { 133, 133, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 133", "Фамилия 133", "Отчество 133", 7, "Не в работе", "123456789133" },
                    { 134, 134, new DateTime(1991, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 134", "Фамилия 134", "Отчество 134", 2, "Не в работе", "123456789134" },
                    { 135, 135, new DateTime(1991, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 135", "Фамилия 135", "Отчество 135", 3, "Не в работе", "123456789135" },
                    { 136, 136, new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 136", "Фамилия 136", "Отчество 136", 15, "Не в работе", "123456789136" },
                    { 137, 137, new DateTime(1991, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 137", "Фамилия 137", "Отчество 137", 4, "Не в работе", "123456789137" },
                    { 138, 138, new DateTime(1991, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 138", "Фамилия 138", "Отчество 138", 4, "Не в работе", "123456789138" },
                    { 139, 139, new DateTime(1991, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 139", "Фамилия 139", "Отчество 139", 7, "Не в работе", "123456789139" },
                    { 140, 140, new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 140", "Фамилия 140", "Отчество 140", 1, "Не в работе", "123456789140" },
                    { 141, 141, new DateTime(1991, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 141", "Фамилия 141", "Отчество 141", 16, "Не в работе", "123456789141" },
                    { 142, 142, new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 142", "Фамилия 142", "Отчество 142", 12, "Не в работе", "123456789142" },
                    { 143, 143, new DateTime(1991, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 143", "Фамилия 143", "Отчество 143", 17, "Не в работе", "123456789143" },
                    { 144, 144, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 144", "Фамилия 144", "Отчество 144", 15, "Не в работе", "123456789144" },
                    { 145, 145, new DateTime(1992, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 145", "Фамилия 145", "Отчество 145", 19, "Не в работе", "123456789145" },
                    { 146, 146, new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 146", "Фамилия 146", "Отчество 146", 9, "Не в работе", "123456789146" },
                    { 147, 147, new DateTime(1992, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 147", "Фамилия 147", "Отчество 147", 4, "Не в работе", "123456789147" },
                    { 148, 148, new DateTime(1992, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 148", "Фамилия 148", "Отчество 148", 19, "Не в работе", "123456789148" },
                    { 149, 149, new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 149", "Фамилия 149", "Отчество 149", 2, "Не в работе", "123456789149" },
                    { 150, 150, new DateTime(1992, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 150", "Фамилия 150", "Отчество 150", 15, "Не в работе", "123456789150" },
                    { 151, 151, new DateTime(1992, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 151", "Фамилия 151", "Отчество 151", 20, "Не в работе", "123456789151" },
                    { 152, 152, new DateTime(1992, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 152", "Фамилия 152", "Отчество 152", 13, "Не в работе", "123456789152" },
                    { 153, 153, new DateTime(1992, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 153", "Фамилия 153", "Отчество 153", 19, "Не в работе", "123456789153" },
                    { 154, 154, new DateTime(1992, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 154", "Фамилия 154", "Отчество 154", 4, "Не в работе", "123456789154" },
                    { 155, 155, new DateTime(1992, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 155", "Фамилия 155", "Отчество 155", 12, "Не в работе", "123456789155" },
                    { 156, 156, new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 156", "Фамилия 156", "Отчество 156", 18, "Не в работе", "123456789156" },
                    { 157, 157, new DateTime(1993, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 157", "Фамилия 157", "Отчество 157", 5, "Не в работе", "123456789157" },
                    { 158, 158, new DateTime(1993, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 158", "Фамилия 158", "Отчество 158", 17, "Не в работе", "123456789158" },
                    { 159, 159, new DateTime(1993, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 159", "Фамилия 159", "Отчество 159", 1, "Не в работе", "123456789159" },
                    { 160, 160, new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 160", "Фамилия 160", "Отчество 160", 19, "Не в работе", "123456789160" },
                    { 161, 161, new DateTime(1993, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 161", "Фамилия 161", "Отчество 161", 8, "Не в работе", "123456789161" },
                    { 162, 162, new DateTime(1993, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 162", "Фамилия 162", "Отчество 162", 16, "Не в работе", "123456789162" },
                    { 163, 163, new DateTime(1993, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 163", "Фамилия 163", "Отчество 163", 14, "Не в работе", "123456789163" },
                    { 164, 164, new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 164", "Фамилия 164", "Отчество 164", 16, "Не в работе", "123456789164" },
                    { 165, 165, new DateTime(1993, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 165", "Фамилия 165", "Отчество 165", 16, "Не в работе", "123456789165" },
                    { 166, 166, new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 166", "Фамилия 166", "Отчество 166", 19, "Не в работе", "123456789166" },
                    { 167, 167, new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 167", "Фамилия 167", "Отчество 167", 14, "Не в работе", "123456789167" },
                    { 168, 168, new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 168", "Фамилия 168", "Отчество 168", 18, "Не в работе", "123456789168" },
                    { 169, 169, new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 169", "Фамилия 169", "Отчество 169", 9, "Не в работе", "123456789169" },
                    { 170, 170, new DateTime(1994, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 170", "Фамилия 170", "Отчество 170", 15, "Не в работе", "123456789170" },
                    { 171, 171, new DateTime(1994, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 171", "Фамилия 171", "Отчество 171", 4, "Не в работе", "123456789171" },
                    { 172, 172, new DateTime(1994, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 172", "Фамилия 172", "Отчество 172", 9, "Не в работе", "123456789172" },
                    { 173, 173, new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 173", "Фамилия 173", "Отчество 173", 16, "Не в работе", "123456789173" },
                    { 174, 174, new DateTime(1994, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 174", "Фамилия 174", "Отчество 174", 7, "Не в работе", "123456789174" },
                    { 175, 175, new DateTime(1994, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 175", "Фамилия 175", "Отчество 175", 19, "Не в работе", "123456789175" },
                    { 176, 176, new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 176", "Фамилия 176", "Отчество 176", 11, "Не в работе", "123456789176" },
                    { 177, 177, new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 177", "Фамилия 177", "Отчество 177", 11, "Не в работе", "123456789177" },
                    { 178, 178, new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 178", "Фамилия 178", "Отчество 178", 5, "Не в работе", "123456789178" },
                    { 179, 179, new DateTime(1994, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 179", "Фамилия 179", "Отчество 179", 4, "Не в работе", "123456789179" },
                    { 180, 180, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 180", "Фамилия 180", "Отчество 180", 19, "Не в работе", "123456789180" },
                    { 181, 181, new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 181", "Фамилия 181", "Отчество 181", 4, "Не в работе", "123456789181" },
                    { 182, 182, new DateTime(1995, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 182", "Фамилия 182", "Отчество 182", 9, "Не в работе", "123456789182" },
                    { 183, 183, new DateTime(1995, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 183", "Фамилия 183", "Отчество 183", 8, "Не в работе", "123456789183" },
                    { 184, 184, new DateTime(1995, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 184", "Фамилия 184", "Отчество 184", 13, "Не в работе", "123456789184" },
                    { 185, 185, new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 185", "Фамилия 185", "Отчество 185", 19, "Не в работе", "123456789185" },
                    { 186, 186, new DateTime(1995, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 186", "Фамилия 186", "Отчество 186", 5, "Не в работе", "123456789186" },
                    { 187, 187, new DateTime(1995, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 187", "Фамилия 187", "Отчество 187", 1, "Не в работе", "123456789187" },
                    { 188, 188, new DateTime(1995, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 188", "Фамилия 188", "Отчество 188", 1, "Не в работе", "123456789188" },
                    { 189, 189, new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 189", "Фамилия 189", "Отчество 189", 4, "Не в работе", "123456789189" },
                    { 190, 190, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 190", "Фамилия 190", "Отчество 190", 1, "Не в работе", "123456789190" },
                    { 191, 191, new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 191", "Фамилия 191", "Отчество 191", 15, "Не в работе", "123456789191" },
                    { 192, 192, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 192", "Фамилия 192", "Отчество 192", 5, "Не в работе", "123456789192" },
                    { 193, 193, new DateTime(1996, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 193", "Фамилия 193", "Отчество 193", 14, "Не в работе", "123456789193" },
                    { 194, 194, new DateTime(1996, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 194", "Фамилия 194", "Отчество 194", 2, "Не в работе", "123456789194" },
                    { 195, 195, new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 195", "Фамилия 195", "Отчество 195", 18, "Не в работе", "123456789195" },
                    { 196, 196, new DateTime(1996, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 196", "Фамилия 196", "Отчество 196", 15, "Не в работе", "123456789196" },
                    { 197, 197, new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 197", "Фамилия 197", "Отчество 197", 16, "Не в работе", "123456789197" },
                    { 198, 198, new DateTime(1996, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 198", "Фамилия 198", "Отчество 198", 7, "Не в работе", "123456789198" },
                    { 199, 199, new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 199", "Фамилия 199", "Отчество 199", 19, "Не в работе", "123456789199" },
                    { 200, 200, new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Имя 200", "Фамилия 200", "Отчество 200", 6, "Не в работе", "123456789200" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ResponsiblePersonId",
                table: "Clients",
                column: "ResponsiblePersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
