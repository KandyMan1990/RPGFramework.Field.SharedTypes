namespace RPGFramework.Field.SharedTypes.Providers
{
    public interface IFieldArgsProvider
    {
        FieldArgs Get { get; }
        void      Set(FieldArgs args);
    }
    
    public sealed class FieldArgsProvider : IFieldArgsProvider
    {
        private FieldArgs m_Args;

        FieldArgs IFieldArgsProvider.Get => m_Args;

        void IFieldArgsProvider.Set(FieldArgs args) => m_Args = args;
    }
}