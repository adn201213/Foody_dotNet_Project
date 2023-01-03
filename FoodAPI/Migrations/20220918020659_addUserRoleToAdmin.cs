using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodAPI.Migrations
{
    public partial class addUserRoleToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "efb84fee-c9e0-4a63-9327-283fdf40b3c2", "cd2e8c5a-e918-49a4-8c37-e90b2d0b38a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96b2524a-0f82-43f0-b10e-9c867b02cdbe", "f9018c34-1f9a-498e-9d1f-8b475ca1353c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b2524a-0f82-43f0-b10e-9c867b02cdbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efb84fee-c9e0-4a63-9327-283fdf40b3c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd2e8c5a-e918-49a4-8c37-e90b2d0b38a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9018c34-1f9a-498e-9d1f-8b475ca1353c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6986c43a-78ff-4825-a1d7-da634259e913", "10698375-4b6c-4b45-9d78-d7c663acf0cb", "Admin", "ADMIN" },
                    { "cf8e5237-4dee-4db4-b26e-1948acff19af", "1a78a70e-ef36-4c35-9f66-f088c26362e4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "35a05032-f96a-434a-bb49-d87fe15c9b6d", 0, "cf63ff0c-444a-4ae2-9928-d71e831106a5", "adnan@hotmail.com", false, false, null, "ADNAN@HOTMAIL.COM", "ADNAN@HOTMAIL.COM", "AQAAAAEAACcQAAAAEA2Bz16sv9oWxHLkW1n+/GrCjRp/uh5GiTwgzrKjys2rQfgLPZ/rqRNWWqa0jXnsRQ==", null, false, "fd825ac9-35dc-4674-b718-e9a51f4937d3", false, "adnan@hotmail.com" },
                    { "afb56f6c-fe49-4909-a208-cf98d79f2e3f", 0, "0028da81-d242-4ebd-8472-4d6d9817cdd1", "admin@hotmail.com", false, false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAEAACcQAAAAELTR+AhxOSZoqzGQh+cYv7X5GP8yRLd2L3zj9Rp6nr9vTos24RXpZC75qPNwBGs9MQ==", null, false, "b8029325-17ff-425a-88d4-7c292b41819c", false, "admin@hotmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 17, 22, 6, 59, 279, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cf8e5237-4dee-4db4-b26e-1948acff19af", "35a05032-f96a-434a-bb49-d87fe15c9b6d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6986c43a-78ff-4825-a1d7-da634259e913", "afb56f6c-fe49-4909-a208-cf98d79f2e3f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cf8e5237-4dee-4db4-b26e-1948acff19af", "afb56f6c-fe49-4909-a208-cf98d79f2e3f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf8e5237-4dee-4db4-b26e-1948acff19af", "35a05032-f96a-434a-bb49-d87fe15c9b6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6986c43a-78ff-4825-a1d7-da634259e913", "afb56f6c-fe49-4909-a208-cf98d79f2e3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf8e5237-4dee-4db4-b26e-1948acff19af", "afb56f6c-fe49-4909-a208-cf98d79f2e3f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6986c43a-78ff-4825-a1d7-da634259e913");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8e5237-4dee-4db4-b26e-1948acff19af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35a05032-f96a-434a-bb49-d87fe15c9b6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afb56f6c-fe49-4909-a208-cf98d79f2e3f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96b2524a-0f82-43f0-b10e-9c867b02cdbe", "b77c4e17-ad4c-45b4-856f-8bdf82873538", "User", "USER" },
                    { "efb84fee-c9e0-4a63-9327-283fdf40b3c2", "698ca80c-a77d-4e40-b80e-b7e6a69e920c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cd2e8c5a-e918-49a4-8c37-e90b2d0b38a5", 0, "7814f13e-ada6-4998-96eb-b072d15a6e24", "admin@hotmail.com", false, false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAEAACcQAAAAELyQVO07m616MOFAqTAconszeHlsTHF9r8pvoEqzf+ZirM8gCgID4YsAiwqWv8xJCQ==", null, false, "a5716a15-b6ef-45e4-8df0-d5950cf65986", false, "admin@hotmail.com" },
                    { "f9018c34-1f9a-498e-9d1f-8b475ca1353c", 0, "80fd5fae-024e-483e-a8bc-5fd703742d74", "adnan@hotmail.com", false, false, null, "ADNAN@HOTMAIL.COM", "ADNAN@HOTMAIL.COM", "AQAAAAEAACcQAAAAEE9+AGmJGhHrLkg+70c/FKxGdbG3XSh6owEOcFuOLGjRD0uINU2oGjI8OCxxUC9+Kw==", null, false, "22a36467-4061-4711-83a4-951244e9a9d4", false, "adnan@hotmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 16, 12, 33, 45, 349, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "efb84fee-c9e0-4a63-9327-283fdf40b3c2", "cd2e8c5a-e918-49a4-8c37-e90b2d0b38a5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "96b2524a-0f82-43f0-b10e-9c867b02cdbe", "f9018c34-1f9a-498e-9d1f-8b475ca1353c" });
        }
    }
}
