#if ENABLE_RPG_FRAMEWORK_DEBUG
using System.Collections.Generic;

namespace RPGFramework.Field.SharedTypes
{
    /// <summary>The field database as the debug room reads it: every field the game has, by name.</summary>
    public interface IDebugFieldDatabase
    {
        /// <summary>Every field's name; a field is asked for by its name's hash.</summary>
        IReadOnlyList<string> FieldNames { get; }
    }
}
#endif
