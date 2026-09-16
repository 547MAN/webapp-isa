namespace BecomeAWizzard.Api.Data;

// TASK 3 STARTER
// Program.cs calls this after EnsureCreatedAsync. Seed only local demonstration data.
public static class SeedData
{
    public static Task InitializeAsync(AppDbContext db)
    {
        // TODO 3.5: create one hashed demo user and one published quiz with at least three questions.
        // Make the method idempotent by returning when Users already contains data.
        return Task.CompletedTask;
    }
}
