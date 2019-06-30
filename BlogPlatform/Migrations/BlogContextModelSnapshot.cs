﻿// <auto-generated />
using System;
using BlogPlatform.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        new { Id = 1, Name = "Software Development" },
                        new { Id = 2, Name = "Cars" }
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
                        new { Id = 1, Author = "Matt V", Body = "Lorem Ipsum", CategoryId = 1, Date = new DateTime(2019, 6, 30, 15, 49, 28, 383, DateTimeKind.Local), Title = "Coding Bootcamps" },
                        new { Id = 2, Author = "Angel", Body = "Lorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem Ipsum", CategoryId = 1, Date = new DateTime(2019, 6, 30, 15, 49, 28, 386, DateTimeKind.Local), Title = "Visual Studio" },
                        new { Id = 3, Author = "Carla", Body = "Lorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem Ipsum", CategoryId = 2, Date = new DateTime(2019, 6, 30, 15, 49, 28, 386, DateTimeKind.Local), Title = "Ford Mustang" },
                        new { Id = 4, Author = "Sally", Body = "Lorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem Ipsum", CategoryId = 2, Date = new DateTime(2019, 6, 30, 15, 49, 28, 386, DateTimeKind.Local), Title = "Ford GT" }
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
                        new { Id = 1, Name = "Education" },
                        new { Id = 2, Name = "C#" },
                        new { Id = 3, Name = "Ford" }
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
                        new { TagId = 1, PostId = 1, Id = 1 },
                        new { TagId = 2, PostId = 2, Id = 2 },
                        new { TagId = 3, PostId = 3, Id = 3 },
                        new { TagId = 3, PostId = 4, Id = 4 }
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
