using System;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Field.SharedTypes
{
    public interface IFieldModuleArgs : IModuleArgs
    {
        Type Field { get; }
    }
    
    public readonly struct FieldModuleArgs<TField> : IFieldModuleArgs
    {
        public Type Field => typeof(TField);
    }
    
    public interface IFieldModule : IModule
    {
    }
}