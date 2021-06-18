using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SByteDev.Plugins.FeatureRegistry.Tests")]

namespace SByteDev.Plugins.FeatureRegistry
{
    public static class FeatureRegistryPlugin
    {
        private static readonly Lazy<IFeatureRegistry> FeatureRegistryLazy;

        public static bool IsSupported => true;

        public static IFeatureRegistry Instance => FeatureRegistryLazy.Value;

        static FeatureRegistryPlugin()
        {
            FeatureRegistryLazy = new Lazy<IFeatureRegistry>(() => new FeatureRegistry());
        }
    }
}