// This is the main entry point of the application
// Here we will add 3 users and 1 post into the MySQL database
// This satisfies Assignment Steps #3 and #4

using EFCoreDemo;
using EFCoreDemo.Models;

// =============================================
// STEP 1: First we need some BlogType and PostType data
// because Posts and Blogs require these to exist first
// =============================================
using (var context = new EFCoreDemoContext())
{
    // Check if we already have data to avoid duplicates
    if (!context.BlogTypes.Any())
    {
        // Adding a BlogType - required before we can create a Blog
        var blogType = new BlogType
        {
            Status = "Active",
            Name = "Technology",
            Description = "Blogs related to technology topics"
        };
        context.BlogTypes.Add(blogType);
        context.SaveChanges();
        Console.WriteLine("BlogType added successfully!");

        // Adding a Blog - required before we can create a Post
        var blog = new Blog
        {
            Url = "www.techblog.com",
            IsPublic = true,
            BlogTypeId = blogType.BlogTypeId
        };
        context.Blogs.Add(blog);
        context.SaveChanges();
        Console.WriteLine("Blog added successfully!");
    }

    // Adding a PostType - required before we can create a Post
    if (!context.PostTypes.Any())
    {
        var postType = new PostType
        {
            Status = "Active",
            Name = "Article",
            Description = "A detailed written article"
        };
        context.PostTypes.Add(postType);
        context.SaveChanges();
        Console.WriteLine("PostType added successfully!");
    }
}

// =============================================
// STEP 2: Add 3 Users into the database
// This satisfies Assignment Step #3
// =============================================
using (var context = new EFCoreDemoContext())
{
    if (!context.Users.Any())
    {
        // Creating User 1
        var user1 = new User
        {
            Name = "Alice Smith",
            EmailAddress = "alice@email.com",
            PhoneNumber = "780-111-2222"
        };

        // Creating User 2
        var user2 = new User
        {
            Name = "Bob Johnson",
            EmailAddress = "bob@email.com",
            PhoneNumber = "780-333-4444"
        };

        // Creating User 3
        var user3 = new User
        {
            Name = "Carol Williams",
            EmailAddress = "carol@email.com",
            PhoneNumber = "780-555-6666"
        };

        // Adding all 3 users to the database at once
        context.Users.AddRange(user1, user2, user3);
        context.SaveChanges();
        Console.WriteLine("3 Users added successfully!");
    }
}

// =============================================
// STEP 3: Add a new Post linked to a User
// This satisfies Assignment Step #4
// =============================================
using (var context = new EFCoreDemoContext())
{
    if (!context.Posts.Any())
    {
        // Getting the first user from the database to link to the post
        var user = context.Users.First();
        var blog = context.Blogs.First();
        var postType = context.PostTypes.First();

        // Creating a new Post and linking it to a User
        var post = new Post
        {
            Title = "My First Post",
            Content = "This is the content of my first post using Entity Framework Core.",
            BlogId = blog.BlogId,
            PostTypeId = postType.PostTypeId,
            UserId = user.UserId  // Linking the post to the first user
        };

        context.Posts.Add(post);
        context.SaveChanges();
        Console.WriteLine("Post added successfully and linked to user: " + user.Name);
    }
}

Console.WriteLine("All done! Check MySQL Workbench to verify the data.");