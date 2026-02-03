using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModuleArgs : IModuleArgs
    {
        string GetFieldId { get; }
    }

    public readonly struct FieldModuleArgs : IFieldModuleArgs
    {
        public string GetFieldId => m_FieldId;

        private readonly string m_FieldId;

        public FieldModuleArgs(string fieldId)
        {
            m_FieldId = fieldId;
        }
    }

    public interface IFieldModule : IModule
    {
        Task LoadMenuModuleAsync(byte menuId);
    }
}