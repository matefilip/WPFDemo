using Microsoft.Extensions.DependencyInjection;
using WPFDemo.EF;
using WPFDemo.Repository;
using WPFDemo.Repository.Interfaces;

namespace WPFDemo.IoC
{
    public static class ServiceProviderExtensions
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        public static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<ApplicationDbContext>();

            serviceCollection.AddTransient<IOrderRepository, OrderRepository>();

            // Uncomment this line to run app without db.
             serviceCollection.AddSingleton<IOrderRepository, InMemoryOrderRepository>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
