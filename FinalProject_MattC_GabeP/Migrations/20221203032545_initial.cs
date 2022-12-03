using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_MattC_GabeP.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackName = table.Column<string>(nullable: false),
                    FeedbackText = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "FeedbackId", "FeedbackName", "FeedbackText" },
                values: new object[] { 1, "Matt", "Smells great,tastes great, all things people say about websites." });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "FeedbackId", "FeedbackName", "FeedbackText" },
                values: new object[] { 2, "Gabe", "Well, we created this so........ it looks good to me." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");
        }
    }
}
