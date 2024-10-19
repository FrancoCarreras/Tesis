using System.Collections.Generic;

namespace Tesis.AdminFutbol.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
