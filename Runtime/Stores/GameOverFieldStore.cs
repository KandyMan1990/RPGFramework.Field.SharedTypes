namespace RPGFramework.Field.SharedTypes.Stores
{
    /// <summary>
    /// The field a game over sends the player to, and where in it they arrive: a field like any other, whose scripts
    /// decide how the game over looks and when it ends. Chosen by the game, and read by the router.
    /// </summary>
    public interface IGameOverFieldStore
    {
        /// <summary>The game-over field and the spawn point the player arrives at.</summary>
        FieldArgs Args { get; }
    }
}