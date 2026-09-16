using BecomeAWizzard.Api.Data;
using BecomeAWizzard.Api.DTOs;

namespace BecomeAWizzard.Api.Services;

// TASK 4 STARTER
// GameController depends on this service. The React PlayPage displays the returned DTO and must not calculate official game state.
public class GameService(AppDbContext db)
{
    public Task<AttemptStateDto> StartAsync(int userId, int quizId) =>
        throw new NotImplementedException("Task 4: create a quiz attempt.");

    public Task<AttemptStateDto?> GetStateAsync(int attemptId, int userId) =>
        throw new NotImplementedException("Task 4: return only the active user's attempt.");

    public Task<AnswerResultDto> SubmitAnswerAsync(int attemptId, int userId, SubmitAnswerRequest request) =>
        throw new NotImplementedException("Task 4: apply correctness, HP, score, streak and optional boss rules.");
}
