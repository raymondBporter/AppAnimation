# AppAnimation

Character Studio, extracted from App2d with its authoring code, templates,
generators, rendering diagnostics, and authoring/integration tests.

Clone this repository beside an [App2d checkout](https://github.com/raymondBporter/App2d):

```text
source/
  App2d/
  AppAnimation/
  AppImage/
```

Requires Windows and the .NET 10 SDK or newer. Open `AppAnimation.slnx`, or run:

```powershell
dotnet build AppAnimation.slnx
dotnet run --project App2d.CharacterStudio
dotnet test App2d.CharacterStudio.Tests
dotnet run --project App2d.CharacterStudio -- --smoke-editor-surface artifacts/editor
```

Studio uses ordinary project references to App2d.Core, App2d.EditorUi, and the
App2d game. For another layout, pass `-p:App2dRoot=C:/path/to/App2d` to the build,
run, or test command. No submodules, copied engine code, or Git setup between
repositories.

Character assets remain in `App2d/Assets/Characters`. Studio edits that shared
source library, including when launched from Visual Studio or its build output.
Debug diagnostics and tests use the same App2d asset tree. Commit code changes
here and asset changes in App2d. The game solution does not build Studio.

See [the source map](App2d.CharacterStudio/README.md),
[Studio workflow](https://github.com/raymondBporter/App2d/blob/main/docs/character-studio.md),
and [character system guide](https://github.com/raymondBporter/App2d/blob/main/docs/character-system.md).
`tools/MoveReview/build.py` moves with Studio; set `APP2D_ROOT` when App2d is
elsewhere. Tests that need Studio authoring, generators, or its legacy traversal
fixture live here; other engine and game tests remain in App2d.
