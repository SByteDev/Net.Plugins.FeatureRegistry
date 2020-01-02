using System;

namespace SByteDev.Plugins.FeatureRegistry
{
    public interface IFeatureRegistry
    {
        bool this[Enum feature] { get; set; }
        bool this[Type feature] { get; set; }
        bool this[string feature] { get; set; }
    }
}