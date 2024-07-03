using BuildingBlocks.Exceptions.Handler;

namespace Ordering.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services)
        {
            services.AddCarter();

            services.AddExceptionHandler<CustomExceptionHandler>();
            return services;
        }

        public static WebApplication useApiServices(this WebApplication app)
        {
            app.MapCarter();
            return app;
        }

    }
}
