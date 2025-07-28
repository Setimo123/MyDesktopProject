using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBulletin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Bulletin");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Bulletin",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Notify",
                table: "Bulletin",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Bulletin",
                newName: "Author");

            migrationBuilder.AddColumn<int>(
                name: "FileCount",
                table: "Bulletin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Bulletin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK66GBaX1ZQQQY/nxePmZC1q3bNlpYfRl2M7QZmhcoxrARt9FyTi8FoJPtbW0PoWag==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAAqQGaHJXXN46TeDwbQLUtkvVDjI7kVDIahtR5PHrJEVodd9R/41teaUFI9vmFTuQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKUMXRs6fJQ46UWXRizzWBIZRhpiE5T9isRW4nNgI8zW9auZp1vv0vU7PLN4KsPUNw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA7Ejx6Zj4Vyjx0naaasmedM4hnD+LYhVly+p3evaDDd4bnBy5/6teF+WsB2Y058Rw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA1psdGN8yfMFuu61A5/VG76i88j77akEzu9b0XbyetHqgBA7Qrc6FPHuuvOkprlLw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENDgMgm79k/9K4DCiHnUOVkbqLil2GvTuS6Jj7pKXnQF1DowacT6RxApJIlkD3hsfQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOOQ9m8VnD7q9gLVD/H0ssG8/Xq+LIhjLxLka65MgT+8PKRMR0kNLuVlw4pHe7edQQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBeW0J+4dSLVbSJ3NawL3evLQVeVUhYffVj8ANYxToNEb9pShkhvCHe43K8Vq7Q/bA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D81B4D15-B3CD-47D5-96B0-44EF8E39E538",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO0tVXi9wUb3Ip6wfQ+ZG7x518GUmHwb5o37WQA6Ys9aPODjA90RG6lBmaj6oZYHfQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileCount",
                table: "Bulletin");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Bulletin");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Bulletin",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Bulletin",
                newName: "Notify");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Bulletin",
                newName: "ImageURL");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAVAEqV72+ZFyAw1KDTEEraYAmTS9jt6b8CSqC44CS44TDv7gvLKHx9JTlO8LiqOjg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIXHwLC5rbD+QFlhkiX3GegA/I3ie3XwzdpMdhf9joNmoY/uCMeNxUEcthsf98eMPw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELvaSnIaY5T4jX4VHDJQWSrkgxaUNJZwTXvcsj1MtVHrSS5UbD9nS97lOV/DLZ4DHQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMcHj5emonJNto/90XwkzePiJbQ4FuNWX3LKFqDdsmGn/XXAZdRP6XUbX926dApmKw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGyX791QakurY+O+WT98ceyl0BpT3CicN5IFgfv+WB+v9LrUy69G3t8JaJ0vpA3Sjg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECHXe7Ktkuh8mcth7E7+c5hi3LJN4uuzEEXgaCF3oNLG3nJRlvyjX6v11mHCCcY9AQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKOeJ9TJ9KB+1HivDPurwV5z+anjdllysnP+IyhJhZx1xvTnavWVistDpUa4LAvr2Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGHKGylFLpr13vh+CrxQqy3GvEqTM5ghSXaHUW/aX2qvZba9/fKZSi3j0vpSd2Urgw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D81B4D15-B3CD-47D5-96B0-44EF8E39E538",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELAfuOFr7lXT7OzfMW0kqIkniRpFzbj50gd72Lcz9Z4MDZfPYKa7UyDqCSferwvQMw==");
        }
    }
}
