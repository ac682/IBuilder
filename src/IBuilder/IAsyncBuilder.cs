using System.Threading.Tasks;

namespace IBuilder;

public interface IAsyncBuilder<T>
{
    Task<T> BuildAsync();
}

public interface IAsyncBuilder<TIn, TOut>
{
    Task<TOut> BuildAsync(TIn input);
}