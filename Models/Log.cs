using System.ComponentModel.DataAnnotations;
using MinimalApiDemo.Interfaces.Models;

namespace MinimalApiDemo.Models
{
    public struct Log : IMessage
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public string Host { get; set; }

        [Required]
        public string Team { get; set; }

        [Required]
        public string Message { get; set; }
        public string CodeLocation { get; set; }

        [Required]
        public DateTime Created { get; set; }
    }
}
