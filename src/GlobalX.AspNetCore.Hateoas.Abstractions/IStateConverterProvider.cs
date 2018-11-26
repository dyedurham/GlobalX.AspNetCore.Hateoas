namespace GlobalX.AspNetCore.Hateoas.Abstractions
{
    public interface IStateConverterProvider
    {
        IStateConverter CreateConverter(StateConverterProviderContext context);
    }
}