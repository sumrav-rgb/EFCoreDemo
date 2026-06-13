// This file is the DbContext - it is the main connection bridge
// between our C# application and the MySQL database
// It tells Entity Framework which classes are tables in the database

using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    public class EFCoreDemoContext : DbContext
    {
        // Each DbSet represents a table in the MySQL database

        // This creates the Blogs table
        public DbSet<Blog> Blogs { get; set; }

        // This creates the BlogTypes table
        public DbSet<BlogType> BlogTypes { get; set; }

        // This creates the Posts table
        public DbSet<Post> Posts { get; set; }

        // This creates the PostTypes table
        public DbSet<PostType> PostTypes { get; set; }

        // This creates the Users table (added in this assignment)
        public DbSet<User> Users { get; set; }

        // This creates the Statuses table
        public DbSet<Status> Statuses { get; set; }

        // This method configures the connection to our MySQL database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connecting to MySQL running locally on port 3306
            // Database name: EFCoreDemo
            // Username: root
            // Password: Vasim@123456
            optionsBuilder.UseMySql(
                "Server=localhost;Database=EFCoreDemo;User=root;Password=Vasim@123456;",
                new MySqlServerVersion(new Version(8, 0, 46))
            );
        }
    }
}