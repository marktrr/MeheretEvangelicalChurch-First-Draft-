using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeheretEvangelicalChurch.Migrations
{
    public partial class CreateServiceAndEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    eventID = table.Column<int>(nullable: false),
                    eventTitle = table.Column<string>(maxLength: 100, nullable: true),
                    eventDescription = table.Column<string>(type: "text", nullable: true),
                    eventDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    eventImage = table.Column<byte[]>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.eventID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    serviceID = table.Column<int>(nullable: false),
                    serviceTitle = table.Column<string>(maxLength: 100, nullable: true),
                    serviceDescription = table.Column<string>(type: "text", nullable: true),
                    serviceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    serviceImage = table.Column<byte[]>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.serviceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
