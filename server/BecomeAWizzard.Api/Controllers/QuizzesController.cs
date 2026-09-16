using BecomeAWizzard.Api.DTOs;
using BecomeAWizzard.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BecomeAWizzard.Api.Controllers;

// TASK 4 STARTER - keep routes aligned with client/src/api/quizApi.js.
[Authorize, ApiController, Route("api/quizzes")]
public class QuizzesController(QuizService quizService) : ControllerBase
{
    [HttpGet] public IActionResult Published() => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpGet("mine")] public IActionResult Mine() => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpGet("{id:int}")] public IActionResult Get(int id) => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpPost] public IActionResult Create(QuizInput input) => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpPut("{id:int}")] public IActionResult Update(int id, QuizInput input) => StatusCode(StatusCodes.Status501NotImplemented);
    [HttpDelete("{id:int}")] public IActionResult Delete(int id) => StatusCode(StatusCodes.Status501NotImplemented);
}
