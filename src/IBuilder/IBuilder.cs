namespace IBuilder;

public interface IBuilder<out T>
{
    T Build();
}

public interface IBuilder<in TIn, out TOut>
{
    TOut Build(TIn input);
}