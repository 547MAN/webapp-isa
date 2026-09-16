using BecomeAWizzard.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BecomeAWizzard.Api.Data;

// TASK 3 STARTER
// AuthService, QuizService, GameService and ProgressController depend on these DbSet contracts.
// Keep their names stable while implementing keys, indexes, relationships and delete behaviour.
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Quiz> Quizzes => Set<Quiz>();
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<AnswerOption> AnswerOptions => Set<AnswerOption>();
    public DbSet<QuizAttempt> QuizAttempts => Set<QuizAttempt>();
    public DbSet<AnswerAttempt> AnswerAttempts => Set<AnswerAttempt>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // TODO 3.1: unique User.Email index.
        // TODO 3.2: User -> Quizzes and User -> QuizAttempts relationships with restricted user deletion.
        // TODO 3.3: Quiz -> Questions -> AnswerOptions cascade deletion.
        // TODO 3.4: Quiz -> Attempts relationship and string conversion for AttemptStatus.
    }
}
