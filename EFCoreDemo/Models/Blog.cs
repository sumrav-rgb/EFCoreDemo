// This file defines the Blog entity (table in the database)
// Each Blog has a URL, visibility status, and belongs to a BlogType
namespace EFCoreDemo.Models
{
    public class Blog
    {
        // Primary key - unique ID for each blog
        public int BlogId { get; set; }

        // The web address of the blog
        public string Url { get; set; }

        // Whether the blog is visible to the public or not
        public bool IsPublic { get; set; }

        // Foreign key - links this blog to a BlogType
        public int BlogTypeId { get; set; }

        // Navigation property - allows us to access the BlogType details
        public BlogType BlogType { get; set; }

        // Navigation property - one blog can have many posts
        public ICollection<Post> Posts { get; set; }
    }
}