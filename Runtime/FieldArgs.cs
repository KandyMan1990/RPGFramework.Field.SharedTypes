using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace RPGFramework.Field.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct FieldArgs
    {
        public int        FieldId  { get; }
        public int        SpawnId  { get; }
        public float3     Position { get; }
        public quaternion Rotation { get; }

        public FieldArgs(int fieldId, int spawnId)
        {
            FieldId  = fieldId;
            SpawnId  = spawnId;
            Position = float3.zero;
            Rotation = quaternion.identity;
        }

        public FieldArgs(int fieldId, int spawnId, float3 position, quaternion rotation)
        {
            FieldId  = fieldId;
            SpawnId  = spawnId;
            Position = position;
            Rotation = rotation;
        }
    }
}