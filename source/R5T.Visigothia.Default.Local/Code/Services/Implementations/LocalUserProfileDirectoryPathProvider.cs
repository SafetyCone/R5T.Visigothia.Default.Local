using System;

using R5T.T0064;


namespace R5T.Visigothia.Default.Local
{
    [ServiceImplementationMarker]
    public class LocalUserProfileDirectoryPathProvider : IUserProfileDirectoryPathProvider, IServiceImplementation
    {
        public string GetUserProfileDirectoryPath()
        {
            var userProfileDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return userProfileDirectoryPath;
        }
    }
}
