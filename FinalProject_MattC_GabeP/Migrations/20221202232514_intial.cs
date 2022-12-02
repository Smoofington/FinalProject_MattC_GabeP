using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_MattC_GabeP.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackTitle = table.Column<string>(nullable: false),
                    FeedbackDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "FeedbackId", "FeedbackDescription", "FeedbackTitle" },
                values: new object[] { 1, "Smells great,tastes great, all things people say about websites.", "Matt" });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "FeedbackId", "FeedbackDescription", "FeedbackTitle" },
                values: new object[] { 2, "Well, we created this so........ it looks good to me.", "Gabe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");
        }
    }
}
