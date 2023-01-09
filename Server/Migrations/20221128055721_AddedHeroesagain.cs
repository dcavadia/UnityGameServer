﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    public partial class AddedHeroesagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Health",
                table: "Hero");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hero",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hero");

            migrationBuilder.AddColumn<float>(
                name: "Health",
                table: "Hero",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
