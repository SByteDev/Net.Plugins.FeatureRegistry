# FeatureRegistry Plugin
![GitHub](https://img.shields.io/github/license/SByteDev/Net.Plugins.FeatureRegistry.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.Plugins.FeatureRegistry.svg)

[![Build Status](https://travis-ci.org/SByteDev/Net.Plugins.FeatureRegistry.svg?branch=master)](https://travis-ci.org/SByteDev/Net.Plugins.FeatureRegistry)
[![codecov](https://codecov.io/gh/SByteDev/Net.Plugins.FeatureRegistry/branch/master/graph/badge.svg)](https://codecov.io/gh/SByteDev/Net.Plugins.FeatureRegistry)
[![CodeFactor](https://www.codefactor.io/repository/github/sbytedev/net.plugins.featureregistry/badge)](https://www.codefactor.io/repository/github/sbytedev/net.plugins.featureregistry)

Provides a singleton to store the information about enabled or disabled application features. Features can be represented by a `string`, `Type` or `Enum`.

## Installation

Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package SByteDev.Plugins.FeatureRegistry
```

## Usage
```cs
using SByteDev.Plugins.FeatureRegistry;

FeatureRegistryPlugin.Instance["Feature"] = true;
var isEnabled = FeatureRegistryPlugin.Instance["Feature"];

FeatureRegistryPlugin.Instance[Features.Feature] = true;
var isEnabled = FeatureRegistryPlugin.Instance[Features.Feature];

FeatureRegistryPlugin.Instance[typeof(Feature)] = true;
var isEnabled = FeatureRegistryPlugin.Instance[typeof(Feature)];
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
