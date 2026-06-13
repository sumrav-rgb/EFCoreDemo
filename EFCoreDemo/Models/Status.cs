// This file defines the Status entity
// Status is used to track the state of different items in the system
namespace EFCoreDemo.Models
{
    public class Status
    {
        // Primary key - unique ID for each status
        public int StatusId { get; set; }

        // The name of the status (e.g. Active, Inactive, Pending)
        public string Name { get; set; }

        // A short description explaining what this status means
        public string Description { get; set; }
    }
}