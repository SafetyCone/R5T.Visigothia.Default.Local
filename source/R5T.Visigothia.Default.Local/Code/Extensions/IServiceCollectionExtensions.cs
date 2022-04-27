using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;



namespace R5T.Visigothia.Default.Local
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalUserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLocalUserProfileDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUserProfileDirectoryPathProvider, LocalUserProfileDirectoryPathProvider>();

            return services;
        }
    }
}
