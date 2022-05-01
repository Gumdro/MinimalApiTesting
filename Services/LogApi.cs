using MinimalApiDemo.Interfaces.Services;
using MinimalApiDemo.Models;

namespace MinimalApiDemo.Services
{
    public class LogApi : IApi
    {
        private readonly ILogger<LogApi> _logger;
        private readonly Database _data;
        private const string Route = "/api/v1/Log";

        public LogApi(ILogger<LogApi> logger, Database data)
        {
            _logger = logger;
            _data   = data;
        }

        public void Register(WebApplication app)
        {
            app.MapGet(Route, Get)
               .Produces(200, typeof(IEnumerable<Log>))
               .AllowAnonymous()
               .WithDisplayName("Logging");

            app.MapPost(Route, Post)
               .Produces(200, typeof(IEnumerable<Log>))
               .AllowAnonymous()
               .WithDisplayName("Logging");
        }

        private IEnumerable<Log> Get() => _data.Get();

        private IEnumerable<Log> Post(Log log) => _data.Add(log);
    }
}
