using BlogPlatform.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class BlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagPosts> TagPostsdb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=blogplatformDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Software Development"
                },

                new Category
                {
                    Id = 1,
                    Name = "Cars"
                }
                );

            modelBuilder.Entity<TagPosts>().HasKey(tp => new { tp.TagId, tp.PostId });

            modelBuilder.Entity<TagPosts>()
               .HasOne<Tag>(tp => tp.tag)
               .WithMany(t => t.TagPosts)
               .HasForeignKey(tp => tp.TagId);

            modelBuilder.Entity<TagPosts>()
               .HasOne<Post>(tp => tp.post)
               .WithMany(s => s.TagPosts)
               .HasForeignKey(tp => tp.PostId);

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Coding Bootcamps",
                    Body = "Lorem Ipsum",
                    Author = "Matt V",
                    Date = DateTime.Now,
                    CategoryId = 1
                });

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    Id = 1,
                    Name = "Education"
                });

            modelBuilder.Entity<TagPosts>().HasData(
                new TagPosts
                {
                    Id = 1,
                    TagId = 1,
                    PostId = 1
                });




        }
    }
}
