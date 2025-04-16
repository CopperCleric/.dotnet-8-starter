using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Mail = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Skillsets = table.Column<string>(type: "text", nullable: false),
                    Hobby = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Hobby", "Mail", "PhoneNumber", "Skillsets", "Username" },
                values: new object[,]
                {
                    { new Guid("156a3d18-71e7-4f78-a524-bbb42594bda7"), "Gaming", "john@example.com", "0123456789", "C#, ASP.NET, EF Core", "johndoe" },
                    { new Guid("c5e0edaa-ad1d-455c-afba-9d005c8f5593"), "Reading", "jane@example.com", "0987654321", "JavaScript, React, Node.js", "janedoe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
