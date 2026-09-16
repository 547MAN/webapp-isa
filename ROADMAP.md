# Roadmap - Tasks 3 and 4

Work through these checkpoints in order. Each checkpoint produces something testable and can be completed without another group member.

## Checkpoint 0 - Freeze the contracts

Read:

- `DTOs/AuthDtos.cs`, `QuizDtos.cs`, `GameDtos.cs`;
- `client/src/api/*.js` for required routes;
- `client/src/mocks/mockApi.js` for example responses;
- all classes under `Models/`.

The data path is:

```text
React -> API module -> Controller -> Service -> AppDbContext -> SQLite
```

Do not change both ends to hide a mismatch. Treat current routes and DTO fields as acceptance contracts.

## Checkpoint 1 - Map the domain

Confirm the entities and relationships:

- one User owns many Quizzes;
- one Quiz has many Questions and Attempts;
- one Question has many AnswerOptions;
- one User has many QuizAttempts;
- one QuizAttempt has many AnswerAttempts;
- one AnswerAttempt references the selected option and question.

Write a short explanation of why DTOs are separate from EF entities: DTOs control the public JSON shape and prevent accidental answer-key or navigation-property exposure.

## Checkpoint 2 - Implement AppDbContext

File: `Data/AppDbContext.cs`.

1. Add a unique index for normalized `User.Email`.
2. Configure owner and attempt relationships explicitly.
3. Restrict deleting users that own saved learning history.
4. Cascade Question/AnswerOption deletion when a quiz is safely removed.
5. Store `AttemptStatus` as readable text.
6. Verify nullable boss fields work when `BossFightEnabled=false`.

Delete the local development database after model changes while prototyping, or add migrations when the schema stabilizes. Never commit the generated SQLite database.

## Checkpoint 3 - Create idempotent seed data

File: `Data/SeedData.cs`.

1. Return immediately when users already exist.
2. Create one demo user and hash the password with `PasswordHasher<User>`.
3. Create one published quiz with at least three questions.
4. Give every question one and only one correct answer.
5. Save through the quiz aggregate.

Run the API twice and confirm the seed is not duplicated.

## Checkpoint 4 - Implement quiz queries

File: `Services/QuizService.cs`.

Start with read operations:

1. Published list: no tracking, published only, newest first.
2. Mine: filter by `OwnerId == userId`.
3. Details: include ordered questions and answer options; owner only.
4. Project entities to DTOs inside the query where practical.

The owner restriction belongs in every update/read/delete query, not only in the controller.

## Checkpoint 5 - Implement quiz commands

1. Validate positive HP/damage and at least one question.
2. Require at least three questions before publishing.
3. Require at least two options and exactly one correct option per question.
4. Require boss name, HP and damage only when boss mode is enabled.
5. Create/update the aggregate and save once.
6. On deletion, archive quizzes that already have attempts; otherwise remove them.

Test create, read, update, delete, unauthorized ownership and optional boss mode.

## Checkpoint 6 - Implement GameService

Start:

- load a published quiz;
- create an active attempt with player HP and optional boss HP;
- return the first safe question DTO.

Submit answer:

1. Load only the current user's active attempt.
2. Determine the expected question on the server.
3. Reject a question or option that is not active.
4. Correct: add points and streak.
5. Wrong: subtract points without going below zero, reduce HP and reset streak.
6. In boss phase, every third consecutive correct answer reduces boss HP and resets streak.
7. After ordinary questions, either finish or enter the optional boss phase.
8. Mark won/lost/completed and add final score to user XP once.
9. Persist an `AnswerAttempt`.

Return correctness and explanation only after submission.

## Checkpoint 7 - Implement controllers

Controllers translate HTTP to service calls:

- use `User.GetUserId()` for ownership;
- return 200 for successful reads/updates;
- return 201 with a location for create;
- return 204 for delete;
- return 400 for invalid domain input;
- return 404 for missing or inaccessible resources;
- keep business calculations out of controllers.

Implement routes exactly as declared in the API modules. Test each route in Swagger before switching the frontend away from mocks.

## Checkpoint 8 - Implement progress queries

Use no-tracking queries where no update is needed.

- Progress: total XP, completed quizzes, defeated bosses, answers and accuracy.
- History: current user's attempts, newest first.
- Leaderboard: users ordered by XP, limited to 20.

Avoid loading complete tables when a projection or aggregate query is enough.

## Checkpoint 9 - Verification and handoff

Run backend build, frontend build and endpoint tests. Record:

- database relationships and delete behaviour;
- exact route/DTO contracts;
- gameplay boundary tests;
- known limitations.

Copy only completed backend files and required schema/configuration changes into the later shared repository. Do not copy the mock adapter as backend implementation.
