using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModule : IModule
    {
        Task LoadMenuModuleAsync(byte menuId);
    }
}