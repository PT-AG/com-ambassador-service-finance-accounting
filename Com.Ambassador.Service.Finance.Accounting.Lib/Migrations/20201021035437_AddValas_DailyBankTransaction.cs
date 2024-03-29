﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Migrations
{
    public partial class AddValas_DailyBankTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AfterNominalValas",
                table: "DailyBankTransactions",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BeforeNominalValas",
                table: "DailyBankTransactions",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NominalValas",
                table: "DailyBankTransactions",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AfterNominalValas",
                table: "DailyBankTransactions");

            migrationBuilder.DropColumn(
                name: "BeforeNominalValas",
                table: "DailyBankTransactions");

            migrationBuilder.DropColumn(
                name: "NominalValas",
                table: "DailyBankTransactions");
        }
    }
}
