#if ENABLE_RPG_FRAMEWORK_DEBUG
namespace RPGFramework.Field.SharedTypes
{
    /// <summary>A spawn point in a field: the id a jump names, and its object's name in the field.</summary>
    public readonly struct DebugSpawnPoint
    {
        public int    Id   { get; }
        public string Name { get; }

        public DebugSpawnPoint(int id, string name)
        {
            Id   = id;
            Name = name;
        }
    }
}
#endif
