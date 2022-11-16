using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatbotConfiguration.Migrations
{
    public partial class DBupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "user_Reply",
                table: "tbl_UserReplies",
                newName: "userReply");

            migrationBuilder.RenameColumn(
                name: "User_identity",
                table: "tbl_UserReplies",
                newName: "userIdentity");

            migrationBuilder.RenameColumn(
                name: "Que_id",
                table: "tbl_UserReplies",
                newName: "quetionsId");

            migrationBuilder.RenameColumn(
                name: "Reply_id",
                table: "tbl_UserReplies",
                newName: "userRepliesId");

            migrationBuilder.RenameColumn(
                name: "Que_type",
                table: "tbl_Quetions",
                newName: "quetionsType");

            migrationBuilder.RenameColumn(
                name: "Que_targetId",
                table: "tbl_Quetions",
                newName: "quetionsTargetId");

            migrationBuilder.RenameColumn(
                name: "Que_sequence",
                table: "tbl_Quetions",
                newName: "quetionsSequence");

            migrationBuilder.RenameColumn(
                name: "Que_description",
                table: "tbl_Quetions",
                newName: "quetionsDescription");

            migrationBuilder.RenameColumn(
                name: "Bot_id",
                table: "tbl_Quetions",
                newName: "botId");

            migrationBuilder.RenameColumn(
                name: "Que_id",
                table: "tbl_Quetions",
                newName: "quetionsId");

            migrationBuilder.RenameColumn(
                name: "Que_targetId",
                table: "tbl_Options",
                newName: "quetionsTargetId");

            migrationBuilder.RenameColumn(
                name: "Que_id",
                table: "tbl_Options",
                newName: "quetionsId");

            migrationBuilder.RenameColumn(
                name: "Option_name",
                table: "tbl_Options",
                newName: "optionsName");

            migrationBuilder.RenameColumn(
                name: "Option_id",
                table: "tbl_Options",
                newName: "optionsId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserReplies_quetionsId",
                table: "tbl_UserReplies",
                column: "quetionsId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Options_quetionsId",
                table: "tbl_Options",
                column: "quetionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Options_tbl_Quetions_quetionsId",
                table: "tbl_Options",
                column: "quetionsId",
                principalTable: "tbl_Quetions",
                principalColumn: "quetionsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_UserReplies_tbl_Quetions_quetionsId",
                table: "tbl_UserReplies",
                column: "quetionsId",
                principalTable: "tbl_Quetions",
                principalColumn: "quetionsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Options_tbl_Quetions_quetionsId",
                table: "tbl_Options");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_UserReplies_tbl_Quetions_quetionsId",
                table: "tbl_UserReplies");

            migrationBuilder.DropIndex(
                name: "IX_tbl_UserReplies_quetionsId",
                table: "tbl_UserReplies");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Options_quetionsId",
                table: "tbl_Options");

            migrationBuilder.RenameColumn(
                name: "userReply",
                table: "tbl_UserReplies",
                newName: "user_Reply");

            migrationBuilder.RenameColumn(
                name: "userIdentity",
                table: "tbl_UserReplies",
                newName: "User_identity");

            migrationBuilder.RenameColumn(
                name: "quetionsId",
                table: "tbl_UserReplies",
                newName: "Que_id");

            migrationBuilder.RenameColumn(
                name: "userRepliesId",
                table: "tbl_UserReplies",
                newName: "Reply_id");

            migrationBuilder.RenameColumn(
                name: "quetionsType",
                table: "tbl_Quetions",
                newName: "Que_type");

            migrationBuilder.RenameColumn(
                name: "quetionsTargetId",
                table: "tbl_Quetions",
                newName: "Que_targetId");

            migrationBuilder.RenameColumn(
                name: "quetionsSequence",
                table: "tbl_Quetions",
                newName: "Que_sequence");

            migrationBuilder.RenameColumn(
                name: "quetionsDescription",
                table: "tbl_Quetions",
                newName: "Que_description");

            migrationBuilder.RenameColumn(
                name: "botId",
                table: "tbl_Quetions",
                newName: "Bot_id");

            migrationBuilder.RenameColumn(
                name: "quetionsId",
                table: "tbl_Quetions",
                newName: "Que_id");

            migrationBuilder.RenameColumn(
                name: "quetionsTargetId",
                table: "tbl_Options",
                newName: "Que_targetId");

            migrationBuilder.RenameColumn(
                name: "quetionsId",
                table: "tbl_Options",
                newName: "Que_id");

            migrationBuilder.RenameColumn(
                name: "optionsName",
                table: "tbl_Options",
                newName: "Option_name");

            migrationBuilder.RenameColumn(
                name: "optionsId",
                table: "tbl_Options",
                newName: "Option_id");
        }
    }
}
