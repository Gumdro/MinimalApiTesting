namespace MinimalApiDemo.Interfaces.Models
{
    public interface IMessage
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}
