#if ENABLE_RPG_FRAMEWORK_DEBUG
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RPGFramework.Field.SharedTypes
{
    /// <summary>Reads a field's spawn points, for the debug room to offer a jump to each.</summary>
    public interface IDebugSpawnPointLoader
    {
        /// <summary>The field's spawn points, read from its bundle, which is opened for them and closed again.</summary>
        Task<IReadOnlyList<DebugSpawnPoint>> LoadAsync(ulong fieldNameHash);
    }
}
#endif
