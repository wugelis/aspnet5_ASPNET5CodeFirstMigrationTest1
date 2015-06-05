using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace MyCodeFiratAPNET5.Migrations
{
    public partial class NewCustomer : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "ClassRoom",
                columns: table => new
                {
                    BuildingId = table.Column(type: "int", nullable: false),
                    ClassFloor = table.Column(type: "int", nullable: false),
                    ClassRoomId = table.Column(type: "nvarchar(max)", nullable: true),
                    ClassRoomName = table.Column(type: "nvarchar(max)", nullable: true),
                    NumOfPeoples = table.Column(type: "int", nullable: false),
                    id = table.Column(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.id);
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("ClassRoom");
        }
    }
}
