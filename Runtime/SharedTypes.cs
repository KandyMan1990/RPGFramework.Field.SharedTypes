using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModuleArgs : IModuleArgs
    {
        ulong GetFieldId { get; }
    }

    public readonly struct FieldModuleArgs : IFieldModuleArgs
    {
        public ulong GetFieldId => m_FieldId;

        private readonly ulong m_FieldId;

        public FieldModuleArgs(ulong fieldId)
        {
            m_FieldId = fieldId;
        }
    }

    public interface IFieldModule : IModule
    {
        Task LoadMenuModuleAsync(byte menuId);
    }
}