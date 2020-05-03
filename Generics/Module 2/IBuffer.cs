using System.Collections.Generic;

namespace Generics.Module_2
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        public bool IsEmpty();
        public void Write(T value);
        public T Read();
    }
}