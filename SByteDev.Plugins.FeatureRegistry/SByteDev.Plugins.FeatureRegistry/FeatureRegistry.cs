using System;
using System.Collections.Generic;

namespace SByteDev.Plugins.FeatureRegistry
{
    internal sealed class FeatureRegistry : IFeatureRegistry
    {
        private readonly IDictionary<string, bool> _features;

        public bool this[Enum feature]
        {
            get => this[feature?.ToString()];
            set => this[feature?.ToString()] = value;
        }

        public bool this[Type feature]
        {
            get => this[feature?.ToString()];
            set => this[feature?.ToString()] = value;
        }

        public bool this[string feature]
        {
            get => Get(feature);
            set => Set(feature, value);
        }

        public FeatureRegistry()
        {
            _features = new Dictionary<string, bool>();
        }

        private bool Get(string feature)
        {
            if (feature == null)
            {
                throw new ArgumentNullException(nameof(feature));
            }

            return _features.TryGetValue(feature, out var isEnabled) && isEnabled;
        }

        private void Set(string feature, bool isEnabled)
        {
            if (feature == null)
            {
                throw new ArgumentNullException(nameof(feature));
            }

            _features[feature] = isEnabled;
        }
    }
}