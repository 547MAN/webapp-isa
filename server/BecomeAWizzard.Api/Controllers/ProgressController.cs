using BecomeAWizzard.Api.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BecomeAWizzard.Api.Controllers;

// TASK 4 STARTER - progress queries depend directly on Task 3's persisted attempts and answer history.
[Authorize, ApiController, Route("api/progress")]
public class ProgressController(AppDbContext db) : ControllerBase
{
    [HttpGet] public IActionResult Get() => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpGet("history")] public IActionResult History() => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpGet("leaderboard")] public IActionResult Leaderboard() => StatusCode(StatusCodes.Status501NotImplemented);
}
