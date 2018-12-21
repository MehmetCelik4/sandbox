using Microsoft.EntityFrameworkCore.Migrations;

namespace Diet.Data.Migrations
{
    public partial class AgainFixDietitianAndCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Dietitian_DietitianID",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "DietitianID",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Dietitian_DietitianID",
                table: "Customer",
                column: "DietitianID",
                principalTable: "Dietitian",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Dietitian_DietitianID",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "DietitianID",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Dietitian_DietitianID",
                table: "Customer",
                column: "DietitianID",
                principalTable: "Dietitian",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
