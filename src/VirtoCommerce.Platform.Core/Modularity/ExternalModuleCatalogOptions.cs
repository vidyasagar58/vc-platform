using System;

namespace VirtoCommerce.Platform.Core.Modularity
{
    public class ExternalModuleCatalogOptions
    {
        public Uri ModulesManifestUrl { get; set; }
        public string AuthorizationToken { get; set; }
        public string[] AutoInstallModuleBundles { get; set; } = new[] { "commerce" };
        public bool IncludePrerelease { get; set; }
    }
}
