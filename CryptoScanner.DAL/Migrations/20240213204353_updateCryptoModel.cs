using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoScanner.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateCryptoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usd_24H_Change",
                table: "Cryptos");

            migrationBuilder.DropColumn(
                name: "Usd_24H_Vhl",
                table: "Cryptos");

            migrationBuilder.DropColumn(
                name: "Usd_Market_Cap",
                table: "Cryptos");

            migrationBuilder.AlterColumn<double>(
                name: "Price_In_Usd",
                table: "Cryptos",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cryptos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "Ath",
                table: "Cryptos",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<double>(
                name: "Market_Cap_Rank",
                table: "Cryptos",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Usd_High_24H",
                table: "Cryptos",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Usd_Low_24H",
                table: "Cryptos",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Market_Cap_Rank",
                table: "Cryptos");

            migrationBuilder.DropColumn(
                name: "Usd_High_24H",
                table: "Cryptos");

            migrationBuilder.DropColumn(
                name: "Usd_Low_24H",
                table: "Cryptos");

            migrationBuilder.AlterColumn<double>(
                name: "Price_In_Usd",
                table: "Cryptos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cryptos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Ath",
                table: "Cryptos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Usd_24H_Change",
                table: "Cryptos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Usd_24H_Vhl",
                table: "Cryptos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Usd_Market_Cap",
                table: "Cryptos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
