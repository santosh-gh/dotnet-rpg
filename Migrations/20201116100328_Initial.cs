using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Role = table.Column<string>(nullable: false, defaultValue: "Player")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HitPoints = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Class = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Fights = table.Column<int>(nullable: false),
                    Victories = table.Column<int>(nullable: false),
                    Defeats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { 1, 30, "Fireball" },
                    { 2, 20, "Frenzy" },
                    { 3, 50, "Blizzard" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[,]
                {
                    { 1, new byte[] { 154, 30, 12, 167, 43, 250, 53, 83, 219, 52, 10, 199, 98, 100, 187, 149, 73, 171, 248, 217, 40, 245, 134, 237, 108, 176, 96, 148, 240, 139, 123, 131, 138, 92, 209, 204, 128, 92, 41, 159, 26, 224, 49, 94, 101, 105, 48, 61, 115, 244, 73, 120, 31, 55, 10, 88, 136, 189, 247, 103, 197, 229, 132, 69 }, new byte[] { 55, 111, 75, 111, 86, 4, 67, 83, 15, 140, 147, 186, 120, 140, 118, 255, 0, 230, 36, 150, 121, 165, 248, 45, 163, 51, 55, 246, 166, 93, 179, 165, 111, 208, 105, 118, 232, 174, 228, 13, 177, 101, 127, 111, 52, 172, 225, 188, 86, 48, 33, 29, 175, 243, 251, 185, 26, 140, 164, 228, 102, 42, 44, 137, 110, 227, 246, 157, 14, 122, 11, 162, 71, 222, 92, 126, 163, 1, 89, 189, 31, 197, 38, 147, 217, 15, 2, 177, 108, 11, 217, 105, 98, 211, 21, 126, 144, 160, 167, 203, 119, 51, 183, 225, 0, 183, 226, 198, 77, 27, 156, 40, 105, 188, 220, 25, 42, 67, 161, 126, 62, 232, 71, 44, 55, 22, 131, 247 }, "User1" },
                    { 2, new byte[] { 154, 30, 12, 167, 43, 250, 53, 83, 219, 52, 10, 199, 98, 100, 187, 149, 73, 171, 248, 217, 40, 245, 134, 237, 108, 176, 96, 148, 240, 139, 123, 131, 138, 92, 209, 204, 128, 92, 41, 159, 26, 224, 49, 94, 101, 105, 48, 61, 115, 244, 73, 120, 31, 55, 10, 88, 136, 189, 247, 103, 197, 229, 132, 69 }, new byte[] { 55, 111, 75, 111, 86, 4, 67, 83, 15, 140, 147, 186, 120, 140, 118, 255, 0, 230, 36, 150, 121, 165, 248, 45, 163, 51, 55, 246, 166, 93, 179, 165, 111, 208, 105, 118, 232, 174, 228, 13, 177, 101, 127, 111, 52, 172, 225, 188, 86, 48, 33, 29, 175, 243, 251, 185, 26, 140, 164, 228, 102, 42, 44, 137, 110, 227, 246, 157, 14, 122, 11, 162, 71, 222, 92, 126, 163, 1, 89, 189, 31, 197, 38, 147, 217, 15, 2, 177, 108, 11, 217, 105, 98, 211, 21, 126, 144, 160, 167, 203, 119, 51, 183, 225, 0, 183, 226, 198, 77, 27, 156, 40, 105, 188, 220, 25, 42, 67, 161, 126, 62, 232, 71, 44, 55, 22, 131, 247 }, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[,]
                {
                    { 1, 1, 20, "The Master Sword" },
                    { 2, 2, 5, "Crystal Wand" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_SkillId",
                table: "CharacterSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CharacterId",
                table: "Weapons",
                column: "CharacterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
