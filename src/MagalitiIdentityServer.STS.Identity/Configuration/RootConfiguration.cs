using MagalitiIdentityServer.Shared.Configuration.Identity;
using MagalitiIdentityServer.STS.Identity.Configuration.Interfaces;

namespace MagalitiIdentityServer.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}





