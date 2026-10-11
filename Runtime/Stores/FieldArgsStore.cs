namespace RPGFramework.Field.SharedTypes.Stores
{
    /// <summary>
    /// Which field the field module loads next, and where in it the player arrives. Anything sending the
    /// player to a field — a map jump, a new game, a load, a battle returning — sets it here; the field module
    /// reads it. Where it is kept is the implementation's business.
    /// </summary>
    public interface IFieldArgsStore
    {
        /// <summary>The field to load next and where the player arrives in it.</summary>
        FieldArgs Args { get; }

        /// <summary>Sets the field the field module loads next.</summary>
        void Set(FieldArgs args);
    }
}