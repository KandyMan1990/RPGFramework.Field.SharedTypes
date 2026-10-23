#if ENABLE_RPG_FRAMEWORK_DEBUG
namespace RPGFramework.Field.SharedTypes.Constants
{
    /// <summary>What the field tells Core happened for the debug room, for the game's module router to route.</summary>
    public static class DebugFieldOutcomes
    {
        /// <summary>The debug room's combination was held. The top of the range, clear of a game's own outcomes.</summary>
        public const byte DEBUG_ROOM = 255;
    }
}
#endif
