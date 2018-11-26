namespace GlobalX.AspNetCore.Hateoas.Abstractions
{
    public interface IStateConverterCollectionProvider
    {
        StateConverterCollection StateConverters { get; }
    }
}