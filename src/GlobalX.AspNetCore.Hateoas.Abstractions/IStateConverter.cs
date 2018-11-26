using System.Threading.Tasks;

namespace GlobalX.AspNetCore.Hateoas.Abstractions
{
    public interface IStateConverter
    {
        Task<object> ConvertAsync(StateConverterContext context);
    }
}