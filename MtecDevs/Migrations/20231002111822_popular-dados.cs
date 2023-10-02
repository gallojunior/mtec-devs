using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtecDevs.Migrations
{
    public partial class populardados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e0ff3a8-7b10-419e-a4d3-f1e90f3b7244", "5f22bde7-a70f-4b89-be3e-85197936dc29", "Administrador", "ADMINISTRADOR" },
                    { "5ea0d48a-c3d0-43ae-8b7e-c6042e8176ea", "f19cbec4-fe9b-4a83-a400-50509f633d37", "Usuário", "USUÁRIO" },
                    { "f194d8e5-cba6-43c4-a868-3c9d7aab6e1f", "0b01fffd-8d61-42fc-b639-3e4530053c64", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73142e54-9cac-4afa-8ab4-c5d3b914b4d8", 0, "36f63ded-1aa8-45f9-81ce-657bdcf246f5", "gallojunior@gmail.com", true, false, null, "GALLOJUNIOR@GMAIL.COM", "GALLOJUNIOR", "AQAAAAEAACcQAAAAECZ11BoDYxkzMMmavSY4d0EP+VWZxr73E0ozQbhaNDuqJ+BMR6M0lFioj8StwYzFKQ==", "14912345678", true, "a15d4341-4553-4239-a607-3d072e4b018b", false, "GalloJunior" });

            migrationBuilder.InsertData(
                table: "TipoDev",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "FullStack" },
                    { (byte)2, "FrontEnd" },
                    { (byte)3, "BackEnd" },
                    { (byte)4, "Design" },
                    { (byte)5, "Jogos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3e0ff3a8-7b10-419e-a4d3-f1e90f3b7244", "73142e54-9cac-4afa-8ab4-c5d3b914b4d8" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UserId", "DataNascimento", "Foto", "Nome", "TipoDevId" },
                values: new object[] { "73142e54-9cac-4afa-8ab4-c5d3b914b4d8", new DateTime(1981, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/avatar.png", "José Antonio Gallo Junior", (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ea0d48a-c3d0-43ae-8b7e-c6042e8176ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f194d8e5-cba6-43c4-a868-3c9d7aab6e1f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e0ff3a8-7b10-419e-a4d3-f1e90f3b7244", "73142e54-9cac-4afa-8ab4-c5d3b914b4d8" });

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UserId",
                keyValue: "73142e54-9cac-4afa-8ab4-c5d3b914b4d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e0ff3a8-7b10-419e-a4d3-f1e90f3b7244");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73142e54-9cac-4afa-8ab4-c5d3b914b4d8");

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)1);
        }
    }
}
