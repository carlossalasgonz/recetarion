﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recetarion.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(RecetarionDbContext))]
    partial class RecetarionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Recetarion.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PublicationId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Recetarion.Models.Critic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("PublicationId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Critics");
                });

            modelBuilder.Entity("Recetarion.Models.CustomList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("CustomLists");
                });

            modelBuilder.Entity("Recetarion.Models.CustomListRecipe", b =>
                {
                    b.Property<Guid>("CustomListId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.HasKey("CustomListId", "RecipeId");

                    b.ToTable("CustomListRecipes");
                });

            modelBuilder.Entity("Recetarion.Models.Follow", b =>
                {
                    b.Property<Guid>("FollowerId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("FolloweeId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.HasKey("FollowerId", "FolloweeId");

                    b.HasIndex("FolloweeId");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("Recetarion.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Recetarion.Models.GroupPermission", b =>
                {
                    b.Property<Guid>("GroupRoleId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Action")
                        .HasColumnType("varchar(255)")
                        .HasColumnOrder(1);

                    b.HasKey("GroupRoleId", "Action");

                    b.ToTable("GroupPermissions");
                });

            modelBuilder.Entity("Recetarion.Models.GroupRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("GroupRoles");
                });

            modelBuilder.Entity("Recetarion.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Recetarion.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<Guid?>("RecipeId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Recetarion.Models.LikeIngredient", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.Property<bool>("IsDislike")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("UserId", "IngredientId");

                    b.ToTable("LikeIngredients");
                });

            modelBuilder.Entity("Recetarion.Models.LikePublication", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("PublicationId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.HasKey("UserId", "PublicationId");

                    b.ToTable("LikePublications");
                });

            modelBuilder.Entity("Recetarion.Models.Publication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("Recetarion.Models.PublicationImage", b =>
                {
                    b.Property<Guid>("PublicationId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("ImageId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.Property<uint>("Order")
                        .HasColumnType("int unsigned");

                    b.HasKey("PublicationId", "ImageId");

                    b.ToTable("PublicationImages");
                });

            modelBuilder.Entity("Recetarion.Models.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("PublicationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Recetarion.Models.RecipeIngredient", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.Property<Guid>("UnitId")
                        .HasColumnType("char(36)");

                    b.Property<uint>("quantity")
                        .HasColumnType("int unsigned");

                    b.HasKey("RecipeId", "IngredientId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("Recetarion.Models.Step", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("Recetarion.Models.Subscription", b =>
                {
                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("GroupId", "UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Recetarion.Models.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Recetarion.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<uint>("Followers")
                        .HasColumnType("int unsigned");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<bool>("LoggedIn")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TokenFacebook")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TokenTwitter")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserRoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Recetarion.Models.UserPermission", b =>
                {
                    b.Property<Guid>("UserRolesId")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Action")
                        .HasColumnType("varchar(255)")
                        .HasColumnOrder(1);

                    b.Property<Guid?>("UserRoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserRolesId", "Action");

                    b.HasIndex("UserRoleId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("Recetarion.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Recetarion.Models.Follow", b =>
                {
                    b.HasOne("Recetarion.Models.User", "Followee")
                        .WithMany()
                        .HasForeignKey("FolloweeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recetarion.Models.User", "Follower")
                        .WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Followee");

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("Recetarion.Models.Ingredient", b =>
                {
                    b.HasOne("Recetarion.Models.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Recetarion.Models.UserPermission", b =>
                {
                    b.HasOne("Recetarion.Models.UserRole", null)
                        .WithMany("Permissions")
                        .HasForeignKey("UserRoleId");
                });

            modelBuilder.Entity("Recetarion.Models.Recipe", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Recetarion.Models.UserRole", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
