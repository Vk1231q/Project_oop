using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_oop.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CityViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostOfficeViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostOfficeViewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostOfficeViewModels_CityViewModels_CityId",
                        column: x => x.CityId,
                        principalTable: "CityViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostOfficeId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelViewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonnelViewModels_PostOfficeViewModels_PostOfficeId",
                        column: x => x.PostOfficeId,
                        principalTable: "PostOfficeViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcelId = table.Column<int>(type: "int", nullable: false),
                    Money = table.Column<int>(type: "int", nullable: false),
                    ParcelViewModelId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParcelViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendingPostOfficeId = table.Column<int>(type: "int", nullable: false),
                    ReceivingPostOfficeId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    Wage = table.Column<int>(type: "int", nullable: false),
                    Dispatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delievery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelViewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParcelViewModels_ClientViewModels_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientViewModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ParcelViewModels_PostOfficeViewModels_ReceivingPostOfficeId",
                        column: x => x.ReceivingPostOfficeId,
                        principalTable: "PostOfficeViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParcelViewModels_PostOfficeViewModels_SendingPostOfficeId",
                        column: x => x.SendingPostOfficeId,
                        principalTable: "PostOfficeViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientViewModels_ParcelViewModelId",
                table: "ClientViewModels",
                column: "ParcelViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelViewModels_ClientId",
                table: "ParcelViewModels",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelViewModels_ReceivingPostOfficeId",
                table: "ParcelViewModels",
                column: "ReceivingPostOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelViewModels_SendingPostOfficeId",
                table: "ParcelViewModels",
                column: "SendingPostOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelViewModels_PostOfficeId",
                table: "PersonnelViewModels",
                column: "PostOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostOfficeViewModels_CityId",
                table: "PostOfficeViewModels",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientViewModels_ParcelViewModels_ParcelViewModelId",
                table: "ClientViewModels",
                column: "ParcelViewModelId",
                principalTable: "ParcelViewModels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientViewModels_ParcelViewModels_ParcelViewModelId",
                table: "ClientViewModels");

            migrationBuilder.DropTable(
                name: "PersonnelViewModels");

            migrationBuilder.DropTable(
                name: "ParcelViewModels");

            migrationBuilder.DropTable(
                name: "ClientViewModels");

            migrationBuilder.DropTable(
                name: "PostOfficeViewModels");

            migrationBuilder.DropTable(
                name: "CityViewModels");
        }
    }
}
