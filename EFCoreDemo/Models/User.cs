// This file defines the User entity (new table added in this assignment)
// A User represents the person who creates posts in the system
// This entity was created to satisfy Assignment requirement Step #1
namespace EFCoreDemo.Models
{
    public class User
    {
        // Primary key - unique ID for each user
        public int UserId { get; set; }

        // The full name of the user
        public string Name { get; set; }

        // The email address of the user
        public string EmailAddress { get; set; }

        // The phone number of the user
        public string PhoneNumber { get; set; }

        // Navigation property - one User can create many Posts
        public ICollection<Post> Posts { get; set; }
    }
}