using MinimalApiDemo.Models;

namespace MinimalApiDemo.Services
{
    public class Database
    {
        private IList<Log> DataList { get; set; } = new List<Log>();

        public IEnumerable<Log> Add(Log item)
        {
            DataList.Add(item);
            return DataList;
        }

        public IEnumerable<Log> Delete(Log item)
        {
            DataList.Remove(item);
            return DataList;
        }

        public IEnumerable<Log> Get() => DataList;
    }
}
