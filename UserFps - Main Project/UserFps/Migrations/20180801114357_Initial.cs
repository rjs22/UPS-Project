using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserFps.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Extra",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    JavascriptVer = table.Column<string>(nullable: true),
                    Timezone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoginRecord",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Vendor1Return = table.Column<string>(nullable: true),
                    Vendor2Return = table.Column<string>(nullable: true),
                    Vendor3Return = table.Column<string>(nullable: true),
                    Vendor4Return = table.Column<string>(nullable: true),
                    Vendor5Return = table.Column<string>(nullable: true),
                    Vendor6Return = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginRecord", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Navigator",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    AppCodeName = table.Column<string>(nullable: true),
                    AppName = table.Column<string>(nullable: true),
                    AppVersion = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Platform = table.Column<string>(nullable: true),
                    Oscpu = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    SecurityPolicy = table.Column<string>(nullable: true),
                    UserAgent = table.Column<string>(nullable: true),
                    CookieEnabled = table.Column<bool>(nullable: false),
                    Online = table.Column<bool>(nullable: false),
                    BuildID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigator", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Plugins",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    VersionNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plugins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Screen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    AvailHeight = table.Column<int>(nullable: false),
                    AvailWidth = table.Column<int>(nullable: false),
                    ColorDepth = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    PixelDepth = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UsersModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    DeviceID = table.Column<string>(nullable: true),
                    Ioaa = table.Column<string>(nullable: true),
                    Iobb = table.Column<string>(nullable: true),
                    Iocc = table.Column<string>(nullable: true),
                    Iodd = table.Column<string>(nullable: true),
                    Ioee = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorName = table.Column<string>(nullable: true),
                    VendorCode = table.Column<string>(nullable: true),
                    ServiceActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extra");

            migrationBuilder.DropTable(
                name: "LoginRecord");

            migrationBuilder.DropTable(
                name: "Navigator");

            migrationBuilder.DropTable(
                name: "Plugins");

            migrationBuilder.DropTable(
                name: "Screen");

            migrationBuilder.DropTable(
                name: "UsersModel");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
