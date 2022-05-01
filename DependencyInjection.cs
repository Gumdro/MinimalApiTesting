using MinimalApiDemo.Interfaces.Services;
using MinimalApiDemo.Services;

namespace MinimalApiDemo
{
    public static class DependencyInjection
    {
        public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
        {
            Terminal.AddLogo();
            _ = builder.Services
                       .AddEndpointsApiExplorer()
                       .AddSwaggerGen()
                       .AddAuthorization()
                       .AddSingleton<Database>()
                       .AddTransient<IApi, LogApi>();

            return builder;
        }

        private static void ConfigureRoutes(this WebApplication app)
        {
            var routeGroups = app.Services.GetServices<IApi>();
            foreach (var group in routeGroups)
            {
                group.Register(app);
            }
        }

        public static WebApplication ConfigureApp(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.ConfigureRoutes();
            app.UseHttpsRedirection()
               .UseAuthorization();

            return app;
        }
    }
}
