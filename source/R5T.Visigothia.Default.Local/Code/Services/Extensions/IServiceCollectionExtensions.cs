using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;



namespace R5T.Visigothia.Default.Local
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalUserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLocalUserProfileDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUserProfileDirectoryPathProvider, LocalUserProfileDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="LocalUserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUserProfileDirectoryPathProvider> AddLocalUserProfileDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IUserProfileDirectoryPathProvider>.New(() => services.AddLocalUserProfileDirectoryPathProvider());
            return serviceAction;
        }
    }
}
