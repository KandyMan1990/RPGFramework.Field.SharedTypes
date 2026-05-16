using System.Runtime.InteropServices;
using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;
using Unity.Mathematics;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModuleArgs : IModuleArgs
    {
        int        FieldId  { get; }
        int        SpawnId  { get; }
        float3     Position { get; }
        quaternion Rotation { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct FieldModuleArgs : IFieldModuleArgs
    {
        public int        FieldId  { get; }
        public int        SpawnId  { get; }
        public float3     Position { get; }
        public quaternion Rotation { get; }

        public FieldModuleArgs(int fieldId, int spawnId)
        {
            FieldId  = fieldId;
            SpawnId  = spawnId;
            Position = float3.zero;
            Rotation = quaternion.identity;
        }

        public FieldModuleArgs(int fieldId, int spawnId, float3 position, quaternion rotation)
        {
            FieldId  = fieldId;
            SpawnId  = spawnId;
            Position = position;
            Rotation = rotation;
        }
    }

    public interface IFieldModule : IModule
    {
        Task LoadMenuModuleAsync(byte menuId);
    }
}