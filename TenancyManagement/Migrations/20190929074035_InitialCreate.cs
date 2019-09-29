using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TenancyManagement.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiNhanh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiNhanh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChuNha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuNha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiNha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Genden = table.Column<byte>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHang_ChiNhanh_BranchId",
                        column: x => x.BranchId,
                        principalTable: "ChiNhanh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Nha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<int>(nullable: false),
                    District = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Room = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseOwnerId = table.Column<int>(nullable: false),
                    CategoryHomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nha_LoaiNha_CategoryHomeId",
                        column: x => x.CategoryHomeId,
                        principalTable: "LoaiNha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Nha_ChuNha_HouseOwnerId",
                        column: x => x.HouseOwnerId,
                        principalTable: "ChuNha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PhanCong",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCong", x => new { x.BranchId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_PhanCong_ChiNhanh_BranchId",
                        column: x => x.BranchId,
                        principalTable: "ChiNhanh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PhanCong_NhanVien_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "YeuCau",
                columns: table => new
                {
                    CategoryHomeId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    Require = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YeuCau", x => new { x.CategoryHomeId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_YeuCau_LoaiNha_CategoryHomeId",
                        column: x => x.CategoryHomeId,
                        principalTable: "LoaiNha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_YeuCau_KhachHang_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDay = table.Column<DateTime>(nullable: false),
                    EndDay = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HopDong_Nha_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Nha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LichXemNha",
                columns: table => new
                {
                    HomeId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    DateView = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichXemNha", x => new { x.CustomerId, x.HomeId });
                    table.ForeignKey(
                        name: "FK_LichXemNha_KhachHang_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LichXemNha_Nha_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Nha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "QuanLy",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    HomeId = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLy", x => new { x.BranchId, x.EmployeeId, x.HomeId });
                    table.ForeignKey(
                        name: "FK_QuanLy_ChiNhanh_BranchId",
                        column: x => x.BranchId,
                        principalTable: "ChiNhanh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_QuanLy_NhanVien_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_QuanLy_Nha_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Nha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BanKyKet",
                columns: table => new
                {
                    ContractId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ExtensionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanKyKet", x => new { x.ContractId, x.CustomerId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_BanKyKet_HopDong_ContractId",
                        column: x => x.ContractId,
                        principalTable: "HopDong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BanKyKet_KhachHang_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BanKyKet_NhanVien_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanKyKet_ContractId",
                table: "BanKyKet",
                column: "ContractId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BanKyKet_CustomerId",
                table: "BanKyKet",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BanKyKet_EmployeeId",
                table: "BanKyKet",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_HomeId",
                table: "HopDong",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_BranchId",
                table: "KhachHang",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LichXemNha_HomeId",
                table: "LichXemNha",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nha_CategoryHomeId",
                table: "Nha",
                column: "CategoryHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nha_HouseOwnerId",
                table: "Nha",
                column: "HouseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_EmployeeId",
                table: "PhanCong",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuanLy_EmployeeId",
                table: "QuanLy",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuanLy_HomeId",
                table: "QuanLy",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_YeuCau_CustomerId",
                table: "YeuCau",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanKyKet");

            migrationBuilder.DropTable(
                name: "LichXemNha");

            migrationBuilder.DropTable(
                name: "PhanCong");

            migrationBuilder.DropTable(
                name: "QuanLy");

            migrationBuilder.DropTable(
                name: "YeuCau");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "Nha");

            migrationBuilder.DropTable(
                name: "ChiNhanh");

            migrationBuilder.DropTable(
                name: "LoaiNha");

            migrationBuilder.DropTable(
                name: "ChuNha");
        }
    }
}
