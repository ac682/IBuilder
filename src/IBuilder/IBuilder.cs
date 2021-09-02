using System;

namespace IBuilder
{
    public interface IBuilder<out T>
    {
    	T Build();
    }
}
