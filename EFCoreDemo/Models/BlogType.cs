// This file defines the BlogType entity
// BlogType categorizes blogs (e.g. Technology, Sports, Lifestyle)
namespace EFCoreDemo.Models
{
    public class BlogType
    {
        // Primary key - unique ID for each blog type
        public int BlogTypeId { get; set; }

        // The current status of this blog type (e.g. Active, Inactive)
        public string Status { get; set; }

        // The name of the blog type (e.g. "Technology")
        public string Name { get; set; }

        // A short description explaining what this blog type is about
        public string Description { get; set; }

        // Navigation property - one BlogType can be assigned to many Blogs
        public ICollection<Blog> Blogs { get; set; }
    }
}