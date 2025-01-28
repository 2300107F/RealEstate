using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    AgentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.AgentId);
                    table.ForeignKey(
                        name: "FK_Agent_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FacilityId);
                    table.ForeignKey(
                        name: "FK_Facility_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bedrooms = table.Column<int>(type: "int", nullable: true),
                    Bathrooms = table.Column<int>(type: "int", nullable: true),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Property_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "AgentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inquiry",
                columns: table => new
                {
                    InquiryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfInquiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiry", x => x.InquiryId);
                    table.ForeignKey(
                        name: "FK_Inquiry_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inquiry_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyImage",
                columns: table => new
                {
                    PropertyImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImage", x => x.PropertyImageId);
                    table.ForeignKey(
                        name: "FK_PropertyImage_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTransaction",
                columns: table => new
                {
                    PropertyTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTransaction", x => x.PropertyTransactionId);
                    table.ForeignKey(
                        name: "FK_PropertyTransaction_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyTransaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "CompanyAddress", "CompanyName", "CompanyPhoneNumber" },
                values: new object[,]
                {
                    { 1, "Queenstown Road", "XYZ realestate", "55555555" },
                    { 2, "Orchard Road", "ABC Real Estate", "55554444" }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "RegionId", "RegionDescription", "RegionName" },
                values: new object[,]
                {
                    { 1, "Located on the east side of singapore", "East" },
                    { 2, "The Singapore Central Region with towns like toa payoh", "Central" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "DateRegistered", "Email", "Password", "UserName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 22, 12, 16, 55, 827, DateTimeKind.Local).AddTicks(7807), "JohnDoe@gmail.com", "P@ssword1", "John", "12345678" },
                    { 2, new DateTime(2025, 1, 22, 12, 16, 55, 827, DateTimeKind.Local).AddTicks(7828), "Samantha@gmail.com", "P@ssword1", "Samantha", "11111111" }
                });

            migrationBuilder.InsertData(
                table: "Agent",
                columns: new[] { "AgentId", "AgentPhoneNumber", "CompanyId", "Email", "LicenseNumber", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "54326789", 1, "LawrenceTan@gmail.com", "S123456", "Lawrence Tan", "P@ssword1" },
                    { 2, "87003840", 1, "JonasLim@realestateagent.com", "T246802", "Jonas Lim", "P@ssword1" }
                });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "FacilityDescription", "FacilityName", "RegionId" },
                values: new object[,]
                {
                    { 1, "Food centre for singaporean", "Hawker", 1 },
                    { 2, null, "Gym", 1 }
                });

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "PropertyId", "Address", "AgentId", "Bathrooms", "Bedrooms", "City", "PostalCode", "Price", "PropertyType", "RegionId", "Sqft", "State", "Status" },
                values: new object[,]
                {
                    { 1, "Tampines Blk 123", 1, 3, 5, "Singapore", "330022", 1000000, "HDB", 1, 1100, "Singapore", "Available" },
                    { 2, "Bedok Blk 456", 2, 2, 3, "Singapore", "123456", 400000, "HDB", 1, 700, "Singapore", "Available" },
                    { 3, "Kallang Blk 123", 1, 2, 4, "Singapore", "364029", 750000, "HDB", 2, 890, "Singapore", "Sold" }
                });

            migrationBuilder.InsertData(
                table: "PropertyTransaction",
                columns: new[] { "PropertyTransactionId", "Amount", "PropertyId", "TransactionDate", "UserId" },
                values: new object[] { 1, 800000, 3, new DateTime(2025, 1, 22, 12, 16, 55, 827, DateTimeKind.Local).AddTicks(9455), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Agent_CompanyId",
                table: "Agent",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_RegionId",
                table: "Facility",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiry_PropertyId",
                table: "Inquiry",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiry_UserId",
                table: "Inquiry",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_AgentId",
                table: "Property",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_RegionId",
                table: "Property",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImage_PropertyId",
                table: "PropertyImage",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTransaction_PropertyId",
                table: "PropertyTransaction",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTransaction_UserId",
                table: "PropertyTransaction",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "Inquiry");

            migrationBuilder.DropTable(
                name: "PropertyImage");

            migrationBuilder.DropTable(
                name: "PropertyTransaction");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
