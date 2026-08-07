using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModule : IModule
    {
        void RequestMenuModule(byte menuId);
    }
}