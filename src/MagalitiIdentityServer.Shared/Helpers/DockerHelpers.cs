﻿using Microsoft.Extensions.Configuration;
using MagalitiIdentityServer.Shared.Configuration.Common;

namespace MagalitiIdentityServer.Shared.Helpers
{
    public class DockerHelpers
    {
        public static void UpdateCaCertificates()
        {
            "update-ca-certificates".Bash();
        }

        public static void ApplyDockerConfiguration(IConfiguration configuration)
        {
            var dockerConfiguration = configuration.GetSection(nameof(DockerConfiguration)).Get<DockerConfiguration>();

            if (dockerConfiguration != null && dockerConfiguration.UpdateCaCertificate)
            {
                UpdateCaCertificates();
            }
        }
    }
}





