# Become a Wizzard - Isabell's independent workspace

This repository is a runnable learning environment for **Isabell Korto**.

## Prerequisites

- .NET 10 SDK
- Node.js 20 or newer
- npm

## Your responsibility

- **Task 3:** writing and coding data access with Entity Framework Core and SQLite.
- **Task 4:** writing and coding business logic and ASP.NET Core controllers.

Authentication, AJAX modules and the finished React interface are supplied. Your data, service and controller areas contain contracts, starter code and TODO markers rather than finished implementations.

## Start without waiting for the group

The frontend uses an in-memory mock adapter by default:

```bash
cd client
npm ci
npm run dev
```

This lets you inspect every required screen and JSON shape while the backend is incomplete. The adapter lives in `client/src/mocks/mockApi.js` and is reference behaviour, not your final backend.

After an endpoint works, start the API and change `VITE_USE_MOCK_API=false` in `client/.env.development`.

```bash
dotnet run --project server/BecomeAWizzard.Api
```

## Start here

Read [ROADMAP.md](ROADMAP.md), then implement in dependency order:

1. Models and `Data/AppDbContext.cs`
2. `Data/SeedData.cs`
3. `Services/QuizService.cs`
4. `Services/GameService.cs`
5. Quiz and game controllers
6. `ProgressController.cs`
7. Integration tests and written data/business sections

## Important boundaries

- Keep existing DTO property names and API routes stable.
- Always filter owned data by the authenticated user ID.
- The backend is authoritative for correctness, HP, score, streak and boss damage.
- Boss fights are optional per quiz.
- Never return `IsCorrect` before an answer is submitted.

## Definition of done

- SQLite is created locally with all required relationships and constraints.
- Seed data is idempotent and contains a usable demo account and quiz.
- A user can CRUD only their own quizzes.
- Valid published quizzes can be played from start to finish.
- Wrong answers reduce HP and reset the streak.
- Three consecutive correct boss answers cause damage.
- Non-boss quizzes end after the ordinary questions.
- Progress, history and leaderboard reflect saved attempts.
