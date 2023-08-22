﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class TablesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LoggedIn",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Followers",
                table: "Users",
                newName: "FollowerCount");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Ingredients",
                newName: "UserPermissionUserRolesId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<Guid>(
                name: "IngredientId",
                table: "Users",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "Units",
                type: "varchar(32)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Default",
                table: "Units",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Equivalence",
                table: "Units",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Units",
                type: "varchar(32)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "Subscriptions",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserPermissionUserRolesId",
                table: "Subscriptions",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomListId",
                table: "Recipes",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "Publications",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserPermissionUserRolesId",
                table: "Publications",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "LikePublications",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserPermissionUserRolesId",
                table: "LikePublications",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "LikeIngredients",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserPermissionUserRolesId",
                table: "LikeIngredients",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<float>(
                name: "Density",
                table: "Ingredients",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "Ingredients",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "PublicationId",
                table: "Images",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "Groups",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserPermissionUserRolesId",
                table: "Groups",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "CustomLists",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserPermissionUserRolesId",
                table: "CustomLists",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UserPermissionAction",
                table: "Comments",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserPermissionUserRolesId",
                table: "Comments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "GroupUser",
                columns: table => new
                {
                    GroupsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UsersId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUser", x => new { x.GroupsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GroupUser_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    IngredientsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RecipesId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => new { x.IngredientsId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PublicationUser",
                columns: table => new
                {
                    PublicationsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UsersLikeId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationUser", x => new { x.PublicationsId, x.UsersLikeId });
                    table.ForeignKey(
                        name: "FK_PublicationUser_Publications_PublicationsId",
                        column: x => x.PublicationsId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicationUser_Users_UsersLikeId",
                        column: x => x.UsersLikeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IngredientId",
                table: "Users",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleId",
                table: "Users",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserPermissionUserRolesId_UserPermissionAction",
                table: "Subscriptions",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_Steps_RecipeId",
                table: "Steps",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CustomListId",
                table: "Recipes",
                column: "CustomListId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_UserPermissionUserRolesId_UserPermissionAction",
                table: "Publications",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_LikePublications_PublicationId",
                table: "LikePublications",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_LikePublications_UserPermissionUserRolesId_UserPermissionAct~",
                table: "LikePublications",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_LikeIngredients_IngredientId",
                table: "LikeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeIngredients_UserPermissionUserRolesId_UserPermissionActi~",
                table: "LikeIngredients",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_UserPermissionUserRolesId_UserPermissionAction",
                table: "Ingredients",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_PublicationId",
                table: "Images",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UserPermissionUserRolesId_UserPermissionAction",
                table: "Groups",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoles_GroupId",
                table: "GroupRoles",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomLists_UserId",
                table: "CustomLists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomLists_UserPermissionUserRolesId_UserPermissionAction",
                table: "CustomLists",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomListRecipes_RecipeId",
                table: "CustomListRecipes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Critics_RecipeId",
                table: "Critics",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PublicationId",
                table: "Comments",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserPermissionUserRolesId_UserPermissionAction",
                table: "Comments",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_UsersId",
                table: "GroupUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipesId",
                table: "IngredientRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationUser_UsersLikeId",
                table: "PublicationUser",
                column: "UsersLikeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Publications_PublicationId",
                table: "Comments",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_UserPermissions_UserPermissionUserRolesId_UserPermi~",
                table: "Comments",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Critics_Recipes_RecipeId",
                table: "Critics",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomListRecipes_CustomLists_CustomListId",
                table: "CustomListRecipes",
                column: "CustomListId",
                principalTable: "CustomLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomListRecipes_Recipes_RecipeId",
                table: "CustomListRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomLists_UserPermissions_UserPermissionUserRolesId_UserPe~",
                table: "CustomLists",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomLists_Users_UserId",
                table: "CustomLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupPermissions_GroupRoles_GroupRoleId",
                table: "GroupPermissions",
                column: "GroupRoleId",
                principalTable: "GroupRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupRoles_Groups_GroupId",
                table: "GroupRoles",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_UserPermissions_UserPermissionUserRolesId_UserPermiss~",
                table: "Groups",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Publications_PublicationId",
                table: "Images",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_UserPermissions_UserPermissionUserRolesId_UserPe~",
                table: "Ingredients",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_LikeIngredients_Ingredients_IngredientId",
                table: "LikeIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikeIngredients_UserPermissions_UserPermissionUserRolesId_Us~",
                table: "LikeIngredients",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_LikeIngredients_Users_UserId",
                table: "LikeIngredients",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikePublications_Publications_PublicationId",
                table: "LikePublications",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikePublications_UserPermissions_UserPermissionUserRolesId_U~",
                table: "LikePublications",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_LikePublications_Users_UserId",
                table: "LikePublications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_UserPermissions_UserPermissionUserRolesId_UserP~",
                table: "Publications",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_CustomLists_CustomListId",
                table: "Recipes",
                column: "CustomListId",
                principalTable: "CustomLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Groups_GroupId",
                table: "Subscriptions",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_UserPermissions_UserPermissionUserRolesId_User~",
                table: "Subscriptions",
                columns: new[] { "UserPermissionUserRolesId", "UserPermissionAction" },
                principalTable: "UserPermissions",
                principalColumns: new[] { "UserRolesId", "Action" });

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Ingredients_IngredientId",
                table: "Users",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_UserRoleId",
                table: "Users",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Publications_PublicationId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UserPermissions_UserPermissionUserRolesId_UserPermi~",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Critics_Recipes_RecipeId",
                table: "Critics");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomListRecipes_CustomLists_CustomListId",
                table: "CustomListRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomListRecipes_Recipes_RecipeId",
                table: "CustomListRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomLists_UserPermissions_UserPermissionUserRolesId_UserPe~",
                table: "CustomLists");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomLists_Users_UserId",
                table: "CustomLists");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupPermissions_GroupRoles_GroupRoleId",
                table: "GroupPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupRoles_Groups_GroupId",
                table: "GroupRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_UserPermissions_UserPermissionUserRolesId_UserPermiss~",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Publications_PublicationId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_UserPermissions_UserPermissionUserRolesId_UserPe~",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeIngredients_Ingredients_IngredientId",
                table: "LikeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeIngredients_UserPermissions_UserPermissionUserRolesId_Us~",
                table: "LikeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeIngredients_Users_UserId",
                table: "LikeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_LikePublications_Publications_PublicationId",
                table: "LikePublications");

            migrationBuilder.DropForeignKey(
                name: "FK_LikePublications_UserPermissions_UserPermissionUserRolesId_U~",
                table: "LikePublications");

            migrationBuilder.DropForeignKey(
                name: "FK_LikePublications_Users_UserId",
                table: "LikePublications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_UserPermissions_UserPermissionUserRolesId_UserP~",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_CustomLists_CustomListId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Groups_GroupId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_UserPermissions_UserPermissionUserRolesId_User~",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Ingredients_IngredientId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_UserRoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "GroupUser");

            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DropTable(
                name: "PublicationUser");

            migrationBuilder.DropIndex(
                name: "IX_Users_IngredientId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserRoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_UserPermissionUserRolesId_UserPermissionAction",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Steps_RecipeId",
                table: "Steps");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CustomListId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_Publications_UserPermissionUserRolesId_UserPermissionAction",
                table: "Publications");

            migrationBuilder.DropIndex(
                name: "IX_LikePublications_PublicationId",
                table: "LikePublications");

            migrationBuilder.DropIndex(
                name: "IX_LikePublications_UserPermissionUserRolesId_UserPermissionAct~",
                table: "LikePublications");

            migrationBuilder.DropIndex(
                name: "IX_LikeIngredients_IngredientId",
                table: "LikeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_LikeIngredients_UserPermissionUserRolesId_UserPermissionActi~",
                table: "LikeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_UserPermissionUserRolesId_UserPermissionAction",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Images_PublicationId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Groups_UserPermissionUserRolesId_UserPermissionAction",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_GroupRoles_GroupId",
                table: "GroupRoles");

            migrationBuilder.DropIndex(
                name: "IX_CustomLists_UserId",
                table: "CustomLists");

            migrationBuilder.DropIndex(
                name: "IX_CustomLists_UserPermissionUserRolesId_UserPermissionAction",
                table: "CustomLists");

            migrationBuilder.DropIndex(
                name: "IX_CustomListRecipes_RecipeId",
                table: "CustomListRecipes");

            migrationBuilder.DropIndex(
                name: "IX_Critics_RecipeId",
                table: "Critics");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PublicationId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserPermissionUserRolesId_UserPermissionAction",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Default",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Equivalence",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "UserPermissionUserRolesId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "CustomListId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "UserPermissionUserRolesId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "LikePublications");

            migrationBuilder.DropColumn(
                name: "UserPermissionUserRolesId",
                table: "LikePublications");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "LikeIngredients");

            migrationBuilder.DropColumn(
                name: "UserPermissionUserRolesId",
                table: "LikeIngredients");

            migrationBuilder.DropColumn(
                name: "Density",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "PublicationId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "UserPermissionUserRolesId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "CustomLists");

            migrationBuilder.DropColumn(
                name: "UserPermissionUserRolesId",
                table: "CustomLists");

            migrationBuilder.DropColumn(
                name: "UserPermissionAction",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserPermissionUserRolesId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "FollowerCount",
                table: "Users",
                newName: "Followers");

            migrationBuilder.RenameColumn(
                name: "UserPermissionUserRolesId",
                table: "Ingredients",
                newName: "RecipeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "varchar(32)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "varchar(32)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "LoggedIn",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }
    }
}
