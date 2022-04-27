using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Visigothia.Default.Local
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalUserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUserProfileDirectoryPathProvider> AddLocalUserProfileDirectoryPathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IUserProfileDirectoryPathProvider>(services => services.AddLocalUserProfileDirectoryPathProvider());
            return serviceAction;
        }
    }
}
