using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterSheetApp.Migrations
{
    public partial class AddedQuestsToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.Name);
                });

            migrationBuilder.AddColumn<string>(
                name: "QuestName",
                table: "Character",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Character_QuestName",
                table: "Character",
                column: "QuestName");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Quest_QuestName",
                table: "Character",
                column: "QuestName",
                principalTable: "Quest",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Quest_QuestName",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_QuestName",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "QuestName",
                table: "Character");

            migrationBuilder.DropTable(
                name: "Quest");
        }
    }
}
