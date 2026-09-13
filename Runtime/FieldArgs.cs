using System.Runtime.InteropServices;

namespace RPGFramework.Field.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct FieldArgs
    {
        public ulong FieldId { get; }

        public int SpawnId { get; }

        public FieldArgs(ulong fieldId, int spawnId)
        {
            FieldId = fieldId;
            SpawnId = spawnId;
        }
    }
}