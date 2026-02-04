using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModuleArgs : IModuleArgs
    {
        int    GetSpawnId { get; }
        string GetFieldId { get; }
    }

    public readonly struct FieldModuleArgs : IFieldModuleArgs
    {
        public int    GetSpawnId => m_SpawnId;
        public string GetFieldId => m_FieldId;

        public readonly int    m_SpawnId;
        public readonly string m_FieldId;

        public FieldModuleArgs(string fieldId, int spawnId)
        {
            m_FieldId = fieldId;
            m_SpawnId = spawnId;
        }
    }

    public interface IFieldModule : IModule
    {
        Task LoadMenuModuleAsync(byte menuId);
    }
}