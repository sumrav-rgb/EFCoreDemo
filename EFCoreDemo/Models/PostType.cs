// This file defines the PostType entity
// PostType categorizes posts (e.g. Article, Review, Tutorial)
namespace EFCoreDemo.Models
{
    public class PostType
    {
        // Primary key - unique ID for each post type
        public int PostTypeId { get; set; }

        // The current status of this post type (e.g. Active, Inactive)
        public string Status { get; set; }

        // The name of the post type (e.g. "Tutorial")
        public string Name { get; set; }

        // A short description explaining what this post type is about
        public string Description { get; set; }

        // Navigation property - one PostType can be assigned to many Posts
        public ICollection<Post> Posts { get; set; }
    }
}