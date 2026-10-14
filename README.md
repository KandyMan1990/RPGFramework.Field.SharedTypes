# RPGFramework.Field.SharedTypes

What other modules need to send the player to the field, without depending on the Field package itself.

Requires Unity 6000.6 or newer and RPGFramework.Core.SharedTypes.

- **`IFieldModule`**: the field module, as Core resolves it.
- **`FieldConstants.MODULE_ID`**: its module id, 0.
- **`FieldArgs`**: where the player goes, as the hash of a field's name and the id of a spawn point in it.
- **`IFieldArgsStore`**: where `FieldArgs` are kept. Anything sending the player to a field sets it: a new game, a
  loaded save, a battle that has ended, or a field script's jump. The field module reads it as it enters. The Field
  package's own store keeps it in the save, so a loaded game resumes in the field it was saved in.
- **`FieldOutcomes`**: what the field reports as it hands over, for the game's module router to route — the menu
  opened, a battle started, or a script ended the game.
- **`IGameOverFieldStore`**: the field a game over sends the player to, and the spawn point they arrive at; the game
  picks it in its variable map, and the router reads it. The Field package's `GameOverFieldStore` implements it.

```csharp
fieldArgsStore.Set(new FieldArgs(Fnv1a64.Hash("Town"), 0));
```
