namespace RPGFramework.Field.SharedTypes.Constants
{
    /// <summary>What the field tells Core happened, for the game's module router to route.</summary>
    public static class FieldOutcomes
    {
        /// <summary>The player opened the menu; its <c>MenuArgs</c> are stored.</summary>
        public const byte OPEN_MENU = 1;

        /// <summary>A battle starts; its <c>BattleArgs</c> are stored, and the field's state is kept for its return.</summary>
        public const byte START_BATTLE = 2;

        /// <summary>A script ended the game.</summary>
        public const byte GAME_OVER = 3;
    }
}
