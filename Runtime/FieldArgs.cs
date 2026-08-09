using System.Runtime.InteropServices;

namespace RPGFramework.Field.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct FieldArgs
    {
        public int FieldId { get; }
        public int SpawnId { get; }

        public FieldArgs(int fieldId, int spawnId)
        {
            FieldId = fieldId;
            SpawnId = spawnId;
        }
    }
}