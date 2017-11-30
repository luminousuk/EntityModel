EntityModel
=======

AppVeyor: [![Build status](https://ci.appveyor.com/api/projects/status/mlmmdvxdjlvwrab3?svg=true)](https://ci.appveyor.com/project/chrispickford/entitymodel)

Reusable entity interfaces and abstract classes which can be used when constructing a persistence-ignorant domain model.

## Packages
You can get the latest version from [NuGet](https://www.nuget.org/packages/Luminous.Common.EntityModel/) package manager using the following command:
```
PM> Install-Package Luminous.Common.EntityModel
```

## Usage
Simply create your entity models, inheriting from either `Entity`, `CreatableEntity` or `ModifiableEntity`.

A repository interface `IRepository` is also included.