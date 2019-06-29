﻿// <auto-generated />
using System;
using BlogPlatform.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20190629003846_Seedlings2")]
    partial class Seedlings2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPlatform.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Name = "Coding" }
                    );
                });

            modelBuilder.Entity("BlogPlatform.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Body");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, Author = "Matt V", Body = "Lorem Ipsum", CategoryId = 1, Date = new DateTime(2019, 6, 28, 20, 38, 45, 857, DateTimeKind.Local), Title = "Coding Bootcamps" }
                    );
                });

            modelBuilder.Entity("BlogPlatform.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("postId");

                    b.HasKey("Id");

                    b.HasIndex("postId");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, Name = "Education" }
                    );
                });

            modelBuilder.Entity("BlogPlatform.Model.TagPosts", b =>
                {
                    b.Property<int>("TagId");

                    b.Property<int>("PostId");

                    b.Property<int>("Id");

                    b.HasKey("TagId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("TagPostsdb");

                    b.HasData(
                        new { TagId = 1, PostId = 1, Id = 1 }
                    );
                });

            modelBuilder.Entity("BlogPlatform.Model.Post", b =>
                {
                    b.HasOne("BlogPlatform.Model.Category", "category")
                        .WithMany("PostsList")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlogPlatform.Model.Tag", b =>
                {
                    b.HasOne("BlogPlatform.Model.Post", "post")
                        .WithMany()
                        .HasForeignKey("postId");
                });

            modelBuilder.Entity("BlogPlatform.Model.TagPosts", b =>
                {
                    b.HasOne("BlogPlatform.Model.Post", "post")
                        .WithMany("TagPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlogPlatform.Model.Tag", "tag")
                        .WithMany("TagPosts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
