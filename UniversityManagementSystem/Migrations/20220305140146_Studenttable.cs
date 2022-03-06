﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityManagementSystem.Migrations
{
    public partial class Studenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TodoItemId",
                table: "TodoItems",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TodoItems",
                newName: "TodoItemId");
        }
    }
}
