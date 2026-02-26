using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModuleArgs : IModuleArgs
    {
        string   GetFieldId               { get; }
        int      GetSpawnId               { get; }
        string[] LocalisationSheetsToLoad { get; }
    }

    public readonly struct FieldModuleArgs : IFieldModuleArgs
    {
        public string   GetFieldId               { get; }
        public int      GetSpawnId               { get; }
        public string[] LocalisationSheetsToLoad { get; }

        public FieldModuleArgs(string fieldId, int spawnId, string[] localisationSheetsToLoad)
        {
            GetFieldId               = fieldId;
            GetSpawnId               = spawnId;
            LocalisationSheetsToLoad = localisationSheetsToLoad;
        }
    }

    public interface IFieldModule : IModule
    {
        Task LoadMenuModuleAsync(byte menuId);
    }
}