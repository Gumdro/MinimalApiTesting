using System.Collections;

namespace MinimalApiDemo.Interfaces.Services
{
    public interface IRepository<T> where T : struct
    {
        public IEnumerable<T> Get();

        public IEnumerable<T> Add(T item);

        public IEnumerable<T> Delete(T item);

    }
}
