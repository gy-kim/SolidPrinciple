using System;
namespace ISP.Configuration1
{
    public interface IConfigurationSettings
    {
        string ApplicationName { get; }
        string AuthorName { get; }

        int CachDuration { get; }

        string DatabaseServerName { get; }
        string DatabaseName { get; }
        string DatabaseUserName { get; }
        string DatabasePassword { get; }

        string WebServiceBaseUri { get; }
    }
}
