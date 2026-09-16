using BecomeAWizzard.Api.Data;
using BecomeAWizzard.Api.DTOs;

namespace BecomeAWizzard.Api.Services;

// TASK 4 STARTER
// QuizzesController depends on this service; this service depends on Task 3's AppDbContext relationships.
public class QuizService(AppDbContext db)
{
    public Task<IReadOnlyList<QuizSummaryDto>> GetPublishedAsync() =>
        throw new NotImplementedException("Task 4: query published quizzes.");

    public Task<IReadOnlyList<QuizSummaryDto>> GetMineAsync(int userId) =>
        throw new NotImplementedException("Task 4: query quizzes owned by the active user.");

    public Task<QuizDetailsDto?> GetAsync(int id, int userId) =>
        throw new NotImplementedException("Task 4: load an owned quiz with questions and answer options.");

    public Task<QuizDetailsDto> CreateAsync(int userId, QuizInput input) =>
        throw new NotImplementedException("Task 4: validate, map and persist a new quiz.");

    public Task<QuizDetailsDto?> UpdateAsync(int id, int userId, QuizInput input) =>
        throw new NotImplementedException("Task 4: update only the owner's quiz.");

    public Task<bool> DeleteAsync(int id, int userId) =>
        throw new NotImplementedException("Task 4: delete unused quizzes or archive attempted quizzes.");
}
