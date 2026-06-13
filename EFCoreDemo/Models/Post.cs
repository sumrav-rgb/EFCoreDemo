// This file defines the Post entity (table in the database)
// A Post belongs to a Blog, has a PostType, and is created by a User
// UserId was added in this assignment to track who created each post
namespace EFCoreDemo.Models
{
    public class Post
    {
        // Primary key - unique ID for each post
        public int PostId { get; set; }

        // The title of the post
        public string Title { get; set; }

        // The main content/body of the post
        public string Content { get; set; }

        // Foreign key - links this post to a Blog
        public int BlogId { get; set; }

        // Foreign key - links this post to a PostType
        public int PostTypeId { get; set; }

        // Foreign key - links this post to a User (added in this assignment)
        public int UserId { get; set; }

        // Navigation property - allows access to the Blog this post belongs to
        public Blog Blog { get; set; }

        // Navigation property - allows access to the PostType of this post
        public PostType PostType { get; set; }

        // Navigation property - allows access to the User who created this post
        public User User { get; set; }
    }
}