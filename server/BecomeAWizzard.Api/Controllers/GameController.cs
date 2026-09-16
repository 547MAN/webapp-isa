using BecomeAWizzard.Api.DTOs;
using BecomeAWizzard.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BecomeAWizzard.Api.Controllers;

// TASK 4 STARTER - keep routes aligned with client/src/api/gameApi.js.
[Authorize, ApiController, Route("api/game")]
public class GameController(GameService gameService) : ControllerBase
{
    [HttpPost("attempts")] public IActionResult Start(StartAttemptRequest request) => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpGet("attempts/{id:int}")] public IActionResult State(int id) => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpPost("attempts/{id:int}/answers")] public IActionResult Answer(int id, SubmitAnswerRequest request) => StatusCode(StatusCodes.Status501NotImplemented);
}
