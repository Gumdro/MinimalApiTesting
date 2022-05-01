using MinimalApiDemo.Interfaces.Models;

namespace MinimalApiDemo.Models
{
    public class Alert : IMessage
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}
