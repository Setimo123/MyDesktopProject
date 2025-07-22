using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminName", "UsersID" },
                values: new object[,]
                {
                    { 1, "Raine Isid", "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF" },
                    { 2, "Jiver Dejiga", "D81B4D15-B3CD-47D5-96B0-44EF8E39E538" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIQ5f3AAQ22yY1PPc4cqSEO7jtgquyo4XvBSuyz+XywbUs8iVDghfS7J94axAz7y1Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL8cDGQ3B8o7oBYa9qZD2Fbt1Lt5m8tj/OBMQ3glWsf5pgHI/3NmILsYrEkvzbT8yQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ3GO2CQknC+MtckyROMSweNNjZoYYRXI4llFimjZhEqQo6o3TZNoCAUdxIvTBIBTw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGe7FyXpryVbXueGdSuASBvTBL2Bdr16gfkDNiSDhaFslC8sFInvzxZPYcsjxox3/w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELKYPLnvoOHYbJK8gKvPDfzgn+xEldFrRCNkdOMwwmCmhq5L/qCXUHIOK37JSp8gig==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMh7t7lXwxLsULK/20Fqe0LcTz0/Ytq6Y8CfO2DKMLW7/o5krsiskw+gr4tzVjEt9A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED4WJyweJ6YXtPZ8GLeYoeYp/abIbDdxxz1SHeX4VToPLmDsI6iCTT+Q51waeiEJ9Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDbV1bXcr++YOnJpqbA8SA1C61ZW2BdRqfoGIc8i5RpJlCPsnPwrjtWcHTvpwN3MLw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D81B4D15-B3CD-47D5-96B0-44EF8E39E538",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDvOh4qZLToiypQcX/bCi/IVmUAb0rBA7CrkNhTMgGxp0N3S6MxPlLXrp+3PFtAeSA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA13VFRJuheb74k1qOobQnY7e2ZQuzwWIbm9x9Gfnt93qxXir52LdBydyFYSfUa0yw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDDDAS991YdmUZ9iKRc72p3S+HE2dxDnNaR2rgHQJYqjC8yNiRU6OhoMQHum39hOqA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDpyfjM4FmhZdH1829LzYga5W/6d12syFawhG28DTym2Jigpg2Ju7wIcQ/JXTFsVsA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH/dGBFHel0pgRD95aUhsHNmwdAK2o2mtAwD6Ot4kTfTdGmekTRqWyezWZTMy4ynKA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA5qozqVKGfzN6HM8hsMMKnC6lI99xIdWhCzPBTGyFdipvf5dBvJ9FZGNymgRueS3g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFnf7eWdux6gS0CEAhlzUKsAw6s/xDRilmK2b7KW42tijU5+ZxvRlDJThF6gbCYf2Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN2GopPyX338Z90BD16sejiD/+jfqinDyKF9DHZaLoSy7S47d+FQtKl0VAvR/KJorQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP6EdKMiBPGg4Kq1T4MVdjTz5plUPSz9NYzYHEBvPOBFyy1grFa+mtqosalU8sWTYw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D81B4D15-B3CD-47D5-96B0-44EF8E39E538",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMKl9QlNDWruKbtgyvhHL8G9ahEGoi5z1EpDS/yE3RbmTq2zZJOSHmKV9O3Rhg3c6Q==");
        }
    }
}
