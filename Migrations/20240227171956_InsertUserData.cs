using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHMS.Migrations
{
    /// <inheritdoc />
    public partial class InsertUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[]
                {
                    "UserId",
                    "FirstName",
                    "LastName",
                    "Email",
                    "PhoneNumber",
                    "EmergencyContactName",
                    "EmergencyContactNumber",
                    "Username",
                    "Password",
                    "Role",
                    "Status"
                },
                values: new object[]
                {
                    1,
                    "Mark Wayne",
                    "Menorca",
                    "markwayne.menorca@gmail.com",
                    "09123456789",
                    "Marian Menorca",
                    "09123456789",
                    "admin",
                    "admin",
                    "admin",
                    "active"
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "Users", keyColumn: "UserId", keyValue: 1);
        }
    }
}
