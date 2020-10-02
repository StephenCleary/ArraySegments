# Notice of Deprecation

This library has been pretty much replaced by `Span<T>`, which does essentially the same thing (and even more, since the compiler/runtime are `Span`-aware).

If there are any bugs in this library, they will continue to be addressed, but you shouldn't expect new features. Please migrate to using `Span<T>` on platforms which support it. For platforms that do not support `Span<T>`, feel free to continue using this library, but you should have a plan to move to platforms that support `Span<T>`.

# ArraySegments [![AppVeyor](https://img.shields.io/appveyor/ci/StephenCleary/ArraySegments.svg?style=plastic)](https://ci.appveyor.com/project/StephenCleary/ArraySegments) [![Coveralls](https://img.shields.io/coveralls/StephenCleary/ArraySegments.svg?style=plastic)](https://coveralls.io/r/StephenCleary/ArraySegments)

A library for slicing and dicing arrays (without copying).

[API Docs (core)](http://dotnetapis.com/pkg/Nito.ArraySegments/2.0-alpha-1)

[API Docs (streams)](http://dotnetapis.com/pkg/Nito.ArraySegments.Streams)

[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Nito.ArraySegments.svg?style=plastic)](https://www.nuget.org/packages/Nito.ArraySegments/)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Nito.ArraySegments.Streams.svg?style=plastic)](https://www.nuget.org/packages/Nito.ArraySegments.Streams/)
