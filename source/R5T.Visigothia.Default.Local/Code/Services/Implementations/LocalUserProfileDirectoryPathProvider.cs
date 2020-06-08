using System;


namespace R5T.Visigothia.Default.Local
{
    public class LocalUserProfileDirectoryPathProvider : IUserProfileDirectoryPathProvider
    {
        public string GetUserProfileDirectoryPath()
        {
            var userProfileDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return userProfileDirectoryPath;
        }
    }
}
