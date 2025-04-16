using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("156a3d18-71e7-4f78-a524-bbb42594bda7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5e0edaa-ad1d-455c-afba-9d005c8f5593"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Hobby", "Mail", "PhoneNumber", "Skillsets", "Username" },
                values: new object[,]
                {
                    { new Guid("0934de1b-0147-4acc-90e5-4b26789595ef"), "Singing", "charlotte.clark@gmail.com", "0177890123", "Figma, UI Design", "Charlotte Clark" },
                    { new Guid("0ec1ebdb-5d63-4594-8d8e-ccb5c5005ad4"), "Traveling", "sophia.martin@gmail.com", "0189012345", "Swift, iOS Development", "Sophia Martin" },
                    { new Guid("11ea1418-266c-416c-b2f8-74e03cf13f91"), "Painting", "ava.anderson@gmail.com", "0111234567", "HTML, CSS, UX Design", "Ava Anderson" },
                    { new Guid("12e994d5-b6dc-4f3e-80a0-8781577749a2"), "Cycling", "michael.johnson@gmail.com", "0134567890", "Python, Django, Flask", "Michael Johnson" },
                    { new Guid("1c3fb62d-d897-4516-ba10-5374bb2556a5"), "3D Modeling", "william.lee@gmail.com", "0178901234", "C++, Unreal Engine", "William Lee" },
                    { new Guid("3a3a69b1-8c50-4d14-b7de-b555e4f94057"), "Origami", "evelyn.green@gmail.com", "0121234567", "AI, LLMs, OpenAI API", "Evelyn Green" },
                    { new Guid("433a1995-f666-420f-aba3-a1dce486d12f"), "Yoga", "amelia.king@gmail.com", "0199012345", "SQL, ETL, Data Warehousing", "Amelia King" },
                    { new Guid("664244ba-adaa-4a11-aaa6-11b5b7339934"), "Chess", "benjamin.thomas@gmail.com", "0122345678", "Python, Pandas, NumPy", "Benjamin Thomas" },
                    { new Guid("6baf8e1c-84e9-4a2f-a3b3-bce5ebee2d10"), "Running", "alexander.young@gmail.com", "0188901234", "Machine Learning, TensorFlow", "Alexander Young" },
                    { new Guid("70381b5f-e909-4f3e-b8cb-870d13d01773"), "Hiking", "olivia.brown@gmail.com", "0167890123", "Ruby, Rails, PostgreSQL", "Olivia Brown" },
                    { new Guid("9c18f628-def7-49a8-93a3-808516c6052c"), "Trekking", "henry.scott@gmail.com", "0110123456", "Bash, Linux, Ansible", "Henry Scott" },
                    { new Guid("9cf9c3d2-e868-45fc-b20e-551c0a7d60f2"), "Gaming", "john.doe@gmail.com", "0112345678", "C#, ASP.NET, EF Core", "John Doe" },
                    { new Guid("9f89b5c7-88ee-411d-99f1-b26e2c085c4f"), "Drawing", "isabella.harris@gmail.com", "0155678901", "Android, Kotlin, Jetpack", "Isabella Harris" },
                    { new Guid("ad361799-b933-4645-ac1e-862662323818"), "Writing", "mia.jackson@gmail.com", "0133456789", "R, Data Analysis", "Mia Jackson" },
                    { new Guid("b0517b81-9e6c-4854-b5dc-6b68511f49dd"), "Board Games", "ethan.lewis@gmail.com", "0166789012", "Unity, Game Dev, C#", "Ethan Lewis" },
                    { new Guid("b4971baa-da7f-4e97-b80b-97e8ed7d01bf"), "Skiing", "logan.white@gmail.com", "0144567890", "Scala, Akka, Kafka", "Logan White" },
                    { new Guid("bfe1daf4-a6f3-43fc-baef-9afd26f033bd"), "Fishing", "james.taylor@gmail.com", "0190123456", "PHP, Laravel, MySQL", "James Taylor" },
                    { new Guid("c07d6737-993c-4963-a6c4-895e4a2cd62e"), "Photography", "emily.davis@gmail.com", "0145678901", "Java, Spring Boot", "Emily Davis" },
                    { new Guid("d4068753-8e00-495d-8c61-82dc5206c4fe"), "Reading", "jane.smith@gmail.com", "0123456789", "JavaScript, React, Node.js", "Jane Smith" },
                    { new Guid("e5469a76-e9d5-4815-97a3-e12c7c087aca"), "Cooking", "daniel.wilson@gmail.com", "0156789012", "Go, Kubernetes, Docker", "Daniel Wilson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0934de1b-0147-4acc-90e5-4b26789595ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ec1ebdb-5d63-4594-8d8e-ccb5c5005ad4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11ea1418-266c-416c-b2f8-74e03cf13f91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12e994d5-b6dc-4f3e-80a0-8781577749a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c3fb62d-d897-4516-ba10-5374bb2556a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a3a69b1-8c50-4d14-b7de-b555e4f94057"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("433a1995-f666-420f-aba3-a1dce486d12f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("664244ba-adaa-4a11-aaa6-11b5b7339934"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6baf8e1c-84e9-4a2f-a3b3-bce5ebee2d10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70381b5f-e909-4f3e-b8cb-870d13d01773"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c18f628-def7-49a8-93a3-808516c6052c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cf9c3d2-e868-45fc-b20e-551c0a7d60f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f89b5c7-88ee-411d-99f1-b26e2c085c4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad361799-b933-4645-ac1e-862662323818"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0517b81-9e6c-4854-b5dc-6b68511f49dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4971baa-da7f-4e97-b80b-97e8ed7d01bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfe1daf4-a6f3-43fc-baef-9afd26f033bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c07d6737-993c-4963-a6c4-895e4a2cd62e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4068753-8e00-495d-8c61-82dc5206c4fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5469a76-e9d5-4815-97a3-e12c7c087aca"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Hobby", "Mail", "PhoneNumber", "Skillsets", "Username" },
                values: new object[,]
                {
                    { new Guid("156a3d18-71e7-4f78-a524-bbb42594bda7"), "Gaming", "john@example.com", "0123456789", "C#, ASP.NET, EF Core", "johndoe" },
                    { new Guid("c5e0edaa-ad1d-455c-afba-9d005c8f5593"), "Reading", "jane@example.com", "0987654321", "JavaScript, React, Node.js", "janedoe" }
                });
        }
    }
}
